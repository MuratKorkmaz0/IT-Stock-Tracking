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
    public partial class Birimler : Form
    {
        public Birimler()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            AnaMenu f2 = new AnaMenu();
            f2.Show();
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

            else if (result == DialogResult.No)

            {
                // Do nothing  
            }

            else

            {
                // Do something  
            }
        }

        private void Bilgi_is_btn_Click(object sender, EventArgs e)
        {
            Bilgi_islem b2 = new Bilgi_islem ();
            b2.Show();
            this.Hide();
        }

        private void Zabıta_btn_Click(object sender, EventArgs e)
        {
            Zabıta za2 = new Zabıta();
            za2.Show();
            this.Hide();
        }

        private void Hukuk_is_btn_Click(object sender, EventArgs e)
        {
            Hukuk_isleri huk2 = new Hukuk_isleri();
            huk2.Show();
            this.Hide();
        }

        private void Cevre_koru_btn_Click(object sender, EventArgs e)
        {
            Cevre_k ce2 = new Cevre_k();
            ce2.Show();
            this.Hide();
        }

        private void Yazı_is_btn_Click(object sender, EventArgs e)
        {
            Yazı_isleri yaz2 = new Yazı_isleri();
            yaz2.Show();
            this.Hide();
        }

        private void park_btn_Click(object sender, EventArgs e)
        {
            Park_b pa2 = new Park_b();
            pa2.Show();
            this.Hide();
        }

        private void Insan_kay_btn_Click(object sender, EventArgs e)
        {
            Insankay in2 = new Insankay();
            in2.Show();
            this.Hide();

        }

        private void Mali_hiz_btn_Click(object sender, EventArgs e)
        {
            Malhizmü ml2 = new Malhizmü();
            ml2.Show();
            this.Hide();
        }

        private void imar_btn_Click(object sender, EventArgs e)
        {
            Imşemü Im2 = new Imşemü();
            Im2.Show();
            this.Hide();
        }

        private void Fen_is_btn_Click(object sender, EventArgs e)
        {
            Feişm fe2 = new Feişm();
            fe2.Show();
            this.Hide();
        }

        private void Kultur_sosyal_btn_Click(object sender, EventArgs e)
        {
            Külsosim kü2 = new Külsosim();
            kü2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Itfam it2 = new Itfam();
            it2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basyhakil ba2 = new Basyhakil();
            ba2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Suvkam su2 = new Suvkam();
            su2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Temişm tem2 = new Temişm();
            tem2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Deshim des2 = new Deshim();
            des2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yapkmü ya2 = new Yapkmü();
            ya2.Show();
            this.Hide();
        }

        private void Cihazlarbtn_Click(object sender, EventArgs e)
        {
            Cihazlar ci2 = new Cihazlar();
            ci2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stok st2 = new Stok();
            st2.Show();
            this.Hide();
        }
    }
}
