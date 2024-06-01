Public Class Form1
    Private Sub btn_limitede_Click(sender As Object, e As EventArgs) Handles btn_limitede.Click
        pn_limitede.Visible = True
        pn_nendo.Visible = False
        pn_gundam.Visible = False
        pn_belanja.Visible = False
    End Sub

    Private Sub btn_nendo_Click(sender As Object, e As EventArgs) Handles btn_nendo.Click
        pn_limitede.Visible = False
        pn_nendo.Visible = True
        pn_gundam.Visible = False
        pn_belanja.Visible = False
    End Sub

    Private Sub btn_gndm_Click(sender As Object, e As EventArgs) Handles btn_gndm.Click
        pn_limitede.Visible = False
        pn_nendo.Visible = False
        pn_gundam.Visible = True
        pn_belanja.Visible = False
    End Sub

    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        pn_limitede.Visible = True
        pn_nendo.Visible = False
        pn_gundam.Visible = False
        pn_belanja.Visible = True
    End Sub

    Private Const harga_gura As Integer = 2899999
    Private Const harga_dva As Integer = 1899999
    Private Const harga_itachi As Integer = 899999
    Private Const harga_undertale As Integer = 899999
    Private Const harga_levi As Integer = 799999
    Private Const harga_ichigo As Integer = 499999
    Private Const harga_gojo As Integer = 599999
    Private Const harga_miku As Integer = 599999
    Private Const harga_x105 As Integer = 699999
    Private Const harga_x10a As Integer = 899999
    Private Const harga_x20a As Integer = 899999
    Private Const harga_rx0 As Integer = 499999
    Dim subharga As Integer
    Dim ongkir As Integer
    Dim total As Integer

    Function validemail(email As String) As Boolean
        If email.Contains("@") Or email.Contains(".") Then
            Dim at As Integer = email.IndexOf("@")
            Dim titik As Integer = email.IndexOf(".")

            If at > 0 AndAlso titik > at + 1 AndAlso titik < email.Length - 1 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub btn_gura_Click(sender As Object, e As EventArgs) Handles btn_gura.Click
        subharga += harga_gura
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_dva_Click(sender As Object, e As EventArgs) Handles btn_dva.Click
        subharga += harga_dva
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_itachi_Click(sender As Object, e As EventArgs) Handles btn_itachi.Click
        subharga += harga_itachi
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_undertale_Click(sender As Object, e As EventArgs) Handles btn_undertale.Click
        subharga += harga_undertale
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_levi_Click(sender As Object, e As EventArgs) Handles btn_levi.Click
        subharga += harga_levi
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_ichigo_Click(sender As Object, e As EventArgs) Handles btn_ichigo.Click
        subharga += harga_ichigo
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_gojo_Click(sender As Object, e As EventArgs) Handles btn_gojo.Click
        subharga += harga_gojo
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_miku_Click(sender As Object, e As EventArgs) Handles btn_miku.Click
        subharga += harga_miku
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_gat_Click(sender As Object, e As EventArgs) Handles btn_gat.Click
        subharga += harga_x105
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_x10a_Click(sender As Object, e As EventArgs) Handles btn_x10a.Click
        subharga += harga_x10a
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_x20a_Click(sender As Object, e As EventArgs) Handles btn_x20a.Click
        subharga += harga_x20a
        lb_sub.Text = subharga
    End Sub
    Private Sub btn_rx0_Click(sender As Object, e As EventArgs) Handles btn_rx0.Click
        subharga += harga_rx0
        lb_sub.Text = subharga
    End Sub
    Private Sub cbb_kurir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_kurir.SelectedIndexChanged
        Dim kurir = cbb_kurir.Text
        If kurir = "Hemat" Then
            ongkir += 20000
        ElseIf kurir = "Reguler" Then
            ongkir += 50000
        ElseIf kurir = "Express" Then
            ongkir += 100000
        End If

        lb_sub.Text = subharga
        lb_total.Text = subharga + ongkir
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = tb_email.Text
        If Not validemail(email) Then
            MessageBox.Show("Email anda tidak valid")
            Exit Sub
        End If

        If String.IsNullOrEmpty(tb_email.Text) OrElse cbb_kurir.SelectedItem Is Nothing Then
            MessageBox.Show("Silahkan isi secara lengkap terlebih dahulu")
        Else
            MessageBox.Show("Data Pesanan" & vbCrLf &
                            "Email          : " & tb_email.Text & vbCrLf &
                            "Total Harga : Rp. " & lb_total.Text & vbCrLf & vbCrLf &
                            "Terima Kasih Telah Berbelanja, Silahkan cek email anda untuk tahap selanjutnya:)")
        End If
    End Sub
End Class
