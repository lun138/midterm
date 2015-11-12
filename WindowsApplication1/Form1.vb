Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        TextBox1.Text = Val((TextBox1.Text) - 32) / 1.8
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Val(TextBox1.Text) * 1.8 + 32
    End Sub
End Class
