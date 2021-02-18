using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Outomation
 
{
    public partial class Bilgi_islem : Form
    {
        
        public Bilgi_islem()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void Griddoldur()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=TavBel;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Bilgi_islem", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Bilgi_islem");
            dataGridView1.DataSource = ds.Tables["Bilgi_islem"];
            con.Close();
        }

        //guncelle butonu
        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Bilgi_islem SET Yazıcı=@Yazıcı,Model=@Model,Toner=@Toner,Tarih=@Tarih where Yazıcı=@Yazıcı";
            cmd.Parameters.AddWithValue("@Yazıcı", YazıcıTBox.Text);
            cmd.Parameters.AddWithValue("@Model", Toner_ModelTBox.Text);
            cmd.Parameters.AddWithValue("@Toner", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Griddoldur();
        }
        //birimler butonu
        private void Birimler_btn_Click(object sender, EventArgs e)
        {
            Birimler B2 = new Birimler();
            B2.Show();
            this.Hide();
        }
        //ana menu butonu
        private void Homebtn_Click(object sender, EventArgs e)
        {
            AnaMenu AN2 = new AnaMenu();
            AN2.Show();
            this.Hide();
        }
        //strip menü cıkıs butonu
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
        //ekle butonu
        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            if (YazıcıTBox.Text == "" || YazıcıTBox.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }
            else
            {
           
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Bilgi_islem (Yazıcı,Model,Toner,Tarih) values (@Yazıcı,@Model,@Toner,@Tarih);";
            cmd.Parameters.AddWithValue("@Yazıcı", YazıcıTBox.Text);
            cmd.Parameters.AddWithValue("@Model", Toner_ModelTBox.Text);
            cmd.Parameters.AddWithValue("@Toner", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
                int i = cmd.ExecuteNonQuery();

            if (i==0)
            {
                MessageBox.Show("Kayıt Başarısız.");
            }
            else if (i ==1)
            {
                MessageBox.Show("Kayıt Başarılı.");
            }

            con.Close();
            Griddoldur();
            }
        }

        //sil butonu
        private void sil_btn_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [Bilgi_islem] WHERE Yazıcı=@Yazıcı";
            cmd.Parameters.AddWithValue("@Yazıcı", dataGridView1.CurrentRow.Cells[0].Value);
   
            int i = cmd.ExecuteNonQuery();

            if (i == 0)
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
            else if (i == 1)
            {
                MessageBox.Show("Silme işlemi başarılı.");
            }
            con.Close();
            Griddoldur();

        }

    private void Bilgi_islem_Load(object sender, EventArgs e)
    {
        Griddoldur();
        
    }   
   }
}
