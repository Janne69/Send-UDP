Option Strict Off
Public Class frmOPC

#Region " Global Variable Declaration "
    Dim WithEvents AnOPCServer As OPCAutomation.OPCServer
    Dim WithEvents ConnectedOPCServer As OPCAutomation.OPCServer
    Dim WithEvents ConnectedGroup As OPCAutomation.OPCGroup
    Const NUMITEMS As Integer = 4

    ' OPC Item related data
    Dim OPCItemIDs(NUMITEMS) As String
    Dim ClientHandles(NUMITEMS) As Int32
    Dim ItemServerHandles As System.Array

    ' Arrays are used to provide iterative access to sets of controls
    Dim OPCItemName(NUMITEMS) As Object
    Dim OPCItemValue(NUMITEMS) As Object
    'Dim OPCItemValueToWrite(NUMITEMS) As Object
    'Dim OPCItemWriteButton(NUMITEMS) As Object
    'Dim OPCItemActiveState(NUMITEMS) As Object
    'Dim OPCItemSyncReadButton(NUMITEMS) As Object
    'Dim OPCItemQuality(NUMITEMS) As Object
    Dim OPCItemIsArray(NUMITEMS) As Integer
    Private bValidating As Boolean

#End Region


    Private Sub frmOPC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim AllOPCServers As Object
            Me.Icon = My.Resources.Tetrapak
            Me.Cursor = Cursors.AppStarting
            Me.Refresh()

            UpdateForm()
            SimpleOPCInterface()
            AnOPCServer = New OPCAutomation.OPCServer
            AvailableOPCServerList.Items.Clear()
            AllOPCServers = AnOPCServer.GetOPCServers

            Dim i As Integer
            For i = LBound(CType(AllOPCServers, Array)) To UBound(CType(AllOPCServers, Array))
                AvailableOPCServerList.Items.Add(AllOPCServers(i))
            Next i
            AnOPCServer = Nothing
            Me.Cursor = Cursors.Arrow

        Catch Ex As Exception
            MessageBox.Show("List OPC servers failed: " + Ex.Message, "OPCSample", MessageBoxButtons.OK)
            Me.Close()
        End Try
    End Sub

    Private Sub UpdateForm()
        Try
            txtOPC_Address_Tag1.Text = My.Settings.frmOPC_Address_Tag1
            txtOPC_Address_Tag2.Text = My.Settings.frmOPC_Address_Tag2
            txtOPC_Address_Tag3.Text = My.Settings.frmOPC_Address_Tag3
            txtOPC_Address_Tag4.Text = My.Settings.frmOPC_Address_Tag4

            'butFrameBorderColor.BackColor = Color.FromArgb(My.Settings.frmShowData_ColorFrameBorder)
            'txtFontName.Font = New Font(My.Settings.frmShowData_FontName, 8.25, CType(My.Settings.frmShowData_FontStyle, FontStyle), GraphicsUnit.Point)
            'optBackgroundColorSelectValue1.Checked = My.Settings.frmShowData_BackgroundColorSelectValue1
            'If My.Settings.frmShowData_HideValue1 Then
            '    chbHideValue1.CheckState = CheckState.Checked
            'End If


        Catch ex As Exception
            If Not ex Is Nothing Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Error")
            Else
                MsgBox("Unknown error", MsgBoxStyle.Exclamation, " Error")
            End If
        End Try
    End Sub

    Private Sub SimpleOPCInterface()
        ' Initialize controls
        AvailableOPCServerList.Items.Add("Click on 'List OPC Servers' to start")

        ' Initialize arrays for iterative access to controls
        OPCItemName(1) = txtOPC_Address_Tag1
        OPCItemName(2) = txtOPC_Address_Tag2
        OPCItemName(3) = txtOPC_Address_Tag3
        OPCItemName(4) = txtOPC_Address_Tag4

        OPCItemValue(1) = OPCItemValue1
        OPCItemValue(2) = OPCItemValue2
        OPCItemValue(3) = OPCItemValue3
        OPCItemValue(4) = OPCItemValue4
    End Sub

    Private Sub AvailableOPCServerList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableOPCServerList.SelectedIndexChanged
        OPCServerName.Text = AvailableOPCServerList.Text
    End Sub

    Private Sub OPCServerConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCServerConnect.Click
        If InStr(OPCServerName.Text, "Click") = 0 Then
            Try
                ConnectedOPCServer = New OPCAutomation.OPCServer
                ConnectedOPCServer.Connect(OPCServerName.Text, OPCNodeName.Text)
                My.Settings.frmOPC_OPCServerName = OPCServerName.Text
                My.Settings.frmOPC_OPCNodeName = OPCNodeName.Text
                My.Settings.Save()

                DisconnectFromServer.Enabled = True
                OPCServerConnect.Enabled = False
                AvailableOPCServerList.Enabled = False
                OPCServerName.Enabled = False

                OPCGroupName.Enabled = True
                GroupUpdateRate.Enabled = True
                GroupDeadBand.Enabled = True
                GroupActiveState.Enabled = True
                AddOPCGroup.Enabled = True              ' Remove group isn't enable until a group has been added

            Catch ex As Exception
                DisconnectFromServer.Enabled = False
                ConnectedOPCServer = Nothing
                MessageBox.Show("OPC server connect failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try

        Else
            MessageBox.Show("You must first select an OPC Server, Click on the 'List OPC Servers' button and select a server", "OPC Server Connect", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub DisconnectFromServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectFromServer.Click
        If Not ConnectedOPCServer Is Nothing Then
            Try
                ConnectedOPCServer.Disconnect()
            Catch ex As Exception
                MessageBox.Show("OPC server disconnect failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            Finally
                ConnectedOPCServer = Nothing
                OPCServerConnect.Enabled = True
                AvailableOPCServerList.Enabled = True
                OPCServerName.Enabled = True
                DisconnectFromServer.Enabled = False
                OPCGroupName.Enabled = False
                GroupUpdateRate.Enabled = False
                GroupDeadBand.Enabled = False
                GroupActiveState.Enabled = False
                AddOPCGroup.Enabled = False
            End Try
        End If
    End Sub

    Private Sub AddOPCGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOPCGroup.Click
        Try
            ConnectedOPCServer.OPCGroups.DefaultGroupIsActive = CBool(GroupActiveState.CheckState)
            ConnectedOPCServer.OPCGroups.DefaultGroupDeadband = CSng(GroupDeadBand.Text)
            ConnectedGroup = ConnectedOPCServer.OPCGroups.Add(OPCGroupName.Text)
            ConnectedGroup.UpdateRate = CInt(Val(GroupUpdateRate.Text))
            ConnectedGroup.IsSubscribed = True

            OPCGroupName.Enabled = False
            AddOPCGroup.Enabled = False
            RemoveOPCGroup.Enabled = True

            OPCAddItems.Enabled = True
            For i As Short = 1 To NUMITEMS
                OPCItemName(i).Enabled = True
            Next
            DisconnectFromServer.Enabled = False

        Catch ex As Exception
            MessageBox.Show("OPC server add group failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub RemoveOPCGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOPCGroup.Click
        If Not ConnectedGroup Is Nothing Then
            Try
                ConnectedOPCServer.OPCGroups.Remove(OPCGroupName.Text)
            Catch ex As Exception
                MessageBox.Show("OPC server remove group failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            Finally
                ConnectedGroup = Nothing
                OPCGroupName.Enabled = True
                AddOPCGroup.Enabled = True
                RemoveOPCGroup.Enabled = False

                OPCAddItems.Enabled = False
                OPCRemoveItems.Enabled = False

                For i As Short = 1 To NUMITEMS
                    OPCItemName(i).Enabled = False
                Next
                DisconnectFromServer.Enabled = True
            End Try
        End If
    End Sub

    Private Sub OPCAddItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCAddItems.Click
        If Not ConnectedGroup Is Nothing Then
            Try
                Dim ItemCount As Integer = NUMITEMS
                Dim AddItemServerErrors As System.Array

                For i As Short = 1 To NUMITEMS
                    OPCItemIDs(i) = OPCItemName(i).Text
                    'OPCItemIsArray(i) = 0
                    ClientHandles(i) = i
                    'OPCItemActiveState(i).CheckState = System.Windows.Forms.CheckState.Checked
                Next i
                AddItemServerErrors = {Single.MaxValue}
                ConnectedGroup.OPCItems.DefaultIsActive = True
                ConnectedGroup.OPCItems.AddItems(ItemCount, OPCItemIDs, ClientHandles, ItemServerHandles, AddItemServerErrors)

                Dim AnItemIsGood As Boolean
                AnItemIsGood = False
                For i As Short = 1 To NUMITEMS
                    If AddItemServerErrors(i) = 0 Then                    'If the item was added successfully then allow it to be used.
                        'OPCItemValueToWrite(i).Enabled = True
                        'OPCItemWriteButton(i).Enabled = True
                        'OPCItemActiveState(i).Enabled = True
                        'OPCItemSyncReadButton(i).Enabled = True

                        AnItemIsGood = True
                        OPCItemValue(i).Enabled = True
                    Else
                        ItemServerHandles(i) = 0                         ' If the handle was bad mark it as empty
                        'OPCItemValueToWrite(i).Enabled = False
                        'OPCItemWriteButton(i).Enabled = False
                        'OPCItemActiveState(i).Enabled = False
                        'OPCItemSyncReadButton(i).Enabled = False

                        OPCItemValue(i).Enabled = False
                        OPCItemValue(i).Text = "OPC Add Item Fail"
                    End If
                Next i

                If AnItemIsGood Then
                    OPCAddItems.Enabled = False

                    For i As Short = 1 To NUMITEMS
                        OPCItemName(i).Enabled = False                        ' Disable the Item Name cotnrols while now that they have been added to the group.
                    Next i
                    RemoveOPCGroup.Enabled = False                   ' If an item has been added don't allow the group to be removed until the item is removed
                    OPCRemoveItems.Enabled = True
                Else
                    MessageBox.Show("The OPC Server has not accepted any of the item you have entered, check your item names and try again.", "OPC Add Item", MessageBoxButtons.OK)
                End If

            Catch ex As Exception
                MessageBox.Show("OPC server add items failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub OPCRemoveItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCRemoveItems.Click
        If Not ConnectedGroup Is Nothing Then
            If ConnectedGroup.OPCItems.Count <> 0 Then
                Try
                    Dim RemoveItemServerHandles(NUMITEMS) As Int32
                    Dim RemoveItemServerErrors As System.Array
                    Dim ItemCount As Short = 0

                    For i As Short = 1 To NUMITEMS
                        ' In this example if the ItemServerHandle is non zero it is valid
                        If ItemServerHandles(i) <> 0 Then
                            ItemCount = CShort(ItemCount + 1)
                            RemoveItemServerHandles(ItemCount) = ItemServerHandles(i)
                        End If
                    Next i
                    RemoveItemServerErrors = {Single.MaxValue}
                    ConnectedGroup.OPCItems.Remove(ItemCount, RemoveItemServerHandles, RemoveItemServerErrors)

                    For i As Short = 1 To ItemCount
                        If RemoveItemServerErrors(i) <> 0 Then
                            MessageBox.Show("OPC server remove item failed with error: " + RemoveItemServerErrors(i), "OPC remove item", MessageBoxButtons.OK)
                        End If
                    Next i

                Catch ex As Exception
                    MessageBox.Show("OPC server remove items failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
                Finally
                    For i As Short = 1 To NUMITEMS
                        ItemServerHandles(i) = 0                         'Mark the handle as empty
                        'OPCItemValueToWrite(i).Enabled = False
                        'OPCItemWriteButton(i).Enabled = False
                        'OPCItemActiveState(i).Enabled = False
                        'OPCItemSyncReadButton(i).Enabled = False
                    Next i

                    OPCAddItems.Enabled = True
                    RemoveOPCGroup.Enabled = True
                    OPCRemoveItems.Enabled = False
                    For i As Short = 1 To NUMITEMS
                        OPCItemName(i).Enabled = True
                        'OPCItemIsArray(i) = 0
                    Next i
                End Try
            End If
        End If
    End Sub

    Private Sub ConnectedGroup_DataChange(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array) Handles ConnectedGroup.DataChange
        Try
            Dim i As Short
            For i = 1 To CShort(NumItems)
                If IsArray(ItemValues(i)) Then
                    Dim ItsAnArray As Array
                    Dim x As Integer
                    Dim Suffix As String

                    ItsAnArray = ItemValues(i)
                    OPCItemIsArray(ClientHandles(i)) = ItsAnArray.GetUpperBound(0) + 1
                    OPCItemValue(ClientHandles(i)).Text = ""

                    For x = ItsAnArray.GetLowerBound(0) To ItsAnArray.GetUpperBound(0)
                        If x = ItsAnArray.GetUpperBound(0) Then
                            Suffix = ""
                        Else
                            Suffix = ", "
                        End If
                        OPCItemValue(ClientHandles(i)).Text = OPCItemValue(ClientHandles(i)).Text & ItsAnArray(x) & Suffix
                    Next x
                Else
                    OPCItemValue(ClientHandles(i)).Text = ItemValues(i)
                    sOPCValue1 = OPCItemValue(1).Text()
                    sOPCValue2 = OPCItemValue(2).Text()
                    sOPCValue3 = OPCItemValue(3).Text()
                    sOPCValue4 = OPCItemValue(4).Text()
                End If

                If (Qualities(i) And OPCAutomation.OPCQuality.OPCQualityGood) = OPCAutomation.OPCQuality.OPCQualityGood Then
                    'OPCItemQuality(ClientHandles(i)).Text = "Good"
                ElseIf (Qualities(i) And OPCAutomation.OPCQuality.OPCQualityUncertain) = OPCAutomation.OPCQuality.OPCQualityUncertain Then
                    'OPCItemQuality(ClientHandles(i)).Text = "Uncertain"
                Else
                    'OPCItemQuality(ClientHandles(i)).Text = "Bad"
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show("OPC DataChange failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtOPC_Address_Tag1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOPC_Address_Tag1.Validating, txtOPC_Address_Tag2.Validating, txtOPC_Address_Tag3.Validating, txtOPC_Address_Tag4.Validating
        Try
            Dim actText As TextBox = CType(sender, TextBox)
            'If String.IsNullOrEmpty(actText.Text) Then Return
            bValidating = True

            If actText.Name = "txtOPC_Address_Tag1" Then
                My.Settings.frmOPC_Address_Tag1 = txtOPC_Address_Tag1.Text
            ElseIf actText.Name = "txtOPC_Address_Tag2" Then
                My.Settings.frmOPC_Address_Tag2 = txtOPC_Address_Tag2.Text
            ElseIf actText.Name = "txtOPC_Address_Tag3" Then
                My.Settings.frmOPC_Address_Tag3 = txtOPC_Address_Tag3.Text
            ElseIf actText.Name = "txtOPC_Address_Tag4" Then
                My.Settings.frmOPC_Address_Tag4 = txtOPC_Address_Tag4.Text
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

    Private Sub GroupActiveState_CheckedChanged(sender As Object, e As EventArgs) Handles GroupActiveState.CheckedChanged
        If GroupActiveState.CheckState = CheckState.Checked Then
            My.Settings.frmOPC_GroupActiveState = True
        ElseIf GroupActiveState.CheckState = CheckState.Unchecked Then
            My.Settings.frmOPC_GroupActiveState = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub GroupDeadBand_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupDeadBand.Validating
        My.Settings.frmOPC_GroupDeadBand = GroupDeadBand.Text
        My.Settings.Save()
    End Sub

    Private Sub OPCGroupName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OPCGroupName.Validating
        My.Settings.frmOPC_OPCGroupName = OPCGroupName.Text
        My.Settings.Save()
    End Sub

    Private Sub GroupUpdateRate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupUpdateRate.Validating
        My.Settings.frmOPC_GroupUpdateRate = GroupUpdateRate.Text
        My.Settings.Save()
    End Sub

End Class