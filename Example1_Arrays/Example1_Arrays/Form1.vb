Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As Random = New Random
        Dim numList As String = ""
        Dim number(9) As Integer

        'For x = 0 to number.legth - 1'
        'For x = 0 to number.GetUpperBound(0)'

        For x = 0 To UBound(number)
            number(x) = rand.Next(0, 2)
            numList &= $"{number(x)}"
            'numlist &= number(x)&""
            'numList &= $"The number in index {x} is {number(x)}"
            'The number is index 0 is 1

        Next
        TextBox1.Text = numList
        Dim zero As Integer = 0
        Dim one As Integer = 0

        For Each num In number  'For i = 0 to UBound(number)
            If num = 0 Then     '    If number(i) = 0 Then
                zero = zero + 1 '       zero = zero + 1
            Else                '    Else
                one = one + 1   '    one = one + 1
            End If              'End If
        Next
        TextBox2.Text = zero
        TextBox3.Text = one

    End Sub
End Class
