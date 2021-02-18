namespace Pr_Outomation
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.İhtiyac = new System.Windows.Forms.Button();
            this.Birimler_btn = new System.Windows.Forms.Button();
            this.Stok_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Yazıcılar_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.seçeneklerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSoftToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pr_Outomation.Properties.Resources.New_Project;
            this.pictureBox1.Location = new System.Drawing.Point(101, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.panel1.Controls.Add(this.İhtiyac);
            this.panel1.Controls.Add(this.Birimler_btn);
            this.panel1.Controls.Add(this.Stok_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Yazıcılar_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 400);
            this.panel1.TabIndex = 2;
            // 
            // İhtiyac
            // 
            this.İhtiyac.BackColor = System.Drawing.Color.Transparent;
            this.İhtiyac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.İhtiyac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.İhtiyac.ForeColor = System.Drawing.Color.Transparent;
            this.İhtiyac.Image = global::Pr_Outomation.Properties.Resources.icons8_add_list_30;
            this.İhtiyac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.İhtiyac.Location = new System.Drawing.Point(-1, 314);
            this.İhtiyac.Name = "İhtiyac";
            this.İhtiyac.Size = new System.Drawing.Size(174, 52);
            this.İhtiyac.TabIndex = 4;
            this.İhtiyac.Text = "İhtiyaç Listesi";
            this.İhtiyac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.İhtiyac.UseVisualStyleBackColor = false;
            this.İhtiyac.Click += new System.EventHandler(this.İhtiyac_Click);
            // 
            // Birimler_btn
            // 
            this.Birimler_btn.BackColor = System.Drawing.Color.Transparent;
            this.Birimler_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Birimler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Birimler_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Birimler_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_unit_32;
            this.Birimler_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Birimler_btn.Location = new System.Drawing.Point(0, 129);
            this.Birimler_btn.Name = "Birimler_btn";
            this.Birimler_btn.Size = new System.Drawing.Size(174, 56);
            this.Birimler_btn.TabIndex = 0;
            this.Birimler_btn.Text = "Birimler";
            this.Birimler_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Birimler_btn.UseVisualStyleBackColor = false;
            this.Birimler_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stok_btn
            // 
            this.Stok_btn.BackColor = System.Drawing.Color.Transparent;
            this.Stok_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stok_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Stok_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_sell_stock_30;
            this.Stok_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Stok_btn.Location = new System.Drawing.Point(0, 254);
            this.Stok_btn.Name = "Stok_btn";
            this.Stok_btn.Size = new System.Drawing.Size(174, 52);
            this.Stok_btn.TabIndex = 2;
            this.Stok_btn.Text = "Stok";
            this.Stok_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stok_btn.UseVisualStyleBackColor = false;
            this.Stok_btn.Click += new System.EventHandler(this.Stok_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pr_Outomation.Properties.Resources.logo__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Yazıcılar_btn
            // 
            this.Yazıcılar_btn.BackColor = System.Drawing.Color.Transparent;
            this.Yazıcılar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Yazıcılar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yazıcılar_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Yazıcılar_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_shopping_basket_30;
            this.Yazıcılar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Yazıcılar_btn.Location = new System.Drawing.Point(0, 193);
            this.Yazıcılar_btn.Name = "Yazıcılar_btn";
            this.Yazıcılar_btn.Size = new System.Drawing.Size(174, 53);
            this.Yazıcılar_btn.TabIndex = 1;
            this.Yazıcılar_btn.Text = "Cihazlar";
            this.Yazıcılar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Yazıcılar_btn.UseVisualStyleBackColor = false;
            this.Yazıcılar_btn.Click += new System.EventHandler(this.Yazıcılar_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Pr_Outomation.Properties.Resources.Version_1_0_0_;
            this.pictureBox3.Location = new System.Drawing.Point(736, 404);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 12);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // mSoftToolStripMenuItem
            // 
            this.mSoftToolStripMenuItem.Name = "mSoftToolStripMenuItem";
            this.mSoftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mSoftToolStripMenuItem.Text = "M-Soft";
            this.mSoftToolStripMenuItem.Click += new System.EventHandler(this.mSoftToolStripMenuItem_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__2_;
            this.ClientSize = new System.Drawing.Size(802, 424);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(16, 398);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Birimler_btn;
        private System.Windows.Forms.Button Stok_btn;
        private System.Windows.Forms.Button Yazıcılar_btn;
        private System.Windows.Forms.Button İhtiyac;
        private System.Windows.Forms.ToolStripMenuItem mSoftToolStripMenuItem;
    }
}