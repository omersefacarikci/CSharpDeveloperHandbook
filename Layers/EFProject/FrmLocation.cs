using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new { FullName = x.GuideName + " " + x.GuideSurname, x.GuideId }).ToList();
            cbRehber.DisplayMember = "GuideName";
            cbRehber.ValueMember = "GuideId";
            cbRehber.DataSource = values;
        }
        EFDbEntities db = new EFDbEntities();
        private void btnlist_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = txtcity.Text;
            location.LocationCountry = txtcountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight = txtdaynight.Text;
            location.GuideId = int.Parse(cbRehber.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme başarılı!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight = txtdaynight.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.City = txtcity.Text;
            updatedValue.Country = txtcountry.Text;
            updatedValue.GuideId = int.Parse(cbRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarılı!");

        }

        private void btnId_Click(object sender, EventArgs e)
        {

        }
    }
}
