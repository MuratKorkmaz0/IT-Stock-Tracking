using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Outomation
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Birimler B2 = new Birimler();
            B2.Show();
            this.Hide();
                      
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Programı kapatmak istiyor musun?";
            string title = "Programı Kapat";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                // Do nothing  
            }
            else
            {
                // Do something  
            }
        }

        private void Yazıcılar_btn_Click(object sender, EventArgs e)
        {
            Cihazlar c2 = new Cihazlar();
            c2.Show();
            this.Hide();
        }

        private void Stok_btn_Click(object sender, EventArgs e)
        {
            Stok st2 = new Stok();
            st2.Show();
            this.Hide();
        }

        private void mSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hak2 = new Hakkında();
            hak2.Show();
        }

        private void İhtiyac_Click(object sender, EventArgs e)
        {
            Ihlist ihl2 = new Ihlist();
            ihl2.Show();
            this.Hide();
        }
    }
}
