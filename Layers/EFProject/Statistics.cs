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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        EFDbEntities db = new EFDbEntities();
        private void Statistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();

            lblCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

            lblGuideCount.Text = db.Location.Count().ToString();

            lblAvgCapacity.Text = db.Location.Average(x=>x.Capacity).ToString();

            lblAvgLocationPrice.Text = db.Location.Average(x=>x.Price).ToString() + " TL";

            int lastCountry = db.Location.Max(x => x.LocationId);

            lblLastCountry.Text = db.Location.where(x => x.LocationId == lastCountry).Select(y => y.Country).FirstOrDefault();
            
            lblCappadociaLocationCapacity.Text = db.Location.Where(x=> x.City == "Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();
           
            lblturkiyeAvgCapacity.Text = db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

            int RomeGuideId = db.Location.where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Location.Where(x=>x.GuideId == RomeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var max = db.Location.Max(x => x.Capacity);
            lblMax.Text = db.Location.where(x => x.Capacity == max).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblmaxprice.Text = db.Location.where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideid = db.Guide.where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblayse.Text = db.Location.where(x => x.GuideId == guideid).Count().ToString();
        }
    }
}
