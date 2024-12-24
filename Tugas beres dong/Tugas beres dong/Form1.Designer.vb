<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmenu))
        Cmbjenis = New ComboBox()
        Cmbnama = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Bhitung = New Button()
        Bbatal = New Button()
        Bkeluar = New Button()
        TextBox1 = New TextBox()
        Txtharga = New TextBox()
        Txtjumlah = New TextBox()
        Txtpotongan = New TextBox()
        Txttotalbayar = New TextBox()
        Txttotalharga = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Cmbjenis
        ' 
        Cmbjenis.FormattingEnabled = True
        Cmbjenis.Location = New Point(200, 205)
        Cmbjenis.Name = "Cmbjenis"
        Cmbjenis.Size = New Size(251, 28)
        Cmbjenis.TabIndex = 0
        ' 
        ' Cmbnama
        ' 
        Cmbnama.FormattingEnabled = True
        Cmbnama.Location = New Point(200, 252)
        Cmbnama.Name = "Cmbnama"
        Cmbnama.Size = New Size(251, 28)
        Cmbnama.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(309, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(413, 31)
        Label1.TabIndex = 2
        Label1.Text = "- ANGKRINGAN TANPA NAMA -"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(56, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 20)
        Label2.TabIndex = 3
        Label2.Text = "TGL TRANSAKSI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(56, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 4
        Label3.Text = "JENIS MAKANAN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(56, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 20)
        Label4.TabIndex = 5
        Label4.Text = "NAMA MAKANAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(56, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 6
        Label5.Text = "HARGA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(56, 349)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 7
        Label6.Text = "JUMLAH"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(541, 116)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 20)
        Label7.TabIndex = 8
        Label7.Text = "NO. ANTRIAN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(541, 447)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 20)
        Label8.TabIndex = 9
        Label8.Text = "TOTAL HARGA"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(541, 498)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 20)
        Label9.TabIndex = 10
        Label9.Text = "POTONGAN"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(541, 549)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 20)
        Label10.TabIndex = 11
        Label10.Text = "TOTAL BAYAR"
        ' 
        ' Bhitung
        ' 
        Bhitung.Location = New Point(200, 414)
        Bhitung.Name = "Bhitung"
        Bhitung.Size = New Size(94, 36)
        Bhitung.TabIndex = 12
        Bhitung.Text = "HITUNG"
        Bhitung.UseVisualStyleBackColor = True
        ' 
        ' Bbatal
        ' 
        Bbatal.Location = New Point(356, 414)
        Bbatal.Name = "Bbatal"
        Bbatal.Size = New Size(94, 36)
        Bbatal.TabIndex = 13
        Bbatal.Text = "BATAL"
        Bbatal.UseVisualStyleBackColor = True
        ' 
        ' Bkeluar
        ' 
        Bkeluar.Location = New Point(808, 619)
        Bkeluar.Name = "Bkeluar"
        Bkeluar.Size = New Size(94, 36)
        Bkeluar.TabIndex = 14
        Bkeluar.Text = "KELUAR"
        Bkeluar.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(682, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Txtharga
        ' 
        Txtharga.Location = New Point(200, 299)
        Txtharga.Name = "Txtharga"
        Txtharga.Size = New Size(251, 27)
        Txtharga.TabIndex = 16
        ' 
        ' Txtjumlah
        ' 
        Txtjumlah.Location = New Point(200, 344)
        Txtjumlah.Name = "Txtjumlah"
        Txtjumlah.Size = New Size(250, 27)
        Txtjumlah.TabIndex = 17
        ' 
        ' Txtpotongan
        ' 
        Txtpotongan.Location = New Point(682, 495)
        Txtpotongan.Name = "Txtpotongan"
        Txtpotongan.Size = New Size(250, 27)
        Txtpotongan.TabIndex = 18
        ' 
        ' Txttotalbayar
        ' 
        Txttotalbayar.Location = New Point(682, 545)
        Txttotalbayar.Name = "Txttotalbayar"
        Txttotalbayar.Size = New Size(250, 27)
        Txttotalbayar.TabIndex = 19
        ' 
        ' Txttotalharga
        ' 
        Txttotalharga.Location = New Point(682, 444)
        Txttotalharga.Name = "Txttotalharga"
        Txttotalharga.Size = New Size(250, 27)
        Txttotalharga.TabIndex = 20
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(200, 113)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 21
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(541, 205)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(391, 166)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(31, 677)
        Label11.Name = "Label11"
        Label11.Size = New Size(519, 20)
        Label11.TabIndex = 23
        Label11.Text = "Dapatkan potongan Rp10.000 untuk setiap pembelian minimal Rp100.000"
        ' 
        ' Frmmenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(1001, 732)
        Controls.Add(Label11)
        Controls.Add(PictureBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Txttotalharga)
        Controls.Add(Txttotalbayar)
        Controls.Add(Txtpotongan)
        Controls.Add(Txtjumlah)
        Controls.Add(Txtharga)
        Controls.Add(TextBox1)
        Controls.Add(Bkeluar)
        Controls.Add(Bbatal)
        Controls.Add(Bhitung)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cmbnama)
        Controls.Add(Cmbjenis)
        Name = "Frmmenu"
        Text = "Menu Transaksi"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cmbjenis As ComboBox
    Friend WithEvents Cmbnama As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Bhitung As Button
    Friend WithEvents Bbatal As Button
    Friend WithEvents Bkeluar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Txtharga As TextBox
    Friend WithEvents Txtjumlah As TextBox
    Friend WithEvents Txtpotongan As TextBox
    Friend WithEvents Txttotalbayar As TextBox
    Friend WithEvents Txttotalharga As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label

End Class
