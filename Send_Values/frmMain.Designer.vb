<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.butOPCForm = New System.Windows.Forms.Button()
        Me.grpLocalRemote = New System.Windows.Forms.GroupBox()
        Me.lbl_Port = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.lbl_IPAddress = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.niTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contexMenuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contexMenuTrayOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.contexMenuTrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.butSendValues = New System.Windows.Forms.Button()
        Me.prbBacground = New System.Windows.Forms.ProgressBar()
        Me.cbAutoSend = New System.Windows.Forms.CheckBox()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ttHelpPopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpLocalRemote.SuspendLayout()
        Me.contexMenuTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'butOPCForm
        '
        Me.butOPCForm.Image = CType(resources.GetObject("butOPCForm.Image"), System.Drawing.Image)
        Me.butOPCForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.butOPCForm.Location = New System.Drawing.Point(12, 80)
        Me.butOPCForm.Name = "butOPCForm"
        Me.butOPCForm.Size = New System.Drawing.Size(77, 25)
        Me.butOPCForm.TabIndex = 2
        Me.butOPCForm.Text = "Open OPC"
        Me.butOPCForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butOPCForm.UseVisualStyleBackColor = True
        '
        'grpLocalRemote
        '
        Me.grpLocalRemote.Controls.Add(Me.lbl_Port)
        Me.grpLocalRemote.Controls.Add(Me.txtIPAddress)
        Me.grpLocalRemote.Controls.Add(Me.lbl_IPAddress)
        Me.grpLocalRemote.Controls.Add(Me.txtPort)
        Me.grpLocalRemote.Location = New System.Drawing.Point(12, 12)
        Me.grpLocalRemote.Name = "grpLocalRemote"
        Me.grpLocalRemote.Size = New System.Drawing.Size(206, 62)
        Me.grpLocalRemote.TabIndex = 39
        Me.grpLocalRemote.TabStop = False
        Me.grpLocalRemote.Text = " Remote Computer "
        '
        'lbl_Port
        '
        Me.lbl_Port.AutoSize = True
        Me.lbl_Port.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Port.Location = New System.Drawing.Point(6, 41)
        Me.lbl_Port.Name = "lbl_Port"
        Me.lbl_Port.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Port.TabIndex = 28
        Me.lbl_Port.Text = "Port:"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(65, 17)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(135, 20)
        Me.txtIPAddress.TabIndex = 0
        Me.ttHelpPopup.SetToolTip(Me.txtIPAddress, "Enter IP-Address of target computer")
        '
        'lbl_IPAddress
        '
        Me.lbl_IPAddress.AutoSize = True
        Me.lbl_IPAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_IPAddress.Location = New System.Drawing.Point(4, 20)
        Me.lbl_IPAddress.Name = "lbl_IPAddress"
        Me.lbl_IPAddress.Size = New System.Drawing.Size(61, 13)
        Me.lbl_IPAddress.TabIndex = 28
        Me.lbl_IPAddress.Text = "IP Address:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(65, 38)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(54, 20)
        Me.txtPort.TabIndex = 0
        Me.ttHelpPopup.SetToolTip(Me.txtPort, "Enter Port of target computer")
        '
        'niTray
        '
        Me.niTray.ContextMenuStrip = Me.contexMenuTray
        Me.niTray.Icon = CType(resources.GetObject("niTray.Icon"), System.Drawing.Icon)
        Me.niTray.Text = "Send machine values"
        Me.niTray.Visible = True
        '
        'contexMenuTray
        '
        Me.contexMenuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contexMenuTrayOpen, Me.contexMenuTrayExit})
        Me.contexMenuTray.Name = "contexMenuTray"
        Me.contexMenuTray.Size = New System.Drawing.Size(104, 48)
        '
        'contexMenuTrayOpen
        '
        Me.contexMenuTrayOpen.Name = "contexMenuTrayOpen"
        Me.contexMenuTrayOpen.Size = New System.Drawing.Size(103, 22)
        Me.contexMenuTrayOpen.Text = "&Open"
        '
        'contexMenuTrayExit
        '
        Me.contexMenuTrayExit.Name = "contexMenuTrayExit"
        Me.contexMenuTrayExit.Size = New System.Drawing.Size(103, 22)
        Me.contexMenuTrayExit.Text = "&Exit"
        '
        'butSendValues
        '
        Me.butSendValues.Location = New System.Drawing.Point(143, 81)
        Me.butSendValues.Name = "butSendValues"
        Me.butSendValues.Size = New System.Drawing.Size(75, 23)
        Me.butSendValues.TabIndex = 40
        Me.butSendValues.Text = "Send Values"
        Me.butSendValues.UseVisualStyleBackColor = True
        '
        'prbBacground
        '
        Me.prbBacground.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prbBacground.Location = New System.Drawing.Point(12, 111)
        Me.prbBacground.MarqueeAnimationSpeed = 1000
        Me.prbBacground.Name = "prbBacground"
        Me.prbBacground.Size = New System.Drawing.Size(206, 13)
        Me.prbBacground.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbBacground.TabIndex = 41
        '
        'cbAutoSend
        '
        Me.cbAutoSend.AutoSize = True
        Me.cbAutoSend.Location = New System.Drawing.Point(122, 86)
        Me.cbAutoSend.Name = "cbAutoSend"
        Me.cbAutoSend.Size = New System.Drawing.Size(15, 14)
        Me.cbAutoSend.TabIndex = 42
        Me.ttHelpPopup.SetToolTip(Me.cbAutoSend, "Auto start sendning values")
        Me.cbAutoSend.UseVisualStyleBackColor = True
        '
        'lblAuto
        '
        Me.lblAuto.Location = New System.Drawing.Point(94, 86)
        Me.lblAuto.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(29, 13)
        Me.lblAuto.TabIndex = 29
        Me.lblAuto.Text = "Auto"
        Me.ttHelpPopup.SetToolTip(Me.lblAuto, "Auto start sendning values")
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 136)
        Me.Controls.Add(Me.cbAutoSend)
        Me.Controls.Add(Me.lblAuto)
        Me.Controls.Add(Me.prbBacground)
        Me.Controls.Add(Me.butSendValues)
        Me.Controls.Add(Me.grpLocalRemote)
        Me.Controls.Add(Me.butOPCForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Values"
        Me.grpLocalRemote.ResumeLayout(False)
        Me.grpLocalRemote.PerformLayout()
        Me.contexMenuTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butOPCForm As System.Windows.Forms.Button
    Friend WithEvents grpLocalRemote As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Port As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbl_IPAddress As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents niTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents contexMenuTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents contexMenuTrayOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contexMenuTrayExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents butSendValues As System.Windows.Forms.Button
    Friend WithEvents prbBacground As System.Windows.Forms.ProgressBar
    Friend WithEvents cbAutoSend As System.Windows.Forms.CheckBox
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents ttHelpPopup As System.Windows.Forms.ToolTip

End Class
