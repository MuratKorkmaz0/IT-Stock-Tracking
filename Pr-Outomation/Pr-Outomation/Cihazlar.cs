using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Outomation
{
    public partial class Cihazlar : Form
    {
        public Cihazlar()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            AnaMenu f2 = new AnaMenu();
            f2.Show();
            this.Hide();
        }

        private void Birimler_btn_Click(object sender, EventArgs e)
        {
            Birimler b2 = new Birimler();
            b2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilg bi2 = new Bilg();
            bi2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazıcılar yaz2 = new Yazıcılar();
            yaz2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Servis se2 = new Servis();
            se2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DigerCihazlar di2 = new DigerCihazlar();
            di2.Show();
            this.Hide();
        }

        private void mSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hak2 = new Hakkında();
            hak2.Show();

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

            else if (result == DialogResult.No)

            {
                // Do nothing  
            }

            else

            {
                // Do something  
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ihlist iht2 = new Ihlist();
            iht2.Show();
            this.Hide();
        }
    }
}
