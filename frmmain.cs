using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutpro
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btnOduncİs_Click(object sender, EventArgs e)
        {

        }

        private void btnKitapTur_Click(object sender, EventArgs e)
        {

        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            frmOgrenciler frmOgrenciler = new frmOgrenciler();
            frmOgrenciler.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Everaldo_Desktoon_Library;
            this.Text = "Okul Kütüphane Programı";

        }
    }
}
