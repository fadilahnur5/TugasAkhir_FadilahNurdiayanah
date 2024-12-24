Public Class Frmmenu
    'Deklarasi array untuk menyimpan daftar makanan
    Private jenismakanan() As String = {"Ayam", "Nasi", "Sate"}
    Private Ayam() As String = {"Ayam Bakar", "Ayam Goreng", "Ayam Geprek"}
    Private Nasi() As String = {"Nasi Liwet", "Nasi Kucing", "Nasi Bakar"}
    Private Sate() As String = {"Sate Usus", "Sate Telur Puyuh", "Sate Ati Ampela"}

    'Harga makanan berdasarkan nama
    Private hargamakanan As New Dictionary(Of String, Integer) From {
        {"Ayam Bakar", 25000},
        {"Ayam Goreng", 20000},
        {"Ayam Geprek", 17000},
        {"Nasi Liwet", 15000},
        {"Nasi Bakar", 13000},
        {"Nasi Kucing", 10000},
        {"Sate Usus", 3000},
        {"Sate Telur Puyuh", 5000},
        {"Sate Ati Ampela", 7000}
    }
    Private Sub Frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmbjenis.Items.AddRange(jenismakanan)
    End Sub

    Private Sub Cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbjenis.SelectedIndexChanged
        If Cmbjenis.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Cmbnama.Items.Clear()
        Select Case Cmbjenis.SelectedItem.ToString()
            Case "Ayam"
                Cmbnama.Items.AddRange(Ayam)
            Case "Nasi"
                Cmbnama.Items.AddRange(Nasi)
            Case "Sate"
                Cmbnama.Items.AddRange(Sate)
        End Select
    End Sub

    Private Sub Cmbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbnama.SelectedIndexChanged
        'Menampilkan harga otomatis ketika nama makan dipilih
        If Cmbnama.SelectedIndex <> -1 Then
            Dim makanan As String = Cmbnama.SelectedItem.ToString()
            If hargamakanan.ContainsKey(makanan) Then
                Txtharga.Text = hargamakanan(makanan).ToString()
            End If
        End If
    End Sub

    Private Sub Bhitung_Click(sender As Object, e As EventArgs) Handles Bhitung.Click
        Dim harga As Integer = 0
        Dim jumlah As Integer
        Dim potongan As Integer = 0
        Dim totalbayar As Integer

        'Ambil harga dari Txtharga
        If Integer.TryParse(Txtharga.Text, harga) AndAlso Integer.TryParse(Txtjumlah.Text, jumlah) AndAlso jumlah > 0 Then
            Dim totalharga As Integer = harga * jumlah

            'Diskon jika total harga lebih dari 100000
            If totalharga > 100000 Then
                potongan = 10000
            End If

            totalbayar = totalharga - potongan

            'Tampilkan hasil
            Txtharga.Text = harga.ToString()
            Txttotalharga.Text = totalharga.ToString()
            Txtpotongan.Text = potongan.ToString()
            Txttotalbayar.Text = totalbayar.ToString()
        Else
            MessageBox.Show("Masukkan jumlah yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Bbatal_Click(sender As Object, e As EventArgs) Handles Bbatal.Click
        'Reset ComboBox jenis ke posisi semula
        Cmbjenis.SelectedIndex = -1
        Cmbjenis.Text = String.Empty 'Bersihkan teks yang terlihat di ComboBox jenis

        'Kosongkan comboBox nama
        Cmbnama.Items.Clear()
        Cmbnama.SelectedIndex = -1
        Cmbnama.Text = String.Empty 'Bersihkan teks yang terlihat di ComboBox nama

        'Bersihkan semua TextBox input dan output
        Txtjumlah.Clear()
        Txtharga.Clear()
        Txttotalharga.Clear()
        Txtpotongan.Clear()
        Txttotalbayar.Clear()

        'Fokuskan kembali ke comboBox jenis agar pengguna bisa mulai dari awal
        Cmbjenis.Focus()
    End Sub

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        Me.Close()
    End Sub
End Class
