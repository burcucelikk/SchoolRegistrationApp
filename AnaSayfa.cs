using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRegistrationApp
{
    public partial class AnaSayfa : Form
    {
        Ogrenciler ogr;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ogr == null|| ogr.IsDisposed)
            {
                ogr = new Ogrenciler();
                ogr.MdiParent = this;
                ogr.Show();
            }
            else 
                ogr.BringToFront();

        }
    }
}
