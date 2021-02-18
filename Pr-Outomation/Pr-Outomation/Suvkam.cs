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
    public partial class Suvkam : Form
    {
        public Suvkam()
        {
            InitializeComponent();
        }
        Connect Connect = new Connect();
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void Griddol()

        {
            con = new SqlConnection(Connect.PrCon);
            da = new SqlDataAdapter("Select *From Suvkam", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Suvkam");
            dataGridView1.DataSource = ds.Tables["Suvkam"];
            con.Close();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            AnaMenu AN2 = new AnaMenu();
            AN2.Show();
            this.Hide();
        }

        private void Birimler_btn_Click(object sender, EventArgs e)
        {
            Birimler B2 = new Birimler();
            B2.Show();
            this.Hide();
        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {
           /* if (YazıcıTBox.Text == "" || comboBox1.Text == "")

            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }

            else
            {
           */
                cmd = new SqlCommand(Connect.PrCon);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Suvkam (Yazıcı,Model,Toner,Tarih) values (@Yazıcı,@Model,@Toner,@Tarih)";
                cmd.Parameters.AddWithValue("@Yazıcı", YazıcıTBox.Text);
                cmd.Parameters.AddWithValue("@Model", Toner_ModelTBox.Text);
                cmd.Parameters.AddWithValue("@Toner", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);

                int i = cmd.ExecuteNonQuery();

                if (i == 0)

                {
                    MessageBox.Show("Kayıt ekleme işlemi başarısız.Veritabanı Hatası!");
                }
                else if (i == 1)

                {
                    MessageBox.Show("Kayıt ekleme işlemi başarılı.");
                }

                con.Close();
                Griddol();
         // }
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(Connect.PrCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Suvkam SET Yazıcı=@Yazıcı,Model=@Model,Toner=@Toner,Tarih=@Tarih where Yazıcı=@Yazıcı";
            cmd.Parameters.AddWithValue("@Yazıcı", YazıcıTBox.Text);
            cmd.Parameters.AddWithValue("@Model", Toner_ModelTBox.Text);
            cmd.Parameters.AddWithValue("@Toner", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            int i = cmd.ExecuteNonQuery();

            if (i == 0)

            {
                MessageBox.Show("Kayıt güncelleme işlemi başarısız.Veritabanı Hatası!");
            }
            else if (i == 1)

            {
                MessageBox.Show("Kayıt güncelleme işlemi başarılı.");
            }
            con.Close();
            Griddol();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(Connect.PrCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [Suvkam] WHERE Yazıcı=@Yazıcı";
            cmd.Parameters.AddWithValue("@Yazıcı", dataGridView1.CurrentRow.Cells[0].Value);

            int i = cmd.ExecuteNonQuery();

            if (i == 0)

            {
                MessageBox.Show("Silme işlemi başarısız.Veritabanı Hatası!");
            }
            else if (i == 1)

            {
                MessageBox.Show("Silme işlemi başarılı.");
            }

            con.Close();
            Griddol();
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                      e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }

        private void Suvkam_Load(object sender, EventArgs e)
        {
            Griddol();
        }

        private void mSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hak2 = new Hakkında();
            hak2.Show();
        }
    }
}
