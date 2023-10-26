Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero, id As Integer
        numero = Val(InputBox("Escriba un numero entre 1 y 100"))
        Label1.Text = "Valores enteros pares entre " & numero & " y 100 "
        For id = numero To 100 Step 2
            ListBox1.Items.Add(id)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
