using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly ICategoryService _categoryService;

        public Form1(ICategoryService categoryService)
        {
            _categoryService = new CategoryManager(new ICategoryDal());
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.GetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBox1.Text;
            category.CategoryStatus = true;
            _categoryService.Insert(category);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var values = _categoryService.GetById(id);
            _categoryService.Delete(values);
            MessageBox.Show("Silme işlemi başarılı!");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var values = _categoryService.GetById(id);
            dataGridView1.DataSource =values;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CategoryAttribute category = new Category();
            int updateID = int.Parse(textBox1.Text);
            var valuess = _categoryService.GetById(updateID);
            updateID.CategoryName = textBox2.Text;
            updateID.CategoryStatus = true;
            _categoryService.Update(valuess);
        }
    }
}
