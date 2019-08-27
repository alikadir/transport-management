using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Ambar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AnaForm AnaFrm;
        public Login(AnaForm x)
        {
            AnaFrm = x;
            InitializeComponent();
            this.ControlBox = false;
        }
        private void TxtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnGiris_Click(sender, (EventArgs)e);
                e.Handled = true;

            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtSifre.Text != "")
            {
                SqlParameter[] pCollection = new SqlParameter[] 
            {
              new SqlParameter("@Sifre",SqlDbType.NVarChar,50),
              new SqlParameter("@AktifMi",SqlDbType.Bit)
            };
                pCollection[0].Value = TxtSifre.Text;
                pCollection[1].Value = true;

                Cursor.Current = Cursors.WaitCursor;
                
                // Yedekleme Sistemi ----------
                string Yol = @"C:\AMBAR\YEDEK\";
                string Dosya = Yol + DateTime.Now.ToString("dd_MM_yyyy") + ".bak";
                if ((!File.Exists(Yol + DateTime.Now.ToString("dd_MM_yyyy") + ".bak")))
                {

                    AKBclass.DBMudahale.SQLIsle("BACKUP DATABASE [AMBAR] TO  DISK = N'" + Dosya + "' WITH NOFORMAT, NOINIT,  NAME = N'AMBAR-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                }
                // ----------------------------

                String[] Res = AKBclass.DBMudahale.TekKayitDondur("Operator_Tbl", "Ad,ID", "WHERE Sifre = @Sifre AND AktifMi = @AktifMi", pCollection);

                Cursor.Current = Cursors.Default;

                if (Res[0] == "Ad")
                {
                    MessageBox.Show("Girilen Şifre Doğru Değil!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtSifre.Focus();
                    TxtSifre.SelectAll();
                }
                else
                {

                    AnaFrm.LoginOldum(int.Parse(Res[1]));
                    this.Close();


                }
            }
            else
                TxtSifre.Focus();
        }

      

        

       
    }
}
