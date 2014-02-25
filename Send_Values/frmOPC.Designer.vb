<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OPCGroupFrame = New System.Windows.Forms.GroupBox()
        Me.RemoveOPCGroup = New System.Windows.Forms.Button()
        Me.AddOPCGroup = New System.Windows.Forms.Button()
        Me.GroupActiveState = New System.Windows.Forms.CheckBox()
        Me.GroupDeadBand = New System.Windows.Forms.TextBox()
        Me.GroupUpdateRate = New System.Windows.Forms.TextBox()
        Me.OPCGroupName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.AvailableOPCServerList = New System.Windows.Forms.ListBox()
        Me.OPCServerConnect = New System.Windows.Forms.Button()
        Me.OPCNodeName = New System.Windows.Forms.TextBox()
        Me.DisconnectFromServer = New System.Windows.Forms.Button()
        Me.lblOPCNodeName = New System.Windows.Forms.Label()
        Me.OPCServerName = New System.Windows.Forms.TextBox()
        Me.grbTagNames = New System.Windows.Forms.GroupBox()
        Me.OPCItemValue4 = New System.Windows.Forms.TextBox()
        Me.OPCRemoveItems = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OPCItemValue3 = New System.Windows.Forms.TextBox()
        Me.OPCAddItems = New System.Windows.Forms.Button()
        Me.OPCItemValue1 = New System.Windows.Forms.TextBox()
        Me.txtOPC_Address_Tag4 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue2 = New System.Windows.Forms.TextBox()
        Me.lblTag4 = New System.Windows.Forms.Label()
        Me.txtOPC_Address_Tag3 = New System.Windows.Forms.TextBox()
        Me.lblTag3 = New System.Windows.Forms.Label()
        Me.txtOPC_Address_Tag2 = New System.Windows.Forms.TextBox()
        Me.lblTag2 = New System.Windows.Forms.Label()
        Me.txtOPC_Address_Tag1 = New System.Windows.Forms.TextBox()
        Me.lblTag1 = New System.Windows.Forms.Label()
        Me.OPCGroupFrame.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.grbTagNames.SuspendLayout()
        Me.SuspendLayout()
        '
        'OPCGroupFrame
        '
        Me.OPCGroupFrame.BackColor = System.Drawing.SystemColors.Control
        Me.OPCGroupFrame.Controls.Add(Me.RemoveOPCGroup)
        Me.OPCGroupFrame.Controls.Add(Me.AddOPCGroup)
        Me.OPCGroupFrame.Controls.Add(Me.GroupActiveState)
        Me.OPCGroupFrame.Controls.Add(Me.GroupDeadBand)
        Me.OPCGroupFrame.Controls.Add(Me.GroupUpdateRate)
        Me.OPCGroupFrame.Controls.Add(Me.OPCGroupName)
        Me.OPCGroupFrame.Controls.Add(Me.Label6)
        Me.OPCGroupFrame.Controls.Add(Me.Label5)
        Me.OPCGroupFrame.Controls.Add(Me.Label1)
        Me.OPCGroupFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCGroupFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCGroupFrame.Location = New System.Drawing.Point(306, 12)
        Me.OPCGroupFrame.Name = "OPCGroupFrame"
        Me.OPCGroupFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCGroupFrame.Size = New System.Drawing.Size(242, 236)
        Me.OPCGroupFrame.TabIndex = 104
        Me.OPCGroupFrame.TabStop = False
        Me.OPCGroupFrame.Text = "Add Group to OPC Server"
        '
        'RemoveOPCGroup
        '
        Me.RemoveOPCGroup.BackColor = System.Drawing.SystemColors.Control
        Me.RemoveOPCGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.RemoveOPCGroup.Enabled = False
        Me.RemoveOPCGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveOPCGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RemoveOPCGroup.Location = New System.Drawing.Point(102, 174)
        Me.RemoveOPCGroup.Name = "RemoveOPCGroup"
        Me.RemoveOPCGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RemoveOPCGroup.Size = New System.Drawing.Size(129, 24)
        Me.RemoveOPCGroup.TabIndex = 16
        Me.RemoveOPCGroup.Text = "Remove Group"
        Me.RemoveOPCGroup.UseVisualStyleBackColor = False
        '
        'AddOPCGroup
        '
        Me.AddOPCGroup.BackColor = System.Drawing.SystemColors.Control
        Me.AddOPCGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddOPCGroup.Enabled = False
        Me.AddOPCGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddOPCGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddOPCGroup.Location = New System.Drawing.Point(102, 146)
        Me.AddOPCGroup.Name = "AddOPCGroup"
        Me.AddOPCGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AddOPCGroup.Size = New System.Drawing.Size(129, 24)
        Me.AddOPCGroup.TabIndex = 15
        Me.AddOPCGroup.Text = "Add Group"
        Me.AddOPCGroup.UseVisualStyleBackColor = False
        '
        'GroupActiveState
        '
        Me.GroupActiveState.BackColor = System.Drawing.SystemColors.Control
        Me.GroupActiveState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GroupActiveState.Checked = True
        Me.GroupActiveState.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GroupActiveState.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupActiveState.Enabled = False
        Me.GroupActiveState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupActiveState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupActiveState.Location = New System.Drawing.Point(30, 120)
        Me.GroupActiveState.Name = "GroupActiveState"
        Me.GroupActiveState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupActiveState.Size = New System.Drawing.Size(89, 17)
        Me.GroupActiveState.TabIndex = 14
        Me.GroupActiveState.Text = "Group Active"
        Me.GroupActiveState.UseVisualStyleBackColor = False
        '
        'GroupDeadBand
        '
        Me.GroupDeadBand.AcceptsReturn = True
        Me.GroupDeadBand.BackColor = System.Drawing.SystemColors.Window
        Me.GroupDeadBand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupDeadBand.Enabled = False
        Me.GroupDeadBand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDeadBand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupDeadBand.Location = New System.Drawing.Point(102, 88)
        Me.GroupDeadBand.MaxLength = 0
        Me.GroupDeadBand.Name = "GroupDeadBand"
        Me.GroupDeadBand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupDeadBand.Size = New System.Drawing.Size(129, 20)
        Me.GroupDeadBand.TabIndex = 13
        Me.GroupDeadBand.Text = "0"
        '
        'GroupUpdateRate
        '
        Me.GroupUpdateRate.AcceptsReturn = True
        Me.GroupUpdateRate.BackColor = System.Drawing.SystemColors.Window
        Me.GroupUpdateRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupUpdateRate.Enabled = False
        Me.GroupUpdateRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupUpdateRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupUpdateRate.Location = New System.Drawing.Point(102, 56)
        Me.GroupUpdateRate.MaxLength = 0
        Me.GroupUpdateRate.Name = "GroupUpdateRate"
        Me.GroupUpdateRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupUpdateRate.Size = New System.Drawing.Size(129, 20)
        Me.GroupUpdateRate.TabIndex = 11
        Me.GroupUpdateRate.Text = "500"
        '
        'OPCGroupName
        '
        Me.OPCGroupName.AcceptsReturn = True
        Me.OPCGroupName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCGroupName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCGroupName.Enabled = False
        Me.OPCGroupName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCGroupName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCGroupName.Location = New System.Drawing.Point(102, 24)
        Me.OPCGroupName.MaxLength = 0
        Me.OPCGroupName.Name = "OPCGroupName"
        Me.OPCGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCGroupName.Size = New System.Drawing.Size(129, 20)
        Me.OPCGroupName.TabIndex = 9
        Me.OPCGroupName.Text = "Group1"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(22, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Deadband  (%)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Update Rate (ms.)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Group Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.AvailableOPCServerList)
        Me.Frame1.Controls.Add(Me.OPCServerConnect)
        Me.Frame1.Controls.Add(Me.OPCNodeName)
        Me.Frame1.Controls.Add(Me.DisconnectFromServer)
        Me.Frame1.Controls.Add(Me.lblOPCNodeName)
        Me.Frame1.Controls.Add(Me.OPCServerName)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(288, 236)
        Me.Frame1.TabIndex = 103
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "List Available OPC Servers"
        '
        'AvailableOPCServerList
        '
        Me.AvailableOPCServerList.BackColor = System.Drawing.SystemColors.Window
        Me.AvailableOPCServerList.Cursor = System.Windows.Forms.Cursors.Default
        Me.AvailableOPCServerList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableOPCServerList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AvailableOPCServerList.ItemHeight = 14
        Me.AvailableOPCServerList.Location = New System.Drawing.Point(4, 24)
        Me.AvailableOPCServerList.Name = "AvailableOPCServerList"
        Me.AvailableOPCServerList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvailableOPCServerList.Size = New System.Drawing.Size(272, 116)
        Me.AvailableOPCServerList.Sorted = True
        Me.AvailableOPCServerList.TabIndex = 100
        '
        'OPCServerConnect
        '
        Me.OPCServerConnect.BackColor = System.Drawing.SystemColors.Control
        Me.OPCServerConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCServerConnect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCServerConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCServerConnect.Location = New System.Drawing.Point(195, 146)
        Me.OPCServerConnect.Name = "OPCServerConnect"
        Me.OPCServerConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCServerConnect.Size = New System.Drawing.Size(81, 24)
        Me.OPCServerConnect.TabIndex = 98
        Me.OPCServerConnect.Text = "Connect"
        Me.OPCServerConnect.UseVisualStyleBackColor = False
        '
        'OPCNodeName
        '
        Me.OPCNodeName.AcceptsReturn = True
        Me.OPCNodeName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCNodeName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCNodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCNodeName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCNodeName.Location = New System.Drawing.Point(6, 204)
        Me.OPCNodeName.MaxLength = 0
        Me.OPCNodeName.Name = "OPCNodeName"
        Me.OPCNodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCNodeName.Size = New System.Drawing.Size(183, 20)
        Me.OPCNodeName.TabIndex = 94
        '
        'DisconnectFromServer
        '
        Me.DisconnectFromServer.BackColor = System.Drawing.SystemColors.Control
        Me.DisconnectFromServer.Cursor = System.Windows.Forms.Cursors.Default
        Me.DisconnectFromServer.Enabled = False
        Me.DisconnectFromServer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisconnectFromServer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisconnectFromServer.Location = New System.Drawing.Point(195, 174)
        Me.DisconnectFromServer.Name = "DisconnectFromServer"
        Me.DisconnectFromServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DisconnectFromServer.Size = New System.Drawing.Size(81, 24)
        Me.DisconnectFromServer.TabIndex = 6
        Me.DisconnectFromServer.Text = "Disconnect"
        Me.DisconnectFromServer.UseVisualStyleBackColor = False
        '
        'lblOPCNodeName
        '
        Me.lblOPCNodeName.BackColor = System.Drawing.SystemColors.Control
        Me.lblOPCNodeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOPCNodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPCNodeName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOPCNodeName.Location = New System.Drawing.Point(195, 207)
        Me.lblOPCNodeName.Name = "lblOPCNodeName"
        Me.lblOPCNodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOPCNodeName.Size = New System.Drawing.Size(87, 17)
        Me.lblOPCNodeName.TabIndex = 95
        Me.lblOPCNodeName.Text = "Computer Name"
        '
        'OPCServerName
        '
        Me.OPCServerName.AcceptsReturn = True
        Me.OPCServerName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCServerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCServerName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCServerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCServerName.Location = New System.Drawing.Point(6, 146)
        Me.OPCServerName.MaxLength = 0
        Me.OPCServerName.Multiline = True
        Me.OPCServerName.Name = "OPCServerName"
        Me.OPCServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCServerName.Size = New System.Drawing.Size(183, 52)
        Me.OPCServerName.TabIndex = 97
        Me.OPCServerName.Text = "Click on list above to select"
        '
        'grbTagNames
        '
        Me.grbTagNames.Controls.Add(Me.OPCItemValue4)
        Me.grbTagNames.Controls.Add(Me.OPCRemoveItems)
        Me.grbTagNames.Controls.Add(Me.Label7)
        Me.grbTagNames.Controls.Add(Me.OPCItemValue3)
        Me.grbTagNames.Controls.Add(Me.OPCAddItems)
        Me.grbTagNames.Controls.Add(Me.OPCItemValue1)
        Me.grbTagNames.Controls.Add(Me.txtOPC_Address_Tag4)
        Me.grbTagNames.Controls.Add(Me.OPCItemValue2)
        Me.grbTagNames.Controls.Add(Me.lblTag4)
        Me.grbTagNames.Controls.Add(Me.txtOPC_Address_Tag3)
        Me.grbTagNames.Controls.Add(Me.lblTag3)
        Me.grbTagNames.Controls.Add(Me.txtOPC_Address_Tag2)
        Me.grbTagNames.Controls.Add(Me.lblTag2)
        Me.grbTagNames.Controls.Add(Me.txtOPC_Address_Tag1)
        Me.grbTagNames.Controls.Add(Me.lblTag1)
        Me.grbTagNames.Location = New System.Drawing.Point(12, 254)
        Me.grbTagNames.Name = "grbTagNames"
        Me.grbTagNames.Size = New System.Drawing.Size(536, 148)
        Me.grbTagNames.TabIndex = 102
        Me.grbTagNames.TabStop = False
        Me.grbTagNames.Text = "Tag addresses"
        '
        'OPCItemValue4
        '
        Me.OPCItemValue4.AcceptsReturn = True
        Me.OPCItemValue4.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue4.Location = New System.Drawing.Point(285, 114)
        Me.OPCItemValue4.MaxLength = 0
        Me.OPCItemValue4.Name = "OPCItemValue4"
        Me.OPCItemValue4.ReadOnly = True
        Me.OPCItemValue4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue4.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue4.TabIndex = 119
        '
        'OPCRemoveItems
        '
        Me.OPCRemoveItems.BackColor = System.Drawing.SystemColors.Control
        Me.OPCRemoveItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCRemoveItems.Enabled = False
        Me.OPCRemoveItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCRemoveItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCRemoveItems.Location = New System.Drawing.Point(396, 62)
        Me.OPCRemoveItems.Name = "OPCRemoveItems"
        Me.OPCRemoveItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCRemoveItems.Size = New System.Drawing.Size(129, 24)
        Me.OPCRemoveItems.TabIndex = 111
        Me.OPCRemoveItems.Text = "Remove OPC Items"
        Me.OPCRemoveItems.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(286, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Current Value"
        '
        'OPCItemValue3
        '
        Me.OPCItemValue3.AcceptsReturn = True
        Me.OPCItemValue3.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue3.Location = New System.Drawing.Point(285, 88)
        Me.OPCItemValue3.MaxLength = 0
        Me.OPCItemValue3.Name = "OPCItemValue3"
        Me.OPCItemValue3.ReadOnly = True
        Me.OPCItemValue3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue3.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue3.TabIndex = 118
        '
        'OPCAddItems
        '
        Me.OPCAddItems.BackColor = System.Drawing.SystemColors.Control
        Me.OPCAddItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCAddItems.Enabled = False
        Me.OPCAddItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCAddItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCAddItems.Location = New System.Drawing.Point(396, 36)
        Me.OPCAddItems.Name = "OPCAddItems"
        Me.OPCAddItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCAddItems.Size = New System.Drawing.Size(129, 24)
        Me.OPCAddItems.TabIndex = 112
        Me.OPCAddItems.Text = "Add OPC Items"
        Me.OPCAddItems.UseVisualStyleBackColor = False
        '
        'OPCItemValue1
        '
        Me.OPCItemValue1.AcceptsReturn = True
        Me.OPCItemValue1.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue1.Location = New System.Drawing.Point(285, 36)
        Me.OPCItemValue1.MaxLength = 0
        Me.OPCItemValue1.Name = "OPCItemValue1"
        Me.OPCItemValue1.ReadOnly = True
        Me.OPCItemValue1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue1.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue1.TabIndex = 115
        '
        'txtOPC_Address_Tag4
        '
        Me.txtOPC_Address_Tag4.Location = New System.Drawing.Point(54, 114)
        Me.txtOPC_Address_Tag4.MaxLength = 200
        Me.txtOPC_Address_Tag4.Name = "txtOPC_Address_Tag4"
        Me.txtOPC_Address_Tag4.Size = New System.Drawing.Size(222, 20)
        Me.txtOPC_Address_Tag4.TabIndex = 9
        Me.txtOPC_Address_Tag4.Text = "Channel1.Device1.Tag4"
        '
        'OPCItemValue2
        '
        Me.OPCItemValue2.AcceptsReturn = True
        Me.OPCItemValue2.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue2.Location = New System.Drawing.Point(285, 62)
        Me.OPCItemValue2.MaxLength = 0
        Me.OPCItemValue2.Name = "OPCItemValue2"
        Me.OPCItemValue2.ReadOnly = True
        Me.OPCItemValue2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue2.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue2.TabIndex = 117
        '
        'lblTag4
        '
        Me.lblTag4.AutoSize = True
        Me.lblTag4.Location = New System.Drawing.Point(13, 117)
        Me.lblTag4.Name = "lblTag4"
        Me.lblTag4.Size = New System.Drawing.Size(38, 13)
        Me.lblTag4.TabIndex = 8
        Me.lblTag4.Text = "Tag 4:"
        '
        'txtOPC_Address_Tag3
        '
        Me.txtOPC_Address_Tag3.Location = New System.Drawing.Point(54, 88)
        Me.txtOPC_Address_Tag3.MaxLength = 200
        Me.txtOPC_Address_Tag3.Name = "txtOPC_Address_Tag3"
        Me.txtOPC_Address_Tag3.Size = New System.Drawing.Size(222, 20)
        Me.txtOPC_Address_Tag3.TabIndex = 7
        Me.txtOPC_Address_Tag3.Text = "Channel1.Device1.Tag3"
        '
        'lblTag3
        '
        Me.lblTag3.AutoSize = True
        Me.lblTag3.Location = New System.Drawing.Point(13, 91)
        Me.lblTag3.Name = "lblTag3"
        Me.lblTag3.Size = New System.Drawing.Size(38, 13)
        Me.lblTag3.TabIndex = 6
        Me.lblTag3.Text = "Tag 3:"
        '
        'txtOPC_Address_Tag2
        '
        Me.txtOPC_Address_Tag2.Location = New System.Drawing.Point(54, 62)
        Me.txtOPC_Address_Tag2.MaxLength = 200
        Me.txtOPC_Address_Tag2.Name = "txtOPC_Address_Tag2"
        Me.txtOPC_Address_Tag2.Size = New System.Drawing.Size(222, 20)
        Me.txtOPC_Address_Tag2.TabIndex = 5
        Me.txtOPC_Address_Tag2.Text = "Channel1.Device1.Tag2"
        '
        'lblTag2
        '
        Me.lblTag2.AutoSize = True
        Me.lblTag2.Location = New System.Drawing.Point(13, 65)
        Me.lblTag2.Name = "lblTag2"
        Me.lblTag2.Size = New System.Drawing.Size(38, 13)
        Me.lblTag2.TabIndex = 4
        Me.lblTag2.Text = "Tag 2:"
        '
        'txtOPC_Address_Tag1
        '
        Me.txtOPC_Address_Tag1.Location = New System.Drawing.Point(54, 36)
        Me.txtOPC_Address_Tag1.MaxLength = 200
        Me.txtOPC_Address_Tag1.Name = "txtOPC_Address_Tag1"
        Me.txtOPC_Address_Tag1.Size = New System.Drawing.Size(222, 20)
        Me.txtOPC_Address_Tag1.TabIndex = 3
        Me.txtOPC_Address_Tag1.Text = "Channel1.Device1.Tag1"
        '
        'lblTag1
        '
        Me.lblTag1.AutoSize = True
        Me.lblTag1.Location = New System.Drawing.Point(13, 39)
        Me.lblTag1.Name = "lblTag1"
        Me.lblTag1.Size = New System.Drawing.Size(38, 13)
        Me.lblTag1.TabIndex = 2
        Me.lblTag1.Text = "Tag 1:"
        '
        'frmOPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 418)
        Me.Controls.Add(Me.OPCGroupFrame)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.grbTagNames)
        Me.Name = "frmOPC"
        Me.Text = "frmOPC"
        Me.OPCGroupFrame.ResumeLayout(False)
        Me.OPCGroupFrame.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.grbTagNames.ResumeLayout(False)
        Me.grbTagNames.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents OPCGroupFrame As System.Windows.Forms.GroupBox
    Public WithEvents RemoveOPCGroup As System.Windows.Forms.Button
    Public WithEvents AddOPCGroup As System.Windows.Forms.Button
    Public WithEvents GroupActiveState As System.Windows.Forms.CheckBox
    Public WithEvents GroupDeadBand As System.Windows.Forms.TextBox
    Public WithEvents GroupUpdateRate As System.Windows.Forms.TextBox
    Public WithEvents OPCGroupName As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents AvailableOPCServerList As System.Windows.Forms.ListBox
    Public WithEvents OPCServerConnect As System.Windows.Forms.Button
    Public WithEvents OPCNodeName As System.Windows.Forms.TextBox
    Public WithEvents DisconnectFromServer As System.Windows.Forms.Button
    Public WithEvents lblOPCNodeName As System.Windows.Forms.Label
    Public WithEvents OPCServerName As System.Windows.Forms.TextBox
    Friend WithEvents grbTagNames As System.Windows.Forms.GroupBox
    Public WithEvents OPCItemValue4 As System.Windows.Forms.TextBox
    Public WithEvents OPCRemoveItems As System.Windows.Forms.Button
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents OPCItemValue3 As System.Windows.Forms.TextBox
    Public WithEvents OPCAddItems As System.Windows.Forms.Button
    Public WithEvents OPCItemValue1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOPC_Address_Tag4 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTag4 As System.Windows.Forms.Label
    Friend WithEvents txtOPC_Address_Tag3 As System.Windows.Forms.TextBox
    Friend WithEvents lblTag3 As System.Windows.Forms.Label
    Friend WithEvents txtOPC_Address_Tag2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTag2 As System.Windows.Forms.Label
    Friend WithEvents txtOPC_Address_Tag1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTag1 As System.Windows.Forms.Label
End Class
