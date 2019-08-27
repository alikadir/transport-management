namespace Ambar
{
    partial class AnaForm
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UstMenuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.UstMenuÇikis = new System.Windows.Forms.ToolStripMenuItem();
            this.UstMenuIrsaliye = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 618);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(939, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(139, 17);
            this.StatusBarLabel.Text = "Çinikent Nakliyat Ambarı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UstMenuIrsaliye,
            this.UstMenuMusteri,
            this.UstMenuÇikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UstMenuMusteri
            // 
            this.UstMenuMusteri.Name = "UstMenuMusteri";
            this.UstMenuMusteri.Size = new System.Drawing.Size(82, 20);
            this.UstMenuMusteri.Text = "Müşteri (F5)";
            this.UstMenuMusteri.Click += new System.EventHandler(this.UstMenuMusteri_Click);
            // 
            // UstMenuÇikis
            // 
            this.UstMenuÇikis.Name = "UstMenuÇikis";
            this.UstMenuÇikis.Size = new System.Drawing.Size(73, 20);
            this.UstMenuÇikis.Text = "Çıkış (F12)";
            this.UstMenuÇikis.Click += new System.EventHandler(this.UstMenuÇikis_Click);
            // 
            // UstMenuIrsaliye
            // 
            this.UstMenuIrsaliye.Name = "UstMenuIrsaliye";
            this.UstMenuIrsaliye.Size = new System.Drawing.Size(78, 20);
            this.UstMenuIrsaliye.Text = "Irsaliye (F6)";
            this.UstMenuIrsaliye.Click += new System.EventHandler(this.UstMenuIrsaliye_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 640);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Çinikent Nakliyat Ambarı";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UstMenuÇikis;
        private System.Windows.Forms.ToolStripMenuItem UstMenuMusteri;
        private System.Windows.Forms.ToolStripMenuItem UstMenuIrsaliye;
    }
}