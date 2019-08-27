using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ambar
{
    public partial class AnaForm : Form
    {
        public int? OpID;
        public AnaForm()
        {
            InitializeComponent();

        }
        public void LoginOldum(int? opid)
        {
            OpID = opid;
            StatusBarLabel.Text = "Aktif Operatör : " + AKBclass.DBMudahale.TekDegerDondur("SELECT Ad FROM Operator_Tbl WHERE ID = " + OpID.ToString());
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            if (!OpID.HasValue)
            {
                LoginFormAc();
            }

            this.WindowState = FormWindowState.Maximized;

        }




        void LoginFormAc()
        {
            foreach (Form item in this.MdiChildren)
	        {
                if (item.Name == "Login")
                {
                    
                    item.WindowState = FormWindowState.Maximized;
                    item.Focus();
                    return;
                }
	        } 

            Login L = new Login(this);
            L.MdiParent = this;
            L.WindowState = FormWindowState.Maximized;
            L.Show();
        }
        void MusteriFormAc()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "Musteri")
                {

                    item.WindowState = FormWindowState.Maximized;
                    item.Focus();
                    return;
                }
            }

            Musteri L = new Musteri(this);
            L.MdiParent = this;
            L.WindowState = FormWindowState.Maximized;
            L.Show();
        }
        

        private void UstMenuÇikis_Click(object sender, EventArgs e)
        {
            LoginFormAc();

            
        }

        private void UstMenuMusteri_Click(object sender, EventArgs e)
        {
            MusteriFormAc();


          
        }
        void IrsaliyeFormAc()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "Irsaliye")
                {

                    item.WindowState = FormWindowState.Maximized;
                    item.Focus();
                    return;
                }
            }

            Irsaliye L = new Irsaliye(this);
            L.MdiParent = this;
            L.WindowState = FormWindowState.Maximized;
            L.Show();
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (OpID != null)
            {
                switch (e.KeyCode)
                { 
                    case Keys.F5: // müşteri formu
                        MusteriFormAc();
                        break;
                    case Keys.F6:
                        IrsaliyeFormAc(); // Irsaliye formu
                        break;
                    case Keys.F12: // çıkış
                        LoginFormAc();
                        break;
                
                
                }
            }
        }

        private void UstMenuIrsaliye_Click(object sender, EventArgs e)
        {
            IrsaliyeFormAc();
        }

    }
}
