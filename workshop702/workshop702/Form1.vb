Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text As String = TextBox1.Text
        Dim num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim numthai() As String = {"๐", "๑", "๒", "๓", "๔", "๕", "๖", "๗", "๘", "๙"}
        Dim Label As String = ""

        For Each w In text
            For Each v In num
                If w = v Then
                    Label &= $"{numthai(v)}"

                End If
            Next
        Next
        Label1.Text = Label
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text As String = TextBox1.Text
        Dim num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim textthai() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}
        Dim Label As String = ""

        For Each w In text
            For Each v In num
                If w = v Then
                    Label &= $"{textthai(v)} "

                End If
            Next
        Next
        Label1.Text = Label
    End Sub
End Class
