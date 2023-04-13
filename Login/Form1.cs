using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {

        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-0V73418\\SQLEXPRESS;Initial Catalog=loginsc;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        int rn = 0, rn2 = 0, rn3 = 0;
        String koy;
        void secturykode()
        {
            Random secturrnd = new Random();
            rn = secturrnd.Next(1, 10);
            rn2 = secturrnd.Next(1, 10);
            rn3 = secturrnd.Next(1, 10);

            label3.Text = rn.ToString();
            label4.Text = rn2.ToString();
            label5.Text = rn3.ToString();

        



            label6.Text = rn.ToString() + rn2.ToString() + rn3.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secturykode();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }


 

        private void button1_Click(object sender, EventArgs e)
        {
            

            bağlantı.Open();
            SqlCommand command = new SqlCommand("Select * From LoginTester where kullaniciadi=@k1 and sifre=@s2", bağlantı);
            command.Parameters.AddWithValue("@k1", textBox1.Text);
            command.Parameters.AddWithValue("@s2", textBox2.Text);

            SqlDataReader dat = command.ExecuteReader();
            if (dat.Read())
            {
                if (label6.Text == textBox3.Text & label6.Text == textBox3.Text & label6.Text == textBox3.Text)
                {
                    MessageBox.Show("Login Başarılı","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    Tester form2 = new Tester();
                    form2.Show();
                    this.Hide();
                  //  MessageBox.Show("Test");
                }
                else
                {
                    MessageBox.Show("Güvenlik Kodu Yanlış","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            else if (textBox1.Text == "" & textBox2.Text == "")
            {

               

                    MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz");

              
                
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı yanlış.");
            }

            bağlantı.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
