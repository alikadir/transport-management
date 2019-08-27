using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ambar
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        Irsaliye Irs;
        public Musteriler(Irsaliye x)
        {
            Irs = x;
            InitializeComponent();
        }
        enum doldurma
        {
            Full = 1,
            No = 2,
            Unvan = 3,
            Aciklama = 4
        }
        void GridDoldur(doldurma x)
        {
            string SQL = "";
            if (x == doldurma.Full)
            {
                SQL = "SELECT * FROM Musteri_Tbl ORDER BY Unvan ";

            
            }
            else if (x == doldurma.No)
            {
                SQL = "SELECT * FROM Musteri_Tbl WHERE ID = " + TxtMusteriNo.Text + "ORDER BY Unvan ";
            }
            else if (x == doldurma.Unvan)
            {
                SQL = "SELECT * FROM Musteri_Tbl WHERE Unvan LIKE '" + TxtUnvan.Text.Replace('?', '%') + "' ORDER BY Unvan ";
            }
            else if (x == doldurma.Aciklama)
            {
                SQL = "SELECT * FROM Musteri_Tbl WHERE Aciklama LIKE '" + TxtAciklama.Text.Replace('?', '%') + "' ORDER BY Unvan ";
            }



            DataTable dt = AKBclass.DBMudahale.TabloDoldur(SQL);

            if (dt.Rows.Count != 0)
            {
                GridView1.AutoGenerateColumns = false;
                GridView1.ScrollBars = ScrollBars.Vertical;

                GridView1.DataSource = dt;
            }
            else
                MessageBox.Show("Kayıt Bulunamadı!", "Tekrar arayın", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            GridDoldur(doldurma.Full);
            TxtMusteriNo.Focus();
        }

        private void GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Irs.MusteriSelect(GridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            this.Close();
        }

        private void Musteriler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TxtMusteriNo.Text))
                    GridDoldur(doldurma.No);
                else if (!string.IsNullOrEmpty(TxtUnvan.Text))
                    GridDoldur(doldurma.Unvan);
                else if (!string.IsNullOrEmpty(TxtAciklama.Text))
                    GridDoldur(doldurma.Aciklama);
            }
        }
    }
}
