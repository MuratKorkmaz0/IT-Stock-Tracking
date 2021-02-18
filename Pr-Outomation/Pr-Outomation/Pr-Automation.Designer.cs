namespace Pr_Outomation
{
    partial class Bilgi_islem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi_islem));
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Birimler_btn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YazıcıTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Toner_ModelTBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new Pr_Outomation.TavBelDataSet();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ekle_btn.BackColor = System.Drawing.Color.Transparent;
            this.Ekle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ekle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Ekle_btn.Image = global::Pr_Outomation.Properties.Resources.New_Project__1___1_;
            this.Ekle_btn.Location = new System.Drawing.Point(0, 293);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(128, 38);
            this.Ekle_btn.TabIndex = 1;
            this.Ekle_btn.Text = "Ekle";
            this.Ekle_btn.UseVisualStyleBackColor = false;
            this.Ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sil_btn.BackColor = System.Drawing.Color.Transparent;
            this.sil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sil_btn.ForeColor = System.Drawing.Color.Transparent;
            this.sil_btn.Image = global::Pr_Outomation.Properties.Resources.New_Project__1___1_;
            this.sil_btn.Location = new System.Drawing.Point(0, 335);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(128, 38);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guncelle_btn.BackColor = System.Drawing.Color.Transparent;
            this.guncelle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.guncelle_btn.Image = global::Pr_Outomation.Properties.Resources.New_Project__1___1_;
            this.guncelle_btn.Location = new System.Drawing.Point(0, 377);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(128, 38);
            this.guncelle_btn.TabIndex = 3;
            this.guncelle_btn.Text = "Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.panel1.Controls.Add(this.Birimler_btn);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Controls.Add(this.Ekle_btn);
            this.panel1.Controls.Add(this.guncelle_btn);
            this.panel1.Controls.Add(this.sil_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 450);
            this.panel1.TabIndex = 4;
            // 
            // Birimler_btn
            // 
            this.Birimler_btn.BackColor = System.Drawing.Color.Transparent;
            this.Birimler_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Birimler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Birimler_btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Birimler_btn.Image = global::Pr_Outomation.Properties.Resources.icons8_unit_32;
            this.Birimler_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Birimler_btn.Location = new System.Drawing.Point(0, 54);
            this.Birimler_btn.Name = "Birimler_btn";
            this.Birimler_btn.Size = new System.Drawing.Size(128, 50);
            this.Birimler_btn.TabIndex = 17;
            this.Birimler_btn.Text = "Birimler";
            this.Birimler_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Birimler_btn.UseVisualStyleBackColor = false;
            this.Birimler_btn.Click += new System.EventHandler(this.Birimler_btn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.Transparent;
            this.Homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Homebtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Homebtn.Image = global::Pr_Outomation.Properties.Resources.icons8_smart_home_shield_20;
            this.Homebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Homebtn.Location = new System.Drawing.Point(0, 1);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(128, 46);
            this.Homebtn.TabIndex = 16;
            this.Homebtn.Text = "Ana Menü";
            this.Homebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__3_;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(131, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
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
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSoftToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // mSoftToolStripMenuItem
            // 
            this.mSoftToolStripMenuItem.Name = "mSoftToolStripMenuItem";
            this.mSoftToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.mSoftToolStripMenuItem.Text = "M-Soft";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // YazıcıTBox
            // 
            this.YazıcıTBox.Location = new System.Drawing.Point(137, 48);
            this.YazıcıTBox.Name = "YazıcıTBox";
            this.YazıcıTBox.Size = new System.Drawing.Size(119, 20);
            this.YazıcıTBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(134, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Yazıcı Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(446, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Toner Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(587, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Verilme Tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Renkli",
            "Siyah-Beyaz"});
            this.comboBox1.Location = new System.Drawing.Point(449, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Toner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(286, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Toner Model :";
            // 
            // Toner_ModelTBox
            // 
            this.Toner_ModelTBox.Location = new System.Drawing.Point(289, 49);
            this.Toner_ModelTBox.Name = "Toner_ModelTBox";
            this.Toner_ModelTBox.Size = new System.Drawing.Size(125, 20);
            this.Toner_ModelTBox.TabIndex = 26;
            this.Toner_ModelTBox.Validated += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(137, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 342);
            this.dataGridView1.TabIndex = 27;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bilgi_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pr_Outomation.Properties.Resources.New_Project__2_;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Toner_ModelTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YazıcıTBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bilgi_islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pr-Automation";
            this.Load += new System.EventHandler(this.Bilgi_islem_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Button Birimler_btn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.TextBox YazıcıTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Toner_ModelTBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TavBelDataSet database1DataSet1;
    }
}