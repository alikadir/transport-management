using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ambar
{
    public partial class Irsaliye : Form
    {
        AnaForm AnaFrm;
        public Irsaliye()
        {
            InitializeComponent();
        }
        public Irsaliye(AnaForm x)
        {
            AnaFrm = x;
            InitializeComponent();
        }
        

        private void Irsaliye_Load(object sender, EventArgs e)
        {
            IrsaliyeDoldur(Ilerleme.Ilk);

            GridMi = true;
            GridView1.Select();
            GridMi = false;
            
        }
        void CbxDoldur()
        {
            this.Cinsi.DataSource = AKBclass.DBMudahale.TabloDoldur("Cins_Tbl", "ORDER BY Ad");
            this.Cinsi.DisplayMember = "Ad";
            this.Cinsi.ValueMember = "ID";
            this.Muhtevat.DataSource = AKBclass.DBMudahale.TabloDoldur("Muhtevat_Tbl", "ORDER BY Ad");
            this.Muhtevat.DisplayMember = "Ad";
            this.Muhtevat.ValueMember = "ID";
            
        }
        bool GridMi = false;
        void GridDoldur(string IrsID)
        {
            CbxDoldur();
            GridView1.AutoGenerateColumns = false;
            GridView1.ScrollBars = ScrollBars.Vertical;
           DataTable dt =  AKBclass.DBMudahale.TabloDoldur("Kalemler_Tbl", "WHERE IrsaliyeID = " + IrsID);
           GridMi = true;
           if (dt.Rows.Count != 0)
               GridView1.DataSource = dt;
           else
               GridView1.DataSource = dt;
            GridMi = false;

            
        }
        public void MusteriSelect(string ID)
        {

            GridView1.SelectedCells[0].Value = int.Parse(ID);
        }


        string irsaliyeid;

        public string IrsaliyeID
        {
            get { return irsaliyeid; }
            set
            {
                irsaliyeid = value;
                if (!string.IsNullOrEmpty(irsaliyeid))
                    GridDoldur(irsaliyeid);
            }
        }
        enum Ilerleme
        {
            Ileri = 1,
            Geri = 2,
            Ilk = 3
        }
        void IrsaliyeDoldur(Ilerleme x)
        {
            GridMi = true;
            GridView1.Select();
            GridMi = false;
            string SQL = "";
            string[] Kayitlar;
            if (x == Ilerleme.Ilk)
            {
                Kayitlar = AKBclass.DBMudahale.TekKayitDondur("Irsaliye_Tbl", "TOP(1) ID,Tarih,No,Plaka,Sofor,Navlun", "ORDER BY Tarih DESC");
                GbxIrsaliye.Enabled = false;
                GbxNavigator.Enabled = true;
                GbxKalemler.Enabled = true;
                
                IrsaliyeID = Kayitlar[0];

                DtTarih.Text = Kayitlar[1] == "-1" ? DateTime.Parse(Kayitlar[1]).ToString("dd.MM.yyyy") : DateTime.Now.ToString("dd.MM.yyyy");
                TxtIrsaliyeNo.Text = Kayitlar[2];
                TxtPlaka.Text = Kayitlar[3];
                TxtSofor.Text = Kayitlar[4];
                TxtNavlun.Text = decimal.Parse(Kayitlar[5]).ToString("C");

                Hesapla();
                return;
            }
            else if (string.IsNullOrEmpty(IrsaliyeID))
                return;
            else if (x == Ilerleme.Ileri)
                SQL = "WHERE ID > " + IrsaliyeID + " ORDER BY ID DESC";
            else if (x == Ilerleme.Geri)
                SQL = "WHERE ID < " + IrsaliyeID + " ORDER BY ID DESC";


            Kayitlar = AKBclass.DBMudahale.TekKayitDondur("Irsaliye_Tbl", "TOP(1) ID,Tarih,No,Plaka,Sofor,Navlun", SQL);

            if (Kayitlar[0] == "-1")
            {
                if (x == Ilerleme.Geri)
                    MessageBox.Show("İlk Kayıttasınız !", "Bir öncesi yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(x == Ilerleme.Ileri)
                    MessageBox.Show("Son Kayıttasınız !", "Bir sonrası yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt Bulunamadı!", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IrsaliyeBosalt();
                IrsaliyeID = Kayitlar[0];
                DtTarih.Text = Kayitlar[1] == "-1" ? DateTime.Parse(Kayitlar[1]).ToString("dd.MM.yyyy") : DateTime.Now.ToString("dd.MM.yyyy");
                TxtIrsaliyeNo.Text = Kayitlar[2];
                TxtPlaka.Text = Kayitlar[3];
                TxtSofor.Text = Kayitlar[4];
                TxtNavlun.Text = decimal.Parse(Kayitlar[5]).ToString("C");

                Hesapla();

            }

        
        }
        public void IrsaliyeDoldurr(string No)
        {
            IrsaliyeBosalt();

            string[] Kayitlar;
            Kayitlar = AKBclass.DBMudahale.TekKayitDondur("Irsaliye_Tbl", "ID,Tarih,No,Plaka,Sofor,Navlun", "WHERE No= " + No);
            IrsaliyeID = Kayitlar[0];
            DtTarih.Text = Kayitlar[1] == "-1" ? DateTime.Parse(Kayitlar[1]).ToString("dd.MM.yyyy") : DateTime.Now.ToString("dd.MM.yyyy");
            TxtIrsaliyeNo.Text = Kayitlar[2];
            TxtPlaka.Text = Kayitlar[3];
            TxtSofor.Text = Kayitlar[4];
            TxtNavlun.Text = decimal.Parse(Kayitlar[5]).ToString("C");

            GbxIrsaliye.Enabled = false;
            GbxNavigator.Enabled = true;
            GbxKalemler.Enabled = true;

            
            Hesapla();

            GridMi = true;
            GridView1.Select();
            GridMi = false;
        }
        void Bul()
        {
            Irsaliyeler x = new Irsaliyeler(this);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }
        bool YeniMi = false;
        
        private void Irsaliye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Bul();
            if (e.KeyCode == Keys.PageUp)
                IrsaliyeDoldur(Ilerleme.Ileri);
            if (e.KeyCode == Keys.PageDown)
                IrsaliyeDoldur(Ilerleme.Geri);
            if (e.KeyCode == Keys.F3)
                BtnYeniKayıt_Click(sender, (EventArgs)e);
            if (e.KeyCode == Keys.F2)
                BtnGuncelle_Click(sender, (EventArgs)e);
            if (e.KeyCode == Keys.F4 && GbxIrsaliye.Enabled)
                BtnKaydet_Click(sender, (EventArgs)e);
            if (e.KeyCode == Keys.Escape && GbxIrsaliye.Enabled)
                BtnIptal_Click(sender, (EventArgs)e);
            


        }
        void IrsaliyeBosalt()
        {
            IrsaliyeID = "";

            DtTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            TxtIrsaliyeNo.Text = "";
            TxtPlaka.Text = "";
            TxtSofor.Text = "";
            TxtNavlun.Text = "";
            LblGenelToplam.Text = "...";
            LblKalemlerKDVToplam.Text = "...";
            LblKalemlerToplam.Text = "...";
            LblNavlunKDVli.Text = "...";
            LblNetToplam.Text = "...";
            


        }
        private void BtnYeniKayıt_Click(object sender, EventArgs e)
        {
            IrsaliyeBosalt();
            GbxIrsaliye.Enabled = true;
            GbxNavigator.Enabled = false;
            GbxKalemler.Enabled = false;
            YeniMi = true;

        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            IrsaliyeDoldur(Ilerleme.Ilk);
            GbxIrsaliye.Enabled = false;
            GbxNavigator.Enabled = true;
            GbxKalemler.Enabled = true;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIrsaliyeNo.Text))
            {
                MessageBox.Show("İrsaliye Numarası Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIrsaliyeNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtPlaka.Text))
            {
                MessageBox.Show("Plaka Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPlaka.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtSofor.Text))
            {
                MessageBox.Show("Söför Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSofor.Focus();
                return;
            }
            

            string SQL = "";
            SqlParameter[] pCollection = new SqlParameter[]
            {
                new SqlParameter("@ID",SqlDbType.BigInt),
                new SqlParameter("@Tarih",SqlDbType.SmallDateTime),
                new SqlParameter("@No",SqlDbType.Int),
                new SqlParameter("@Plaka",SqlDbType.NVarChar, 50),
                new SqlParameter("@Sofor",SqlDbType.NVarChar, 150),
                new SqlParameter("@Navlun",SqlDbType.Decimal),
                new SqlParameter("@OpID",SqlDbType.Int),
                new SqlParameter("@GuncellemeTarihi",SqlDbType.SmallDateTime),
            };
            foreach (SqlParameter x in pCollection)
            {
                x.Value = DBNull.Value;
            }

            if (YeniMi)
            {
                pCollection[1].Value = DateTime.Parse(DtTarih.Text);
                pCollection[2].Value = int.Parse(TxtIrsaliyeNo.Text);
                pCollection[3].Value = TxtPlaka.Text;
                pCollection[4].Value = TxtSofor.Text;
                pCollection[5].Value = decimal.Parse(TxtNavlun.Text.Replace(" TL", ""));
                pCollection[6].Value = AnaFrm.OpID;
                pCollection[7].Value = DateTime.Now;

                if (AKBclass.DBMudahale.Varmi("Irsaliye_Tbl", "WHERE No = @No", pCollection) != "-1")
                {
                    MessageBox.Show("İrsaliye Numarası Mevcut !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtIrsaliyeNo.Focus();
                    TxtIrsaliyeNo.SelectAll();
                    return;
                }
                SQL = "INSERT INTO Irsaliye_Tbl(Tarih,No,Plaka,Sofor,Navlun,OpID,GuncellemeTarihi) VALUES (@Tarih,@No,@Plaka,@Sofor,@Navlun,@OpID,@GuncellemeTarihi)";
                if (AKBclass.DBMudahale.SQLIsle(SQL, pCollection) != "-1")
                    MessageBox.Show("Kaydedildi...", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İşlem sırasında hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pCollection[0].Value = int.Parse(IrsaliyeID);
                pCollection[1].Value = DateTime.Parse(DtTarih.Text);
                pCollection[2].Value = int.Parse(TxtIrsaliyeNo.Text);
                pCollection[3].Value = TxtPlaka.Text;
                pCollection[4].Value = TxtSofor.Text;
                pCollection[5].Value = decimal.Parse(TxtNavlun.Text.Replace(" TL", ""));
                pCollection[6].Value = AnaFrm.OpID;
                pCollection[7].Value = DateTime.Now;
                SQL = "UPDATE Irsaliye_Tbl SET Tarih = @Tarih,No = @No,Plaka = @Plaka,Sofor = @Sofor,Navlun = @Navlun,OpID = @OpID,GuncellemeTarihi = @GuncellemeTarihi WHERE ID = @ID";
                if (AKBclass.DBMudahale.SQLIsle(SQL, pCollection) != "-1")
                    MessageBox.Show("Güncellendi...", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İşlem sırasında hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            IrsaliyeDoldurr(TxtIrsaliyeNo.Text);


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IrsaliyeID))
                MessageBox.Show("Güncellemek için irsaliye seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GbxIrsaliye.Enabled = true;
                GbxNavigator.Enabled = false;
                GbxKalemler.Enabled = false;
                YeniMi = false;
            }
        }
        void Hesapla()
        {
            decimal Navlun;
            decimal KDVliNavlun;
            decimal KalemlerToplam;
            decimal KalemlerKDVliToplam;
            decimal NetToplam;
            decimal GenelToplam;
            
            Navlun = decimal.Parse(TxtNavlun.Text.Replace(" TL",""));
            KDVliNavlun = (Navlun + ((Navlun / 100m) * 18m));

            KalemlerToplam = decimal.Parse(AKBclass.DBMudahale.TekDegerDondur("SELECT SUM(Fiyat) FROM Kalemler_Tbl WHERE IrsaliyeID = " + IrsaliyeID));

            if (KalemlerToplam == -1)
                KalemlerToplam = 0m;

            KalemlerKDVliToplam = (KalemlerToplam + ((KalemlerToplam / 100m) * 18m));

            NetToplam = KalemlerToplam - Navlun;

            GenelToplam = (NetToplam + ((NetToplam / 100m) * 18m));
            
            
            
            LblNavlunKDVli.Text = KDVliNavlun.ToString("C");
            LblKalemlerToplam.Text = KalemlerToplam.ToString("C");
            LblKalemlerKDVToplam.Text = KalemlerKDVliToplam.ToString("C");
            LblNetToplam.Text = NetToplam.ToString("C");
            LblGenelToplam.Text = GenelToplam.ToString("C");

           

        
        }
        private void TxtIrsaliyeNo_Leave(object sender, EventArgs e)
        {
            if (GbxIrsaliye.Enabled == true && YeniMi)
                if (AKBclass.DBMudahale.Varmi("Irsaliye_Tbl", "WHERE No = '" + TxtIrsaliyeNo.Text + "'") != "-1")
                {
                    TxtIrsaliyeNo.SelectAll();
                    TxtIrsaliyeNo.Focus();
                }
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            Bul();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            IrsaliyeDoldur(Ilerleme.Ileri);
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            IrsaliyeDoldur(Ilerleme.Geri);
        }

        private void TxtNavlun_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNavlun.Text))
                TxtNavlun.Text = "0";
            else
                try
                {
                   
                        TxtNavlun.Text = decimal.Parse(TxtNavlun.Text).ToString("C");
                    

                }
                catch 
                {
                    TxtNavlun.Focus(); 
                    TxtNavlun.SelectAll(); 
                }
            Hesapla();
        }

       

        private void TxtNavlun_Enter(object sender, EventArgs e)
        {
            TxtNavlun.Text = TxtNavlun.Text.Replace(" TL", "");
            TxtNavlun.Focus();
            TxtNavlun.SelectAll();
            
        }

        private void TxtNavlun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnKaydet.Focus();
        }

        

        private void GridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (GridMi)
                return;

            bool refresh = false;


            SqlParameter[] pCollection = new SqlParameter[]
            {
                new SqlParameter("@ID",SqlDbType.BigInt),
                new SqlParameter("@IrsaliyeID",SqlDbType.BigInt),
                new SqlParameter("@FisNo",SqlDbType.Int),
                new SqlParameter("@Adet",SqlDbType.Int),
                new SqlParameter("@CinsID",SqlDbType.Int),
                new SqlParameter("@MuhtevatID",SqlDbType.Int),
                new SqlParameter("@Kilo",SqlDbType.NVarChar,10),
                new SqlParameter("@Gonderen",SqlDbType.NVarChar, 150),
                new SqlParameter("@MusteriID",SqlDbType.Int),
                new SqlParameter("@Fiyat",SqlDbType.Decimal),
            };

           

            foreach (DataGridViewRow item in GridView1.Rows)
            {
                

                if (item.Cells["Change"].Value != null)
                {

                    foreach (SqlParameter x in pCollection)
                    {
                        x.Value = DBNull.Value;
                    }

                    


                    refresh = true;

                    if (item.Cells["ID"].Value == DBNull.Value)
                    { //insert 
                        pCollection[1].Value = long.Parse(IrsaliyeID);
                        
                        try { pCollection[2].Value = int.Parse(item.Cells["FisNo"].Value.ToString()); }
                        catch { MessageBox.Show("Fiş Numarasında problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[3].Value = int.Parse(item.Cells["Adet"].Value.ToString()); }
                        catch { MessageBox.Show("Adet de problem var problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[4].Value = int.Parse(item.Cells["Cinsi"].Value.ToString()); }
                        catch {  }

                        try { pCollection[5].Value = int.Parse(item.Cells["Muhtevat"].Value.ToString()); }
                        catch { }

                        try { pCollection[8].Value = int.Parse(item.Cells["Alici"].Value.ToString()); }
                        catch { MessageBox.Show("Alıcı da problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[9].Value = decimal.Parse(item.Cells["Fiyat"].Value.ToString()); }
                        catch { MessageBox.Show("Fiyat da problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }
                        
                        pCollection[6].Value = item.Cells["Kilo"].Value.ToString();
                        pCollection[7].Value = item.Cells["Gonderen"].Value.ToString();
                       
                       

                        AKBclass.DBMudahale.SQLIsle("INSERT INTO Kalemler_Tbl(IrsaliyeID,FisNo,Adet,CinsID,MuhtevatID,Kilo,Gonderen,MusteriID,Fiyat) VALUES (@IrsaliyeID,@FisNo,@Adet,@CinsID,@MuhtevatID,@Kilo,@Gonderen,@MusteriID,@Fiyat)", pCollection);

                    }
                    else
                    {
                        // update
                       
                        pCollection[0].Value = long.Parse(item.Cells["ID"].Value.ToString());
                        pCollection[1].Value = long.Parse(IrsaliyeID);
                        try { pCollection[2].Value = int.Parse(item.Cells["FisNo"].Value.ToString()); }
                        catch { MessageBox.Show("Fiş Numarasında problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[3].Value = int.Parse(item.Cells["Adet"].Value.ToString()); }
                        catch { MessageBox.Show("Adet de problem var problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[4].Value = int.Parse(item.Cells["Cinsi"].Value.ToString()); }
                        catch {  }

                        try { pCollection[5].Value = int.Parse(item.Cells["Muhtevat"].Value.ToString()); }
                        catch { }

                        try { pCollection[8].Value = int.Parse(item.Cells["Alici"].Value.ToString()); }
                        catch { MessageBox.Show("Alıcı da problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        try { pCollection[9].Value = decimal.Parse(item.Cells["Fiyat"].Value.ToString()); }
                        catch { MessageBox.Show("Fiyat da problem var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }

                        pCollection[6].Value = item.Cells["Kilo"].Value.ToString();
                        pCollection[7].Value = item.Cells["Gonderen"].Value.ToString();


                        AKBclass.DBMudahale.SQLIsle("UPDATE Kalemler_Tbl SET IrsaliyeID = @IrsaliyeID,FisNo = @FisNo,Adet = @Adet,CinsID = @CinsID,MuhtevatID = @MuhtevatID,Kilo = @Kilo,Gonderen = @Gonderen,MusteriID = @MusteriID,Fiyat = @Fiyat WHERE ID = @ID", pCollection);


                    }

                        
                }

            }
            if (refresh)
            {
                GridDoldur(IrsaliyeID);
                Hesapla();
            }
           
            
        }

        private void GridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
                GridView1.Rows[e.RowIndex].Cells["Change"].Value = true;
                
           
        }

        

        private void GridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["ID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Kaydı silmek istediğinize eminmisiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AKBclass.DBMudahale.SQLIsle("DELETE FROM Kalemler_Tbl WHERE ID = " + e.Row.Cells["ID"].Value.ToString());
                    Hesapla();
                }
                else
                    e.Cancel = true;
            }
        }

        

        private void GridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            

            switch (e.ColumnIndex)
            { 
                case 8:
                    GridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                    break;
                case 7:
                    Musteriler x = new Musteriler(this);
                    x.ShowDialog();
                    break;
            }

        }

        private void GridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            switch (e.ColumnIndex)
            {
                case 1:
                   
                    MessageBox.Show("Fiş Numarası sadece numerik değer alır", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Adet sadece numerik değer alır", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("Alıcı sadece müşteri numarası olmalıdır", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Fiyat parasal ifade ve sadece numerik olmalıdır", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

      
       

        
       

        

      

    

      

        

     

     



    }
}
