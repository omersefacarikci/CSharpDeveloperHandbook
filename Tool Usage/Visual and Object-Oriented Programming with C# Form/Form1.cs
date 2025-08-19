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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Combobox dropdowsstyle özelliği dropdownlist olursa klavyeden veri girişi engellenir.
            label9.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Javascript");
            listBox1.Items.Add("Swift");
            listBox1.Items.Add("C++");
            comboBox1.Items.Add("Rize");
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
