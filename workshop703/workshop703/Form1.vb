Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim word As String = TextBox1.Text.ToLower
        Dim word2 As String = TextBox1.Text
        Dim listVowel() As String = {"a", "e", "i", "o", "u"}
        Dim vowel As String = ""
        Dim alphabet As String = ""

        If word2.Length = 0 Then
            MessageBox.Show("กรุณากรอกข้อมูล")
        End If

        For i = 0 To (word.Length - 1)
            Dim check As Boolean = True
            For Each item In listVowel
                If word(i) = item Then
                    vowel &= $"{word2(i)} "
                    check = False
                    Exit For
                End If
            Next
            If check = True Then
                alphabet &= $"{word2(i)} "
            End If
        Next
        TextBox2.Text = vowel
        TextBox3.Text = alphabet
    End Sub
End Class