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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        BindingSource DSTK = new BindingSource();
        private TaiKhoan_DTO dangNhap;
        public TaiKhoan_DTO DangNhap { get => dangNhap; set => dangNhap = value; }
        public FrmQuanLyTaiKhoan(TaiKhoan_DTO tk)
        {
            InitializeComponent();
            this.DangNhap = tk;
            load();
        }
        void load()
        {
            dtgvDSTaiKhoan.DataSource = DSTK;
            TestCapDoTaiKhoan();
            txtID.Enabled = false;
            loadDSTK();
            BindingTaiKhoan();
        }

        #region method
        void loadDSTK()
        {
            DSTK.DataSource = TaiKhoan_DAO.Instance.HienThiDanhSachTaiKhoan();
            dtgvDSTaiKhoan.Columns[4].HeaderText = "id";
            dtgvDSTaiKhoan.Columns[3].HeaderText = "Tên Tài Khoản";
            dtgvDSTaiKhoan.Columns[2].HeaderText = "Tên Hiển Thị";
            dtgvDSTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            dtgvDSTaiKhoan.Columns[0].HeaderText = "Cấp Độ Tài Khoản";
        }
        void TestCapDoTaiKhoan()
        {
            if (DangNhap.Id == 1)
            {
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnthem.Enabled = false;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }
        void BindingTaiKhoan()
        {
            txtID.DataBindings.Clear();
            txtTenTaiKhoan.DataBindings.Clear();
            txtTenHienThi.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            nmCapDoTaiKhoan.DataBindings.Clear();
            txtID.DataBindings.Add(new Binding("Text", dtgvDSTaiKhoan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvDSTaiKhoan.DataSource, "TenTaiKhoan", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dtgvDSTaiKhoan.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", dtgvDSTaiKhoan.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            nmCapDoTaiKhoan.DataBindings.Add(new Binding("Text", dtgvDSTaiKhoan.DataSource, "CapDoTaiKhoan", true, DataSourceUpdateMode.Never));


        }

        bool KiemTraLoi()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Mời bạn điền Tài khoản");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtTenHienThi.Text))
            {
                MessageBox.Show("Mời bạn điền tên hiển thị");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mời bạn điền mật khẩu");
                isValid = false;
            }
            

            return isValid;
        }

        #endregion
        #region EventHandle
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý muốn Thêm tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string tentaikhoan = txtTenTaiKhoan.Text;
                string tenhienthi = txtTenHienThi.Text;
                string matkhau = txtMatKhau.Text;
                int capdotaikhoan = Convert.ToInt32(nmCapDoTaiKhoan.Text);

                if (KiemTraLoi() == true)
                {
                    if (TaiKhoan_DAO.Instance.KiemTraTenTaiKhoanTonTai(Convert.ToInt32(txtID.Text), txtTenTaiKhoan.Text) == false)
                    {
                        if (TaiKhoan_DAO.Instance.ThemTaiKhoan(tentaikhoan, tenhienthi, matkhau, capdotaikhoan))
                        {
                            MessageBox.Show("Thêm tài khoản thành công");
                            loadDSTK();
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản " + txtTenTaiKhoan.Text + "đã tồn tại trong hệ thống");
                    }
                }

                //if ( TaiKhoan_DAO.Instance.ThemTaiKhoan(tentaikhoan, tenhienthi, matkhau, capdotaikhoan))
                //{
                //    MessageBox.Show("Thêm tài khoản thành công");
                //    loadDSTK();
                //}
                //else
                //{
                //    MessageBox.Show("Thêm tài khoản không thành công");
                //}
                //if (TaiKhoan_DAO.Instance.KiemTraTenTaiKhoanTonTai(Convert.ToInt32(txtID.Text), txtTenTaiKhoan.Text) == true)
                //{
                //    MessageBox.Show("Tài khoản " + txtTenTaiKhoan.Text + "đã tồn tại trong hệ thống");
                    
                //}
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý muốn Sửa tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtID.Text);
                string tentaikhoan = txtTenTaiKhoan.Text;
                string tenhienthi = txtTenHienThi.Text;
                string matkhau = txtMatKhau.Text;
                int capdotaikhoan = Convert.ToInt32(nmCapDoTaiKhoan.Text);

                if (KiemTraLoi() == true && TaiKhoan_DAO.Instance.SuaTaiKhoan(tenhienthi,capdotaikhoan,tentaikhoan,matkhau,id))
                {
                    MessageBox.Show("Sửa tài khoản thành công");
                    loadDSTK();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản không thành công");
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý xóa chức vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(txtID.Text);

                if (KiemTraLoi() == true && TaiKhoan_DAO.Instance.XoaTaiKhoan(id))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    loadDSTK();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công");
                }

            }
        }


        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
                if (string.IsNullOrEmpty(txtNoiDungTimKiem.Text))
                {
                    MessageBox.Show("Mời bạn nhập tên tài khoản muốn tìm");
                    return;
                }
                string tentaikhoantimkiem = txtNoiDungTimKiem.Text;

                dtgvDSTaiKhoan.DataSource = TaiKhoan_DAO.Instance.TimKiemTheoTenTaiKhoan(tentaikhoantimkiem);
                loadDSTK();
            
        }
    }
}
