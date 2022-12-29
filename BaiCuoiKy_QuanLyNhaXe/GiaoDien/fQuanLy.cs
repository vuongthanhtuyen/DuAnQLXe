using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void BtnXeRa_Click(object sender, EventArgs e)
        {
            fXeRa fXeRa = new fXeRa();
            fXeRa.ShowDialog();
        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void Open(object sender, EventArgs e)
        {
            fAdmin ad = new fAdmin();
            ad.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
