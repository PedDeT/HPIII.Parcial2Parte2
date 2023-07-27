Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim C As Double
        Dim I As Double
        Dim N As Double
        Dim cuota As Double
        Dim IM As Double

        If Double.TryParse(TextBox1.Text, C) AndAlso
           Double.TryParse(TextBox2.Text, I) AndAlso
           Double.TryParse(TextBox3.Text, N) Then

            IM = (I / 100) / 12
            cuota = (C * IM) / (1 - (1 / (1 + (IM)) ^ (N * 12)))

            Label6.Text = cuota.ToString("F2")
        Else
            MessageBox.Show("Por favor, ingrese valores validos.")
        End If
    End Sub

End Class
