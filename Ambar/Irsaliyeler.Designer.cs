namespace Ambar
{
    partial class Irsaliyeler
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
            this.GbxArama = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DtTarih2 = new System.Windows.Forms.DateTimePicker();
            this.DtTarih1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.TxtSofor = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.GbxIrsaliyeler = new System.Windows.Forms.GroupBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IrsaliyeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sofor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Navlun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbxArama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbxIrsaliyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxArama
            // 
            this.GbxArama.Controls.Add(this.groupBox1);
            this.GbxArama.Controls.Add(this.label4);
            this.GbxArama.Controls.Add(this.label3);
            this.GbxArama.Controls.Add(this.label2);
            this.GbxArama.Controls.Add(this.TxtIrsaliyeNo);
            this.GbxArama.Controls.Add(this.TxtSofor);
            this.GbxArama.Controls.Add(this.TxtPlaka);
            this.GbxArama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbxArama.Location = new System.Drawing.Point(0, 376);
            this.GbxArama.Name = "GbxArama";
            this.GbxArama.Size = new System.Drawing.Size(624, 78);
            this.GbxArama.TabIndex = 0;
            this.GbxArama.TabStop = false;
            this.GbxArama.Text = "Arama Kriterleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DtTarih2);
            this.groupBox1.Controls.Add(this.DtTarih1);
            this.groupBox1.Location = new System.Drawing.Point(341, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 47);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İki Tarih Arasında";
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(232, 17);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(40, 23);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ile";
            // 
            // DtTarih2
            // 
            this.DtTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTarih2.Location = new System.Drawing.Point(132, 19);
            this.DtTarih2.Name = "DtTarih2";
            this.DtTarih2.Size = new System.Drawing.Size(91, 20);
            this.DtTarih2.TabIndex = 4;
            // 
            // DtTarih1
            // 
            this.DtTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTarih1.Location = new System.Drawing.Point(11, 19);
            this.DtTarih1.Name = "DtTarih1";
            this.DtTarih1.Size = new System.Drawing.Size(92, 20);
            this.DtTarih1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şöför";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "İrsaliye No";
            // 
            // TxtIrsaliyeNo
            // 
            this.TxtIrsaliyeNo.Location = new System.Drawing.Point(14, 40);
            this.TxtIrsaliyeNo.Name = "TxtIrsaliyeNo";
            this.TxtIrsaliyeNo.Size = new System.Drawing.Size(100, 20);
            this.TxtIrsaliyeNo.TabIndex = 0;
            this.TxtIrsaliyeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtSofor
            // 
            this.TxtSofor.Location = new System.Drawing.Point(233, 41);
            this.TxtSofor.Name = "TxtSofor";
            this.TxtSofor.Size = new System.Drawing.Size(100, 20);
            this.TxtSofor.TabIndex = 2;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(123, 40);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(100, 20);
            this.TxtPlaka.TabIndex = 1;
            // 
            // GbxIrsaliyeler
            // 
            this.GbxIrsaliyeler.Controls.Add(this.GridView1);
            this.GbxIrsaliyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbxIrsaliyeler.Location = new System.Drawing.Point(0, 0);
            this.GbxIrsaliyeler.Name = "GbxIrsaliyeler";
            this.GbxIrsaliyeler.Size = new System.Drawing.Size(624, 376);
            this.GbxIrsaliyeler.TabIndex = 1;
            this.GbxIrsaliyeler.TabStop = false;
            this.GbxIrsaliyeler.Text = "İrsaliyeler";
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.IrsaliyeNo,
            this.Plaka,
            this.Sofor,
            this.Navlun});
            this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView1.Location = new System.Drawing.Point(3, 16);
            this.GridView1.MultiSelect = false;
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersVisible = false;
            this.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView1.Size = new System.Drawing.Size(618, 357);
            this.GridView1.TabIndex = 6;
            this.GridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellDoubleClick);
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            this.Tarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tarih.Frozen = true;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Width = 115;
            // 
            // IrsaliyeNo
            // 
            this.IrsaliyeNo.DataPropertyName = "No";
            this.IrsaliyeNo.Frozen = true;
            this.IrsaliyeNo.HeaderText = "İrsaliye No";
            this.IrsaliyeNo.Name = "IrsaliyeNo";
            this.IrsaliyeNo.ReadOnly = true;
            // 
            // Plaka
            // 
            this.Plaka.DataPropertyName = "Plaka";
            this.Plaka.Frozen = true;
            this.Plaka.HeaderText = "Plaka";
            this.Plaka.Name = "Plaka";
            this.Plaka.ReadOnly = true;
            // 
            // Sofor
            // 
            this.Sofor.DataPropertyName = "Sofor";
            this.Sofor.Frozen = true;
            this.Sofor.HeaderText = "Söför";
            this.Sofor.Name = "Sofor";
            this.Sofor.ReadOnly = true;
            this.Sofor.Width = 200;
            // 
            // Navlun
            // 
            this.Navlun.DataPropertyName = "Navlun";
            this.Navlun.Frozen = true;
            this.Navlun.HeaderText = "Navlun";
            this.Navlun.Name = "Navlun";
            this.Navlun.ReadOnly = true;
            // 
            // Irsaliyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.GbxIrsaliyeler);
            this.Controls.Add(this.GbxArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Irsaliyeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Irsaliyeler";
            this.Load += new System.EventHandler(this.Irsaliyeler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Irsaliyeler_KeyDown);
            this.GbxArama.ResumeLayout(false);
            this.GbxArama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbxIrsaliyeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxArama;
        private System.Windows.Forms.GroupBox GbxIrsaliyeler;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIrsaliyeNo;
        private System.Windows.Forms.TextBox TxtSofor;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTarih2;
        private System.Windows.Forms.DateTimePicker DtTarih1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IrsaliyeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sofor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navlun;
    }
}