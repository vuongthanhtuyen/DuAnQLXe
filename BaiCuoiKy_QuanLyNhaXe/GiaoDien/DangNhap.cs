namespace GiaoDien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            fQuanLy fQuanLy = new fQuanLy();
            this.Hide();
            fQuanLy.ShowDialog();
            this.Show();

        }
    }
}