Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.close_icon_r
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.close_icon_b
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = False Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nickname, Image As String
        nickname = TextBox1.Text
        Image = "http://signaturecraft.us/avatars/5/face/" + nickname + ".png"
        If TextBox2.Text = "" And TextBox1.Text = "" Then
            MsgBox("Ingrese un nickname")
        Else
            Form2.iconprofile.ImageLocation = Image
            Form2.Show()
            Me.Hide()
            Form2.Label1.Text = nickname
        End If
    End Sub
End Class
