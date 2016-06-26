Public Class MinecraftLauncher

    Private Sub logout_Click(sender As System.Object, e As System.EventArgs) Handles logout.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub ProfileNew_Click(sender As System.Object, e As System.EventArgs) Handles ProfileNew.Click
        profilenew0.Show()
        Me.Hide()
    End Sub
End Class
