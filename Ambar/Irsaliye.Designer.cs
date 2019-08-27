namespace Ambar
{
    partial class Irsaliye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.TxtSofor = new System.Windows.Forms.TextBox();
            this.TxtNavlun = new System.Windows.Forms.TextBox();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnYeniKayıt = new System.Windows.Forms.Button();
            this.BtnIleri = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.GbxNavigator = new System.Windows.Forms.GroupBox();
            this.BtnBul = new System.Windows.Forms.Button();
            this.GbxIrsaliye = new System.Windows.Forms.GroupBox();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblKalemlerKDVToplam = new System.Windows.Forms.Label();
            this.LblGenelToplam = new System.Windows.Forms.Label();
            this.LblNetToplam = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblKalemlerToplam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblNavlunKDVli = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GbxKalemler = new System.Windows.Forms.GroupBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Muhtevat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gonderen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GbxNavigator.SuspendLayout();
            this.GbxIrsaliye.SuspendLayout();
            this.GbxKalemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtTarih
            // 
            this.DtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTarih.Location = new System.Drawing.Point(22, 45);
            this.DtTarih.Name = "DtTarih";
            this.DtTarih.Size = new System.Drawing.Size(97, 20);
            this.DtTarih.TabIndex = 0;
            // 
            // TxtIrsaliyeNo
            // 
            this.TxtIrsaliyeNo.Location = new System.Drawing.Point(153, 45);
            this.TxtIrsaliyeNo.Name = "TxtIrsaliyeNo";
            this.TxtIrsaliyeNo.Size = new System.Drawing.Size(100, 20);
            this.TxtIrsaliyeNo.TabIndex = 1;
            this.TxtIrsaliyeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIrsaliyeNo.Leave += new System.EventHandler(this.TxtIrsaliyeNo_Leave);
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(290, 45);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(87, 20);
            this.TxtPlaka.TabIndex = 2;
            // 
            // TxtSofor
            // 
            this.TxtSofor.Location = new System.Drawing.Point(409, 45);
            this.TxtSofor.Name = "TxtSofor";
            this.TxtSofor.Size = new System.Drawing.Size(136, 20);
            this.TxtSofor.TabIndex = 3;
            // 
            // TxtNavlun
            // 
            this.TxtNavlun.Location = new System.Drawing.Point(574, 45);
            this.TxtNavlun.Name = "TxtNavlun";
            this.TxtNavlun.Size = new System.Drawing.Size(100, 20);
            this.TxtNavlun.TabIndex = 4;
            this.TxtNavlun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNavlun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNavlun_KeyDown);
            this.TxtNavlun.Leave += new System.EventHandler(this.TxtNavlun_Leave);
            this.TxtNavlun.Enter += new System.EventHandler(this.TxtNavlun_Enter);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(57, 19);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(165, 40);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "<---    Bir Önceki";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnYeniKayıt
            // 
            this.BtnYeniKayıt.Location = new System.Drawing.Point(430, 19);
            this.BtnYeniKayıt.Name = "BtnYeniKayıt";
            this.BtnYeniKayıt.Size = new System.Drawing.Size(120, 40);
            this.BtnYeniKayıt.TabIndex = 3;
            this.BtnYeniKayıt.Text = "Yeni İrsaliye (F3)";
            this.BtnYeniKayıt.UseVisualStyleBackColor = true;
            this.BtnYeniKayıt.Click += new System.EventHandler(this.BtnYeniKayıt_Click);
            // 
            // BtnIleri
            // 
            this.BtnIleri.Location = new System.Drawing.Point(766, 19);
            this.BtnIleri.Name = "BtnIleri";
            this.BtnIleri.Size = new System.Drawing.Size(165, 40);
            this.BtnIleri.TabIndex = 3;
            this.BtnIleri.Text = "Bir Sonraki    --->";
            this.BtnIleri.UseVisualStyleBackColor = true;
            this.BtnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(567, 19);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle (F2)";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // GbxNavigator
            // 
            this.GbxNavigator.Controls.Add(this.BtnIleri);
            this.GbxNavigator.Controls.Add(this.BtnGeri);
            this.GbxNavigator.Controls.Add(this.BtnGuncelle);
            this.GbxNavigator.Controls.Add(this.BtnBul);
            this.GbxNavigator.Controls.Add(this.BtnYeniKayıt);
            this.GbxNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbxNavigator.Location = new System.Drawing.Point(0, 0);
            this.GbxNavigator.Name = "GbxNavigator";
            this.GbxNavigator.Size = new System.Drawing.Size(984, 71);
            this.GbxNavigator.TabIndex = 5;
            this.GbxNavigator.TabStop = false;
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(291, 19);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(120, 40);
            this.BtnBul.TabIndex = 3;
            this.BtnBul.Text = "Bul (F1)";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // GbxIrsaliye
            // 
            this.GbxIrsaliye.Controls.Add(this.BtnIptal);
            this.GbxIrsaliye.Controls.Add(this.BtnKaydet);
            this.GbxIrsaliye.Controls.Add(this.label5);
            this.GbxIrsaliye.Controls.Add(this.label4);
            this.GbxIrsaliye.Controls.Add(this.label3);
            this.GbxIrsaliye.Controls.Add(this.label2);
            this.GbxIrsaliye.Controls.Add(this.label1);
            this.GbxIrsaliye.Controls.Add(this.TxtNavlun);
            this.GbxIrsaliye.Controls.Add(this.DtTarih);
            this.GbxIrsaliye.Controls.Add(this.TxtIrsaliyeNo);
            this.GbxIrsaliye.Controls.Add(this.TxtSofor);
            this.GbxIrsaliye.Controls.Add(this.TxtPlaka);
            this.GbxIrsaliye.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbxIrsaliye.Location = new System.Drawing.Point(0, 71);
            this.GbxIrsaliye.Name = "GbxIrsaliye";
            this.GbxIrsaliye.Size = new System.Drawing.Size(984, 140);
            this.GbxIrsaliye.TabIndex = 5;
            this.GbxIrsaliye.TabStop = false;
            this.GbxIrsaliye.Text = "İrsaliye Bilgileri";
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(21, 102);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(99, 23);
            this.BtnIptal.TabIndex = 6;
            this.BtnIptal.Text = "İptal (ESC)";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(135, 102);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(156, 23);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet (F4)";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Navlun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şöför";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İrsaliye No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarih";
            // 
            // LblKalemlerKDVToplam
            // 
            this.LblKalemlerKDVToplam.AutoSize = true;
            this.LblKalemlerKDVToplam.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalemlerKDVToplam.Location = new System.Drawing.Point(142, 65);
            this.LblKalemlerKDVToplam.Name = "LblKalemlerKDVToplam";
            this.LblKalemlerKDVToplam.Size = new System.Drawing.Size(16, 13);
            this.LblKalemlerKDVToplam.TabIndex = 9;
            this.LblKalemlerKDVToplam.Text = "...";
            // 
            // LblGenelToplam
            // 
            this.LblGenelToplam.AutoSize = true;
            this.LblGenelToplam.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGenelToplam.Location = new System.Drawing.Point(142, 114);
            this.LblGenelToplam.Name = "LblGenelToplam";
            this.LblGenelToplam.Size = new System.Drawing.Size(20, 17);
            this.LblGenelToplam.TabIndex = 9;
            this.LblGenelToplam.Text = "...";
            // 
            // LblNetToplam
            // 
            this.LblNetToplam.AutoSize = true;
            this.LblNetToplam.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNetToplam.Location = new System.Drawing.Point(142, 89);
            this.LblNetToplam.Name = "LblNetToplam";
            this.LblNetToplam.Size = new System.Drawing.Size(16, 13);
            this.LblNetToplam.TabIndex = 9;
            this.LblNetToplam.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(22, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Kalemler KDV li toplam :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(47, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Genel Toplam :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(78, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Net Toplam :";
            // 
            // LblKalemlerToplam
            // 
            this.LblKalemlerToplam.AutoSize = true;
            this.LblKalemlerToplam.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalemlerToplam.Location = new System.Drawing.Point(142, 42);
            this.LblKalemlerToplam.Name = "LblKalemlerToplam";
            this.LblKalemlerToplam.Size = new System.Drawing.Size(16, 13);
            this.LblKalemlerToplam.TabIndex = 8;
            this.LblKalemlerToplam.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kalemler Toplam :";
            // 
            // LblNavlunKDVli
            // 
            this.LblNavlunKDVli.AutoSize = true;
            this.LblNavlunKDVli.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNavlunKDVli.Location = new System.Drawing.Point(142, 20);
            this.LblNavlunKDVli.Name = "LblNavlunKDVli";
            this.LblNavlunKDVli.Size = new System.Drawing.Size(16, 13);
            this.LblNavlunKDVli.TabIndex = 7;
            this.LblNavlunKDVli.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Navlun KDV li Tutar :";
            // 
            // GbxKalemler
            // 
            this.GbxKalemler.Controls.Add(this.GridView1);
            this.GbxKalemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbxKalemler.Location = new System.Drawing.Point(0, 211);
            this.GbxKalemler.Name = "GbxKalemler";
            this.GbxKalemler.Size = new System.Drawing.Size(984, 274);
            this.GbxKalemler.TabIndex = 6;
            this.GbxKalemler.TabStop = false;
            this.GbxKalemler.Text = "Kalemler";
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FisNo,
            this.Adet,
            this.Cinsi,
            this.Muhtevat,
            this.Kilo,
            this.Gonderen,
            this.Alici,
            this.Fiyat,
            this.Change});
            this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView1.Location = new System.Drawing.Point(3, 16);
            this.GridView1.MultiSelect = false;
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowCellErrors = false;
            this.GridView1.ShowRowErrors = false;
            this.GridView1.Size = new System.Drawing.Size(978, 255);
            this.GridView1.TabIndex = 0;
            this.GridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GridView1_UserDeletingRow);
            this.GridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GridView1_CellBeginEdit);
            this.GridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_RowLeave);
            this.GridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellEndEdit);
            this.GridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridView1_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblKalemlerToplam);
            this.groupBox1.Controls.Add(this.LblKalemlerKDVToplam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblNavlunKDVli);
            this.groupBox1.Controls.Add(this.LblGenelToplam);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblNetToplam);
            this.groupBox1.Location = new System.Drawing.Point(704, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İrsaliye Tutarı";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FisNo
            // 
            this.FisNo.DataPropertyName = "FisNo";
            this.FisNo.HeaderText = "Fiş No";
            this.FisNo.Name = "FisNo";
            // 
            // Adet
            // 
            this.Adet.DataPropertyName = "Adet";
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // Cinsi
            // 
            this.Cinsi.DataPropertyName = "CinsID";
            this.Cinsi.HeaderText = "Cinsi";
            this.Cinsi.Name = "Cinsi";
            this.Cinsi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cinsi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Muhtevat
            // 
            this.Muhtevat.DataPropertyName = "MuhtevatID";
            this.Muhtevat.HeaderText = "Muhtevat";
            this.Muhtevat.Name = "Muhtevat";
            this.Muhtevat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Muhtevat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Kilo
            // 
            this.Kilo.DataPropertyName = "Kilo";
            this.Kilo.HeaderText = "Kilo";
            this.Kilo.Name = "Kilo";
            // 
            // Gonderen
            // 
            this.Gonderen.DataPropertyName = "Gonderen";
            this.Gonderen.HeaderText = "Gönderen";
            this.Gonderen.Name = "Gonderen";
            this.Gonderen.Width = 135;
            // 
            // Alici
            // 
            this.Alici.DataPropertyName = "MusteriID";
            this.Alici.HeaderText = "Alıcı";
            this.Alici.Name = "Alici";
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Fiyat.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // Change
            // 
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Width = 75;
            // 
            // Irsaliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxKalemler);
            this.Controls.Add(this.GbxIrsaliye);
            this.Controls.Add(this.GbxNavigator);
            this.KeyPreview = true;
            this.Name = "Irsaliye";
            this.Text = "Irsaliye";
            this.Load += new System.EventHandler(this.Irsaliye_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Irsaliye_KeyDown);
            this.GbxNavigator.ResumeLayout(false);
            this.GbxIrsaliye.ResumeLayout(false);
            this.GbxIrsaliye.PerformLayout();
            this.GbxKalemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtTarih;
        private System.Windows.Forms.TextBox TxtIrsaliyeNo;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.TextBox TxtSofor;
        private System.Windows.Forms.TextBox TxtNavlun;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnYeniKayıt;
        private System.Windows.Forms.Button BtnIleri;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.GroupBox GbxNavigator;
        private System.Windows.Forms.GroupBox GbxIrsaliye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNetToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblKalemlerToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblNavlunKDVli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblKalemlerKDVToplam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox GbxKalemler;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Label LblGenelToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cinsi;
        private System.Windows.Forms.DataGridViewComboBoxColumn Muhtevat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gonderen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Change;
    }
}