Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim word As String = TextBox1.Text.ToLower
        Dim listVowel() As String = {"a", "e", "i", "o", "u"}
        Dim vowel As String = ""
        Dim count As Integer = 0
        For Each w In word   'loop of word
            For Each v In listVowel     'loop of listVowel
                If w = v Then
                    vowel &= $"{w}"
                    count = count + 1
                    Exit For
                End If
            Next
        Next
        TextBox2.Text = vowel
        TextBox3.Text = count
    End Sub
End Class
