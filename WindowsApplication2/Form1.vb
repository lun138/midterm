Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w, c As Integer
        Dim bmi As Single

        c = Val(textBox1.Text)
        w = Val(textBox2.Text)

        bmi = w / (c / 100) ^ 2

        If (bmi < 18.5) Then
            Label5.Text = "體重過輕"
        End If

        If (bmi < 24) And (bmi >= 18.5) Then
            Label5.Text = "正常哦！"
        End If

        If (bmi < 27) And (bmi >= 24) Then
            Label5.Text = "過重了！"
        End If

        If (bmi < 30) And (bmi >= 27) Then
            Label5.Text = "輕度肥胖"
        End If

        If (bmi < 35) And (bmi >= 30) Then
            Label5.Text = "中度肥胖"
        End If

        If (bmi >= 35) Then
            Label5.Text = "重度肥胖"
        End If

        If textBox1.Text = "" Then
            ToolTip1.IsBalloon = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Info
            ToolTip1.ToolTipTitle = "您沒有輸入身高"
        Else
            ToolTip1.RemoveAll()
        End If

        If textBox2.Text = "" Then
            ToolTip2.IsBalloon = True
            ToolTip2.ToolTipIcon = ToolTipIcon.Info
            ToolTip2.ToolTipTitle = "您沒有輸入體重"
        Else
            ToolTip2.RemoveAll()
        End If

    End Sub



End Class
