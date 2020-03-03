using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        bool Login(string tenTaiKhoan, string matKhau)
        {
            return TaiKhoan_DAO.Instance.Login(tenTaiKhoan, matKhau);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbUserName.Text;
            string matKhau = txbPassWord.Text;

            if (Login(tenTaiKhoan, matKhau)==true)
            {
                TaiKhoan_DTO dangnhap = TaiKhoan_DAO.Instance.LayTaiKhoanBoiTenDangNhap(tenTaiKhoan);
                FrmQuanLyTaiKhoan f = new FrmQuanLyTaiKhoan(dangnhap);
                //f.ThanhToan += f_ThanhToan;
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
