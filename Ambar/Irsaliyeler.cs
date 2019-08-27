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
    public partial class Irsaliyeler : Form
    {
        Irsaliye Irs;
        public Irsaliyeler(Irsaliye x)
        {
            Irs = x;
            InitializeComponent();

        }
        
        public Irsaliyeler()
        {
            
            InitializeComponent();

        }
        
        void GridDoldur()
        {
            GridView1.ScrollBars = ScrollBars.Vertical;
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = AKBclass.DBMudahale.TabloDoldur("Irsaliye_Tbl", "ORDER BY Tarih DESC");
            


        }
        enum BulKriter
        {
            IkiTarih = 1,
            No = 2,
            Plaka = 3,
            Sofor = 4
        }
        void Bul(BulKriter x)
        {
            string SQL = "";
            SqlParameter[] pCollection = new SqlParameter[]
            {
               
                new SqlParameter("@Tarih1",SqlDbType.SmallDateTime),
                new SqlParameter("@Tarih2",SqlDbType.SmallDateTime),
                new SqlParameter("@No",SqlDbType.Int),
                new SqlParameter("@Plaka",SqlDbType.NVarChar, 50),
                new SqlParameter("@Sofor",SqlDbType.NVarChar, 150),
               
            };

            foreach (SqlParameter y in pCollection)
            {
                y.Value = DBNull.Value;
            }


            if (x == BulKriter.IkiTarih)
            {
                pCollection[0].Value = DateTime.Parse(DtTarih1.Text);
                pCollection[1].Value = DateTime.Parse(DtTarih2.Text);
                SQL = "SELECT * FROM Irsaliye_Tbl WHERE Tarih < @Tarih2 AND Tarih > @Tarih1 ORDER BY Tarih DESC";
            }
            else if (x == BulKriter.No)
            {
                pCollection[2].Value = int.Parse(TxtIrsaliyeNo.Text);
                SQL = "SELECT * FROM Irsaliye_Tbl WHERE No = @No";
            
            }
            else if (x == BulKriter.Plaka)
            {

                SQL = "SELECT * FROM Irsaliye_Tbl WHERE Plaka LIKE '" + TxtPlaka.Text.Replace('?', '%') + "' ORDER BY Tarih DESC";
            }
            else if (x == BulKriter.Sofor)
            {
                SQL = "SELECT * FROM Irsaliye_Tbl WHERE Sofor LIKE '" + TxtSofor.Text.Replace('?', '%') + "' ORDER BY Tarih DESC";
            }

           DataTable dt = AKBclass.DBMudahale.TabloDoldur(SQL, pCollection);

           if (dt.Rows.Count == 0)
               MessageBox.Show("Kayıt Bulunamadı!", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else
               GridView1.DataSource = dt;

        }
        private void Irsaliyeler_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            this.MaximizeBox = false;
            GridDoldur();
            TxtIrsaliyeNo.Focus();
        }

        private void GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView1.Rows[e.RowIndex].Cells[1].Value != DBNull.Value)
            {
                Irs.IrsaliyeDoldurr(GridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Close();
            }
           
        }

        private void Irsaliyeler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtIrsaliyeNo.Text != "")
                    Bul(BulKriter.No);
                else if (TxtPlaka.Text != "")
                    Bul(BulKriter.Plaka);
                else if (TxtSofor.Text != "")
                    Bul(BulKriter.Sofor);
                
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            Bul(BulKriter.IkiTarih);
        }

      
    }
}
