using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_and_Object_Oriented_Programming_with_C__Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;

            s1 = int.Parse(txtsinav1.Text);

            s2 = int.Parse(txtsinav2.Text);

            s3 = int.Parse(txtsinav3.Text);

            ort = (s1 + s2 + s3) / 3;

            txtortalama.Text = ort.ToString(); //int bir değeri textboxa yazdıracaksak tostring kullanacağız.

            //ortalama ve durum textboxlarında enabled özelliğini false yaparsak yazma özelliğini kaldırıyoruz.

            if (ort >= 50)
            {
                durum = "Geçti";
                txtdurum.ForeColor = Color.Green;
                txtdurum.Text = durum;
            }
            else 
            {
                durum = "Kaldı";
                txtdurum.ForeColor= Color.Red;
                txtdurum.Text = durum;
            }
            //araçlarLA beraber dizi ve foreach döngüsü kullanımı
            string[] sehirler = { "Adana", "Ankara", "İstanbul", "Malatya" };
            txtadsoyad.Text = sehirler[1];
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7,8,9,10 };
            for (int i = 0;i <numbers.Length; i++)
            {
                listbox1.Items.Add(numbers[i]);
                listbox1.Items.Add("-------------");
            }
            //foreach (int i in numbers)
            //{
            //    listbox1.Items.Add(i);
            //}

           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtdurum.Text != "" && txtortalama.Text != "")
            {
                string adsoyad, ders, numara;
                adsoyad = txtadsoyad.Text;
                ders = cbders.Text;
                numara = maskedtxtnumara.Text;

                listbox1.Items.Add(adsoyad + " " + ders + " " + numara + " " + txtortalama.Text + " " + txtdurum.Text);
                MessageBox.Show("Kayıt başarılı! Liste içerisinde bilgilerinizi görüntüleyebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadsoyad.Clear();
            txtdurum.Clear();
            txtortalama.Clear();
            txtsinav1.Clear();
            txtsinav2.Clear();
            txtsinav3.Clear();
            maskedtxtnumara.Clear();
            cbders.SelectedIndex = -1;
            txtadsoyad.Focus(); //İmleci adsoyad textboxuna odakla.
            listbox1.Items.Clear();

        }

        private void btncizgi_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add("-------------------------------------------------------------------------------------------------");
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }

        private void koyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }

        private void açıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure += 1;
            if (sure >= 0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if (sure > 30 && sure <= 40)
            {
                panel2.BackColor = Color.Yellow;
               
            }
            if (sure > 40 && sure <= 70)
            {
                panel3.BackColor = Color.Green;
                panel2.BackColor = Color.Transparent;
                panel1.BackColor = Color.Transparent;
            }
            if(sure == 71)
            {
                sure = 0;
            }
        }
    }
}
