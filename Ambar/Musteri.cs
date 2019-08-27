using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ambar
{
    public partial class Musteri : Form
    {
        AnaForm AnaFrm;
        public Musteri()
        {
            InitializeComponent();
        }
        public Musteri(AnaForm x)
        {
            AnaFrm = x;
            InitializeComponent();
        }

       
        private void Musteri_Load(object sender, EventArgs e)
        {

            ComboBoxlariDoldur();
            GridDoldur();
            TxtAraMNO.Focus();


        }
        void MusteriBosalt()
        { 
            ComboBoxlariDoldur();

            TxtMusteriNo.Text = "";
            TxtMusteriNo.ReadOnly = false;
            TxtUnvan.Text = "";
            TxtAdres.Text = "";
            TxtTelefon.Text = "";
            TxtCep.Text = "";
            TxtFax.Text = "";
            TxtVD.Text = "";
            TxtVNO.Text = "";
            TxtYetkili.Text = "";
            TxtAciklama.Text = "";
            ChkBxAktif.Checked = false;
            GbxMusteriBilgi.Text = "";

        }
        void ComboBoxlariDoldur()
        {
            if (CbxSehir.Items.Count < 1)
            {
                CbxDoldur(CbxSehir, "SELECT DISTINCT(SehirID) AS ID,SehirAdi AS Ad FROM UlkeSehirIlceSemt_Tbl", "...");
                CbxDoldur(CbxOperator, "SELECT Ad,ID FROM Operator_Tbl", "...");
            }
        }
        class ListItem
        {
            public ListItem(string Ad,string ID)
            {
                this.Ad = Ad;
                this.ID = ID;
            }


            private string ad;

            public string Ad
            {
                get { return ad; }
                set { ad = value; }
            }
            private string id;

            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            public override string ToString()
            {
                return Ad;
            }

        }
        void CbxDoldur( ComboBox x,string TamSorgu ,string IlkDeger)
        {
            x.Items.Clear();
            x.Items.Add(new ListItem(IlkDeger, "0"));
            x.SelectedIndex = 0;

            DataTable dt = AKBclass.DBMudahale.TabloDoldur(TamSorgu);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x.Items.Add(new ListItem(dt.Rows[i]["Ad"].ToString(), dt.Rows[i]["ID"].ToString()));
            }

             x.SelectedItem = new ListItem(IlkDeger, "0");

        
        }
        bool YeniMi = false;
        private void BtnYeni_Click(object sender, EventArgs e)
        {
            TxtMusteriNo.Text = AKBclass.DBMudahale.TekDegerDondur("SELECT (MAX(ID)+1) as AKB FROM Musteri_Tbl");
            TxtMusteriNo.Text = (TxtMusteriNo.Text == "-1" ? "100" : TxtMusteriNo.Text);
            YeniMi = true;
            ChkBxAktif.Checked = true;
            TxtMusteriNo.ReadOnly = true;
            GbxMusteriBilgi.Enabled = true;
            GbxMusteriBilgi.Text = "Yeni Müşteri Kaydı";
            GbxMusteriler.Enabled = false;
            TxtAciklama.Text = "";
            TxtAdres.Text = "";
            TxtCep.Text = "";
            TxtFax.Text = "";
            
            TxtTelefon.Text = "";
            TxtUnvan.Text = "";
            TxtVD.Text = "";
            TxtVNO.Text = "";
            TxtYetkili.Text = "";

            TxtUnvan.Focus();

        }
        void Bul()
        {
            if (TxtAraMNO.Text != "")
            {

                GridView1.DataSource = AKBclass.DBMudahale.TabloDoldur("Musteri_Tbl", "WHERE ID = " + TxtAraMNO.Text);

            }
            else
            {
                GridView1.DataSource = AKBclass.DBMudahale.TabloDoldur("Musteri_Tbl", "WHERE Unvan LIKE '" + TxtAraMNO.Text.Replace('?', '%') + "'");
            }


        
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
            YeniMi = false;
            
            GbxMusteriBilgi.Enabled = true;
            GbxMusteriBilgi.Text = "Yeni Müşteri Kaydı";
            GbxMusteriler.Enabled = false;
        }
        void GridDoldur()
        {
            
            DataTable dt = AKBclass.DBMudahale.TabloDoldur("Musteri_Tbl", "");
            GridView1.AutoGenerateColumns = false;
            GridView1.ScrollBars = ScrollBars.Vertical;
            GridView1.DataSource = dt;
           
            
            
        }
        private void CbxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CbxDoldur(CbxIlce, "SELECT DISTINCT(IlceID) AS ID,IlceAdi AS Ad FROM UlkeSehirIlceSemt_Tbl WHERE SehirID = " + ((ListItem)CbxSehir.SelectedItem).ID, "...");
            
            
           

        
        }

        private void CbxIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxDoldur(CbxSemt, "SELECT ID,SemtAdi AS Ad FROM UlkeSehirIlceSemt_Tbl WHERE IlceID = " + ((ListItem)CbxIlce.SelectedItem).ID, "...");
            
           

        }
        void KayıtDoldur(string ID)
        {
            string[] Kayitlar = AKBclass.DBMudahale.TekKayitDondur("Musteri_Tbl", "Unvan,Adres,Tel,Cep,Fax,SehirID,IlceID,SemtID,OperatorID,VergiDairesi,VergiNo,FirmaYetkili,Aciklama,AktifMi,OpID,GuncellemeTarihi", "WHERE ID = " + ID);

            TxtMusteriNo.Text = ID;
            TxtMusteriNo.ReadOnly = true;
            TxtUnvan.Text = Kayitlar[0];
            TxtAdres.Text = Kayitlar[1];
            TxtTelefon.Text = Kayitlar[2];
            TxtCep.Text = Kayitlar[3];
            TxtFax.Text = Kayitlar[4];
            CbxSehir.SelectedValue = Kayitlar[5];
            CbxSehir_SelectedIndexChanged(new object(),new EventArgs());
            CbxIlce.SelectedValue = Kayitlar[6];
            CbxIlce_SelectedIndexChanged(new object(),new EventArgs());
            CbxSemt.SelectedValue = Kayitlar[7];
            CbxOperator.SelectedValue = Kayitlar[8];
            TxtVD.Text = Kayitlar[9];
            TxtVNO.Text = Kayitlar[10];
            TxtYetkili.Text = Kayitlar[11];
            TxtAciklama.Text = Kayitlar[12];
            ChkBxAktif.Checked = bool.Parse(Kayitlar[13] == "-1" ? "False" : Kayitlar[13]);

            Grid2Doldur(ID);

        }



        void Grid2Doldur(string MID)
        { 
            GridView2.AutoGenerateColumns = false;
            GridView2.ScrollBars = ScrollBars.Vertical;
            GridView2.DataSource = AKBclass.DBMudahale.TabloDoldur("SELECT FisNo,Adet,(SELECT Ad FROM Cins_Tbl WHERE ID = Kalemler_Tbl.CinsID) AS Cins,(SELECT Ad FROM Muhtevat_Tbl WHERE ID = Kalemler_Tbl.MuhtevatID) AS Muhtevat,Kilo,Gonderen,Fiyat FROM Kalemler_Tbl WHERE MusteriID = " + MID + " ORDER BY ID DESC");
            string borc = AKBclass.DBMudahale.TekDegerDondur("SELECT SUM(Fiyat) FROM Kalemler_Tbl WHERE MusteriID = "+MID);
            if(borc == "-1")
                borc = "0";
            LblMusteriBorc.Text = "Toplam Net Borç : " + decimal.Parse(borc).ToString("C");
        }

        private void GridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (GridView1.Focused)
            {
            
            string ID = GridView1.SelectedRows[0].Cells[0].Value.ToString();

            KayıtDoldur(ID);
            }
        }

        private void Musteri_Activated(object sender, EventArgs e)
        {
            TxtAraMNO.Focus();
        }
        bool NumerikMi(string a)
        {
            try
            {
                int.Parse(a);
                return true;
            }
            catch 
            {
                return false;
                
            }
        
        }
        private void TxtAraMNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!NumerikMi(e.KeyChar.ToString()))
                switch (e.KeyChar)
                {
                    case '\r':
                        Bul();
                        break;
                    case '\b':
                        // backspace
                        break;
                    case '?':

                        break;
                    default:
                        e.Handled = true;
                        break;


                }

        }
        bool KayitKontrol()
        {
            // kayıt yaparken kontrol edilecek eleman var ise burada kontorl yapılıp mesaj verilip return true veya false yazılacak
            return true;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (KayitKontrol())
            {
                SqlParameter[] pCollection = new SqlParameter[]
                {
                    new SqlParameter("@ID",SqlDbType.Int),
                    new SqlParameter("@Unvan",SqlDbType.NVarChar, 150),
                    new SqlParameter("@Adres",SqlDbType.NVarChar, 250),
                    new SqlParameter("@Tel",SqlDbType.NVarChar, 15),
                    new SqlParameter("@Cep",SqlDbType.NVarChar, 15),
                    new SqlParameter("@Fax",SqlDbType.NVarChar, 15),
                    new SqlParameter("@SehirID",SqlDbType.Int),
                    new SqlParameter("@IlceID",SqlDbType.Int),
                    new SqlParameter("@SemtID",SqlDbType.Int),
                    new SqlParameter("@OperatorID",SqlDbType.Int),
                    new SqlParameter("@VergiDairesi",SqlDbType.NVarChar, 50),
                    new SqlParameter("@VergiNo",SqlDbType.NVarChar, 50),
                    new SqlParameter("@FirmaYetkili",SqlDbType.NVarChar, 150),
                    new SqlParameter("@Aciklama",SqlDbType.NVarChar, 500),
                    new SqlParameter("@AktifMi",SqlDbType.Bit),
                    new SqlParameter("@OpID",SqlDbType.Int),
                    new SqlParameter("@GuncellemeTarihi",SqlDbType.SmallDateTime),
                };
                foreach (SqlParameter x in pCollection)
                {
                    x.Value = DBNull.Value;
                }
                pCollection[0].Value = int.Parse(TxtMusteriNo.Text);
                pCollection[1].Value = TxtUnvan.Text;
                pCollection[2].Value = TxtAdres.Text;
                pCollection[3].Value = TxtTelefon.Text;
                pCollection[4].Value = TxtCep.Text;
                pCollection[5].Value = TxtFax.Text;
                pCollection[6].Value = int.Parse(((ListItem)CbxSehir.SelectedItem).ID);
                pCollection[7].Value = int.Parse(((ListItem)CbxIlce.SelectedItem).ID);
                pCollection[8].Value = int.Parse(((ListItem)CbxSemt.SelectedItem).ID);
                pCollection[9].Value = int.Parse(((ListItem)CbxOperator.SelectedItem).ID);
                pCollection[10].Value = TxtVD.Text;
                pCollection[11].Value = TxtVNO.Text;
                pCollection[12].Value = TxtYetkili.Text;
                pCollection[13].Value = TxtAciklama.Text;
                pCollection[14].Value = ChkBxAktif.Checked;
                pCollection[15].Value = AnaFrm.OpID;
                pCollection[16].Value = DateTime.Now;

                if (YeniMi)
                {
                   if(AKBclass.DBMudahale.SQLIsle("INSERT INTO Musteri_Tbl(Unvan,Adres,Tel,Cep,Fax,SehirID,IlceID,SemtID,OperatorID,VergiDairesi,VergiNo,FirmaYetkili,Aciklama,AktifMi,OpID,GuncellemeTarihi) VALUES (@Unvan,@Adres,@Tel,@Cep,@Fax,@SehirID,@IlceID,@SemtID,@OperatorID,@VergiDairesi,@VergiNo,@FirmaYetkili,@Aciklama,@AktifMi,@OpID,@GuncellemeTarihi)", pCollection)!="-1")
                    MessageBox.Show("Müşteri Kaydedildi...", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   else
                       MessageBox.Show("İşlem sırasında hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (AKBclass.DBMudahale.SQLIsle("UPDATE Musteri_Tbl SET Unvan = @Unvan,Adres = @Adres,Tel = @Tel,Cep = @Cep,Fax = @Fax,SehirID = @SehirID,IlceID = @IlceID,SemtID = @SemtID,OperatorID = @OperatorID,VergiDairesi = @VergiDairesi,VergiNo = @VergiNo,FirmaYetkili = @FirmaYetkili,Aciklama = @Aciklama,AktifMi = @AktifMi,OpID = @OpID,GuncellemeTarihi = @GuncellemeTarihi WHERE ID = @ID", pCollection) != "-1")
                        MessageBox.Show("Müşteri Güncellendi...", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("İşlem sırasında hata oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                GbxMusteriBilgi.Enabled = false;
                GbxMusteriler.Enabled = true;
                TxtAraMNO.Focus();
                GridDoldur();
            }
        

        }

        private void Musteri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                BtnYeni_Click(sender, (EventArgs)e);
            if (e.KeyCode == Keys.F2)
                BtnGuncelle_Click(sender, (EventArgs)e);
            if (e.KeyCode == Keys.F4)
            {
                if (GbxMusteriBilgi.Enabled == true) BtnKaydet_Click(sender, (EventArgs)e); else MessageBox.Show("Kayıt işlemi için önce müşteri seçmeli veya güncelle demelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (GbxMusteriBilgi.Enabled == true)
                    BtnKayitIptal_Click(sender, (EventArgs)e);
                else
                    this.Close();
            }
        }

        private void BtnKayitIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlemi İptal etmek istediğinizden eminmisiniz ?", "İptal Edilsinmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MusteriBosalt();
                GbxMusteriBilgi.Enabled = false;
                GbxMusteriler.Enabled = true;
                TxtAraMNO.Focus();
            }
        }

        private void GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = GridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            KayıtDoldur(ID);
        }

     
     

       

     


       

       

  

       

    }
}
