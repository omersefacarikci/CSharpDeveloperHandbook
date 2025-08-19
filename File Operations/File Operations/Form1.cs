using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            //Klasörleri gösterir , belgeleri göstermez.
            folderBrowserDialog1.ShowDialog(); // Dialog Penceresini göster.
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //Belgeler gelecek.
            label2.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        string belgeyolu, belgeadi;

        private void btnolustur_Click(object sender, EventArgs e)
        {
            belgeadi = txtbelgeadi.Text;
            StreamWriter streamWriter = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            MessageBox.Show("Belge başarıyla oluşturuldu.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnoku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string satir = streamReader.ReadLine();
                while(satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = streamReader.ReadLine();
                }
            }
        }
        public string kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = kullanici;
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
