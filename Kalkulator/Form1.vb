Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah, persen, hasil, hasil2 As Integer

        jumlah = TextBox1.Text
        persen = TextBox2.Text
        hasil = jumlah * persen / 100
        hasil2 = jumlah - hasil

        TextBox3.Text = hasil
        TextBox4.Text = hasil2


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlah, jumlahdari, hasil As Integer

        jumlah = TextBox5.Text
        jumlahdari = TextBox6.Text
        hasil = jumlah / jumlahdari * 100

        TextBox7.Text = hasil
    End Sub
End Class
