Public Class frmContacts


#Region " Global Variable Declaration "
    Private bFormLoaded As Boolean
#End Region

#Region " Load/End "
    Private Sub frmContacts_Load(sender As Object, e As EventArgs) Handles Me.Load

        bFormLoaded = True
    End Sub
#End Region

#Region " Form Action "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butTest1.Click, butTest2.Click
        Me.Close()
    End Sub
#End Region

End Class