Option Strict Off
Public Class frmMain

#Region " Global Variable Declaration "
    Private bFormLoaded As Boolean
    Private bValidating As Boolean
    Private iCountVis As Integer
    Private iCountTime As Integer
    Private bSendON As Boolean

    Private OPC_Class As New OPC_Values
    Private sOPCItemValue(4) As String
#End Region

#Region " Load/End "
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Tetrapak
        niTray.Visible = False
        LoadSettings()

        bFormLoaded = True
    End Sub

    Private Sub LoadSettings()
        cbAutoSend.Checked = My.Settings.frmMain_AutoSend
        txtIPAddress.Text = My.Settings.frmMain_RemoteIPAddress
        txtPort.Text = My.Settings.frmMain_RemotePort.ToString
    End Sub
#End Region

#Region " Form Action "
    Private Sub butOPCForm_Click(sender As Object, e As EventArgs) Handles butOPCForm.Click
        Try
            Dim frmOpenOPC As New frmOPC
            Me.Cursor = Cursors.AppStarting
            frmOpenOPC.Show()

        Catch
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub


    Private Sub contexMenuTrayOpen_Click(sender As Object, e As EventArgs) Handles contexMenuTrayOpen.Click
        niTray.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub contexMenuTrayExit_Click(sender As Object, e As EventArgs) Handles contexMenuTrayExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub niTray_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles niTray.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Me.Refresh()
        Else
            If Me.WindowState = FormWindowState.Minimized Then
                niTray.Visible = False
                Me.Show()
                Me.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not bFormLoaded Then Return

        If Me.WindowState = FormWindowState.Minimized Then
            niTray.Visible = True
            Me.Hide()
        End If
    End Sub


    Private Sub cbAutoSend_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoSend.CheckedChanged
        If Not bFormLoaded Then Return

        Try
            If cbAutoSend.CheckState = CheckState.Checked Then
                My.Settings.frmMain_AutoSend = True
                bSendON = True
                butSendValues.Text = "Stop"
                tmrUpdate.Enabled = True
            Else
                My.Settings.frmMain_AutoSend = False
            End If
            My.Settings.Save()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtIPAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIPAddress.Validating
        If Not bFormLoaded Then Return

        Try
            Dim actText As TextBox = CType(sender, TextBox)
            bValidating = True

            If IsNumeric(actText.Text) Then
                Dim iActValue As Integer = CInt(actText.Text)
                If actText.Name = "txtPort" Then
                    If iActValue <= 0 Then
                        actText.Text = "0"
                        My.Settings.frmMain_RemotePort = 0
                    Else
                        My.Settings.frmMain_RemotePort = iActValue
                    End If
                ElseIf actText.Name = "txtIPAddress" Then
                    My.Settings.frmMain_RemoteIPAddress = actText.Text
                End If
            Else
                If actText.Name = "txtPort" Then
                    actText.Text = My.Settings.frmMain_RemotePort.ToString
                End If
            End If
            My.Settings.Save()

        Catch ex As Exception
            If Not ex Is Nothing Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Error")
            Else
                MsgBox("Unknown error", MsgBoxStyle.Exclamation, " Error")
            End If
        Finally
            bValidating = False
        End Try
    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        If Not bFormLoaded Or bValidating Then Return

        Try
            Dim actText As TextBox = CType(sender, TextBox)
            If String.IsNullOrEmpty(actText.Text) Then Return

            If Not IsNumeric(actText.Text) Then
                If actText.Name = "txtPort" Then
                    actText.Text = My.Settings.frmMain_RemotePort.ToString
                End If
            End If

        Catch ex As Exception
            If Not ex Is Nothing Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Error")
            Else
                MsgBox("Unknown error", MsgBoxStyle.Exclamation, " Error")
            End If
        End Try
    End Sub

    Private Sub butSendValues_Click(sender As Object, e As EventArgs) Handles butSendValues.Click
        If butSendValues.Text = "Send Values" Then
            bSendON = True
            butSendValues.Text = "Stop"
            tmrUpdate.Enabled = True
        Else
            butSendValues.Text = "Send Values"
            bSendON = False
            tmrUpdate.Enabled = False
            iCountTime = 0
            prbBacground.Value = 0
        End If
    End Sub
#End Region

#Region " Value Update "
    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        iCountTime += 10
        prbBacground.Value = iCountTime
        If iCountTime >= 100 Then
            iCountTime = 0
        End If
        If bSendON Then
            SendUDP()
        ElseIf cbAutoSend.Checked Then
            SendUDP()
            butSendValues.Text = "Stop"
        Else
            butSendValues.Text = "Send Values"
        End If
    End Sub

    Private Sub SendUDP()
        Try
            Static bOPC_Done As Boolean

            If Not bOPC_Done Then
                If Not OPC_Class.Main() Then
                    Return
                Else
                    bOPC_Done = True
                End If
            End If

            Dim SendingSocket As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            Dim IPAddress As IPAddress = IPAddress.Parse(My.Settings.frmMain_RemoteIPAddress)
            Dim SendingEndPoint As New IPEndPoint(IPAddress, My.Settings.frmMain_RemotePort)
            Dim sValues As String
            Dim sendBytes As [Byte]()

            sValues = OPC_Class.sOPCItemValue(1) + vbCr     'Tag1
            sValues += OPC_Class.sOPCItemValue(2) + vbCr    'Tag2
            sValues += OPC_Class.sOPCItemValue(3) + vbCr    'Tag3
            sValues += OPC_Class.sOPCItemValue(4) + vbCr    'Tag4
            sendBytes = Encoding.ASCII.GetBytes(sValues)

            If sendBytes.Count > 0 Then
                SendingSocket.SendTo(sendBytes, SendingEndPoint)
                System.Threading.Thread.Sleep(500)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class


Public Class OPC_Values

#Region " Global Variable Declaration "
    Dim AnOPCServer As OPCAutomation.OPCServer
    Dim ConnectedOPCServer As OPCAutomation.OPCServer
    Dim WithEvents ConnectedGroup As OPCAutomation.OPCGroup

    Const NUMITEMS As Integer = 4
    Dim OPCItemIDs(NUMITEMS) As String
    Dim Clients(NUMITEMS) As Int32
    Dim OPCItemName(NUMITEMS) As Object
    Dim OPCItemIsArray(NUMITEMS) As Integer
    Dim ItemServerHandles As System.Array

    Friend bOPCItemValue(NUMITEMS) As Boolean
    Friend sOPCItemValue(NUMITEMS) As String

    Dim bValidating As Boolean

#End Region

#Region " Load/End "
    Public Function Main() As Boolean
        Dim AllOPCServers As Object
        Dim OPCServerOK As Boolean

        Try
            AnOPCServer = New OPCAutomation.OPCServer
            AllOPCServers = AnOPCServer.GetOPCServers
            For Each value As Object In CType(AllOPCServers, Array)
                If value.ToString = My.Settings.frmOPC_OPCServerName Then
                    OPCServerOK = True
                    Exit For
                End If
            Next

            If OPCServerOK Then
                If Not UpdateOPC() Then
                    Exit Try
                End If
                If Not ConnectOPC() Then
                    Exit Try
                End If
                If Not ConnectValues() Then
                    Exit Try
                End If
            Else
                MessageBox.Show("Selected OPC server is not available" & vbCr & "Please select a new server:", "Error server is not available", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Try
            End If
            Return True


        Catch ex As Exception
            If Not ex Is Nothing Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Error")
            Else
                MsgBox("Unknown error", MsgBoxStyle.Exclamation, " Error")
            End If
        Finally
            AllOPCServers = Nothing
            AnOPCServer = Nothing
        End Try
        Return False
    End Function
#End Region

#Region " Update Values "
    Private Function UpdateOPC() As Boolean
        Try
            If String.IsNullOrEmpty(My.Settings.frmOPC_OPCServerName) Then
                MsgBox("No OPC Server selected" & vbCrLf & "Please select new OPC server first", MsgBoxStyle.Exclamation, " Missing OPC Server")
                Return False
            End If
            ConnectedOPCServer = New OPCAutomation.OPCServer
            ConnectedOPCServer.Connect(My.Settings.frmOPC_OPCServerName, My.Settings.frmOPC_OPCNodeName)

            OPCItemName(1) = My.Settings.frmOPC_Address_Tag1
            OPCItemName(2) = My.Settings.frmOPC_Address_Tag2
            OPCItemName(3) = My.Settings.frmOPC_Address_Tag3
            OPCItemName(4) = My.Settings.frmOPC_Address_Tag4
            Return True

        Catch ex As Exception
            ConnectedOPCServer = Nothing
            MessageBox.Show("OPC server connect failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
        Return False
    End Function

    Private Function ConnectOPC() As Boolean
        Try
            ConnectedOPCServer.OPCGroups.DefaultGroupIsActive = My.Settings.frmOPC_GroupActiveState
            ConnectedOPCServer.OPCGroups.DefaultGroupDeadband = CSng(Val(My.Settings.frmOPC_GroupDeadBand))
            ConnectedGroup = ConnectedOPCServer.OPCGroups.Add(My.Settings.frmOPC_OPCGroupName)
            ConnectedGroup.UpdateRate = CInt(Val(My.Settings.frmOPC_GroupUpdateRate))
            ConnectedGroup.IsSubscribed = True
            Return True


        Catch ex As Exception
            If Not ex Is Nothing Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Error")
            Else
                MsgBox("Unknown error", MsgBoxStyle.Exclamation, " Error")
            End If
        End Try
        Return False
    End Function

    Private Function ConnectValues() As Boolean
        If Not ConnectedGroup Is Nothing Then
            Try
                Dim ItemCount As Integer = NUMITEMS
                Dim AddItemServerErrors As System.Array

                For i As Short = 1 To NUMITEMS
                    OPCItemIDs(i) = CStr(OPCItemName(i))
                    Clients(i) = i
                Next i
                AddItemServerErrors = {Single.MaxValue}
                ConnectedGroup.OPCItems.DefaultIsActive = True
                ConnectedGroup.OPCItems.AddItems(ItemCount, OPCItemIDs, Clients, ItemServerHandles, AddItemServerErrors)

                Dim AnItemIsGood As Boolean = False
                Dim iValue As Integer

                For Each value As Object In CType(AddItemServerErrors, Array)
                    iValue += 1
                    If CInt(value) = 0 Then
                        AnItemIsGood = True
                        bOPCItemValue(iValue) = True
                    Else
                        bOPCItemValue(iValue) = False
                        sOPCItemValue(iValue) = ""
                    End If
                Next

                If AnItemIsGood Then
                    For i As Short = 1 To NUMITEMS
                        'OPCItemName(i).Enabled = False                        ' Disable the Item Name cotnrols while now that they have been added to the group.
                    Next i
                Else
                    MessageBox.Show("The OPC Server has not accepted any of the item you have entered, check your item names and try again.", "OPC Add Item", MessageBoxButtons.OK)
                    Exit Try
                End If
                Return True

            Catch ex As Exception
                MessageBox.Show("OPC server add items failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
        Return False
    End Function

    Private Sub ConnectedGroup_DataChange(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef refClients As System.Array, ByRef refItemValues As System.Array, ByRef refQualities As System.Array, ByRef refTimeStamps As System.Array) Handles ConnectedGroup.DataChange
        Try
            Dim i As Integer
            For Each ItemValue In refItemValues
                i += 1
                sOPCItemValue(i) = ItemValue.ToString
            Next

        Catch ex As Exception
            MessageBox.Show("OPC DataChange failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region

End Class