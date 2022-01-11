Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah, persen, hasil, hasil2 As Integer

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Tidak boleh ada value yang kosong")
        Else
            jumlah = TextBox1.Text
            persen = TextBox2.Text

            hasil = jumlah * persen / 100
            hasil2 = jumlah - hasil

            TextBox3.Text = hasil
            TextBox4.Text = hasil2
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlah, jumlahdari, hasil As Double

        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Tidak boleh ada value yang kosong")
        Else
            jumlah = TextBox5.Text
            jumlahdari = TextBox6.Text

            hasil = jumlah / jumlahdari * 100

            TextBox7.Text = hasil.ToString + "%"
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
