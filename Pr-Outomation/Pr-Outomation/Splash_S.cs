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
    public partial class Splash_S : Form
    {
        public Splash_S()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel2.Width += 3;
            if(panel2.Width >=700)
            {
                timer1.Stop();
                AnaMenu f2 = new AnaMenu();
                f2.Show();
                this.Hide();
            }
           
        }
    }
}
