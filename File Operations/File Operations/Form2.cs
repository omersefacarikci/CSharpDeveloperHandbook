using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Operations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        void kodolustur()
        {
            Random random = new Random();
            int sayi = random.Next(10000, 100000);
            lbldogrulama.Text = sayi.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            kodolustur();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "admin" && txtsifre.Text == "1234" && txtkod.Text == lbldogrulama.Text)
            {
                Form1 form = new Form1();
                form.kullanici = txtkullaniciadi.Text;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız. Tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
