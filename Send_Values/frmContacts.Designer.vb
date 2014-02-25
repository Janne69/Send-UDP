<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContacts
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
        Me.butTest1 = New System.Windows.Forms.Button()
        Me.butTest2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butTest1
        '
        Me.butTest1.Location = New System.Drawing.Point(36, 149)
        Me.butTest1.Name = "butTest1"
        Me.butTest1.Size = New System.Drawing.Size(69, 38)
        Me.butTest1.TabIndex = 0
        Me.butTest1.Text = "butTest"
        Me.butTest1.UseVisualStyleBackColor = True
        '
        'butTest2
        '
        Me.butTest2.Location = New System.Drawing.Point(137, 149)
        Me.butTest2.Name = "butTest2"
        Me.butTest2.Size = New System.Drawing.Size(69, 38)
        Me.butTest2.TabIndex = 0
        Me.butTest2.Text = "Close"
        Me.butTest2.UseVisualStyleBackColor = True
        '
        'frmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.butTest2)
        Me.Controls.Add(Me.butTest1)
        Me.Name = "frmContacts"
        Me.Text = "frmContacts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butTest1 As System.Windows.Forms.Button
    Friend WithEvents butTest2 As System.Windows.Forms.Button
End Class
