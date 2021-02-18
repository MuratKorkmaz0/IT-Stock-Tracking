namespace Pr_Outomation
{
    partial class Ihlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ihlist));
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Pr_Outomation.TavBelDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sil_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.Açıklama = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Marka = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSoftToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // mSoftToolStripMenuItem
            // 
            this.mSoftToolStripMenuItem.Name = "mSoftToolStripMenuItem";
            this.mSoftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mSoftToolStripMenuItem.Text = "M-Soft";
            this.mSoftToolStripMenuItem.Click += new System.EventHandler(this.mSoftToolStripMenuItem_Click);
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.seçeneklerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(138, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 125;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(278, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Cihaz Model Giriniz :";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(596, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "İşlem Tarihi :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pr_Outomation.Properties.Resources.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.Transparent;
            this.Homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Homebtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Homebtn.Image = global::Pr_Outomation.Properties.Resources.icons8_smart_home_shield_20;
            this.Homebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Homebtn.Location = new System.Drawing.Point(0, 107);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(135, 50);
            this.Homebtn.TabIndex = 16;
            this.Homebtn.Text = "Ana Menü";
            this.Homebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ekle_btn.BackColor = System.Drawing.Color.Transparent;
            this.Ekle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ekle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Ekle_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_insert_25;
            this.Ekle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ekle_btn.Location = new System.Drawing.Point(0, 280);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(135, 50);
            this.Ekle_btn.TabIndex = 1;
            this.Ekle_btn.Text = "Ekle";
            this.Ekle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ekle_btn.UseVisualStyleBackColor = false;
            this.Ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guncelle_btn.BackColor = System.Drawing.Color.Transparent;
            this.guncelle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.guncelle_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_update_25;
            this.guncelle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guncelle_btn.Location = new System.Drawing.Point(0, 333);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(135, 50);
            this.guncelle_btn.TabIndex = 3;
            this.guncelle_btn.Text = "Güncelle";
            this.guncelle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(423, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Açıklama Giriniz :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(597, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // sil_btn
            // 
            this.sil_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sil_btn.BackColor = System.Drawing.Color.Transparent;
            this.sil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sil_btn.ForeColor = System.Drawing.Color.Transparent;
            this.sil_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_clear_symbol_25;
            this.sil_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil_btn.Location = new System.Drawing.Point(0, 386);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(135, 50);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "Sil";
            this.sil_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 450);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(138, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Cihaz Marka Giriniz :";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(281, 42);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(117, 20);
            this.Model.TabIndex = 122;
            // 
            // Açıklama
            // 
            this.Açıklama.Location = new System.Drawing.Point(426, 42);
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.Size = new System.Drawing.Size(152, 20);
            this.Açıklama.TabIndex = 119;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Controls.Add(this.Ekle_btn);
            this.panel1.Controls.Add(this.guncelle_btn);
            this.panel1.Controls.Add(this.sil_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 450);
            this.panel1.TabIndex = 114;
            // 
            // Marka
            // 
            this.Marka.Location = new System.Drawing.Point(141, 42);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(114, 20);
            this.Marka.TabIndex = 123;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(141, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 342);
            this.dataGridView1.TabIndex = 120;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Ihlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__2_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Açıklama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ihlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İhtiyaç Listesi";
            this.Load += new System.EventHandler(this.Ihlist_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private TavBelDataSet database1DataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Açıklama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}