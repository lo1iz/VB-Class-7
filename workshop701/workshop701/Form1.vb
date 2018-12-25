Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zodiac() As String = {"ชวด", "ฉลู", "ขาล", "เถาะ", "มะโรง", "มะเส็ง", "มะเมีย", "มะแม", "วอก", "ระกา", "จอ", "กุน"}
        Dim year As Integer = TextBox1.Text
        Dim cal = (year + 5) Mod 12

        MessageBox.Show($"พ.ศ. {year} ตรงกับปี: {zodiac(cal)}")
        TextBox1.Text = ""
    End Sub
End Class
