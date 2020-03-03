using QuanLyNhanSu.DAO;
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
    public partial class FrmChucVu : Form
    {
        BindingSource DSCV = new BindingSource(); //DSCV : danh sách chức vụ
        public FrmChucVu()
        {
            InitializeComponent();
            load();
            dtgvDanhSachChucVu.SelectionChanged += DtgvDanhSachChucVu_SelectionChanged;
        }
        private void DtgvDanhSachChucVu_SelectionChanged(object sender, EventArgs e)
        {
            kiemTraTrangThaiEnabled();
        }

        private void kiemTraTrangThaiEnabled()
        {
            if (dtgvDanhSachChucVu.SelectedRows.Count > 0)
            {
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        void load()
        {
            dtgvDanhSachChucVu.DataSource = DSCV;
            loadDSCV();
            BindingChucVu();
        }

       
        #region Method
        void loadDSCV()
        {
            DSCV.DataSource = ChucVu_DAO.Instance.HienThiDanhSachChucVu();
            dtgvDanhSachChucVu.Columns[0].HeaderText = "Mã Chức Vụ";
            dtgvDanhSachChucVu.Columns[1].HeaderText = "Tên Chức Vụ";
           

        }
        // kiểm tra dữ liệu nhập vào
        //trả về true or false
        bool KiemTraLoi()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtMaChucVu.Text))
            {
                MessageBox.Show("Mời bạn điền mã chức vụ");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtTenChucVu.Text))
            {
                MessageBox.Show("Mời bạn điền tên chức vụ");
                isValid = false;
            }

            // Check
            if (ChucVu_DAO.Instance.kiemTraMaChucVuTrungNhau(txtMaChucVu.Text) == true)
            {
                MessageBox.Show("Mã Chức Vụ " + txtMaChucVu.Text + "đã tồn tại trong hệ thống");
                isValid = false;

            }
            return isValid;
        }
        //clear lai status
        void Clear()
        {
            txtTenChucVu.Text = "";
            txtMaChucVu.Text = "";
            txtMaChucVu.Enabled = true;
            dtgvDanhSachChucVu.Rows[0].Selected = false;
            btnthem.Enabled = true;
            if (dtgvDanhSachChucVu.SelectedRows.Count > 0)
            {
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }

        }
        void BindingChucVu()
        {
            txtMaChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add(new Binding("Text", dtgvDanhSachChucVu.DataSource, "MaChucVu", true, DataSourceUpdateMode.Never)); //"MaChucVu" tên cột dữ liệu k được phép sai
            txtTenChucVu.DataBindings.Add(new Binding("Text", dtgvDanhSachChucVu.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
            btnthem.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtMaChucVu.Enabled = false;

        }
        
        #endregion

        #region Event Handle
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có đồng ý muốn Thêm dịch vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string machucvu = txtMaChucVu.Text;
                string tenchucvu = txtTenChucVu.Text;
                   
                if (KiemTraLoi() == true && ChucVu_DAO.Instance.ThemChucvu(machucvu,tenchucvu))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    loadDSCV();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công");
                }
                Clear();
            }
        }
            
        

        private void btnsua_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có đồng ý sửa chức vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                    

                string machucvu = txtMaChucVu.Text;
                string tenchucvu = txtTenChucVu.Text;

                if ( ChucVu_DAO.Instance.SuaChucVu(machucvu, tenchucvu))
                {
                    MessageBox.Show("Sửa Chức vụ thành công");
                    loadDSCV();
                }
                else
                {
                    MessageBox.Show("Sửa Chức vụ không thành công");
                }
                Clear();
            }
        }
           
        
        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có đồng ý xóa chức vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                string machucvu = txtMaChucVu.Text;
                   
                if (ChucVu_DAO.Instance.XoaChucvu(machucvu))
                {
                    MessageBox.Show("Xóa Chức vụ thành công");
                    loadDSCV();

                }
                else
                {
                    MessageBox.Show("Xóa Chức vụ không thành công");
                }
                Clear();
            }
         }
            
    

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDungTimKiem.Text))
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ muốn tìm");
                return;
            }
            string tenchucvu = txtNoiDungTimKiem.Text;

            dtgvDanhSachChucVu.DataSource = ChucVu_DAO.Instance.TimKiemTheoTenChucVu(tenchucvu);
            loadDSCV();
        }
        private void dtgvDanhSachChucVu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindingChucVu();
        }


        #endregion

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
           load();
            if (dtgvDanhSachChucVu.RowCount > 0)
            {
                dtgvDanhSachChucVu.Rows[0].Selected = false;
            }

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void dtgvDanhSachChucVu_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            txtMaChucVu.Enabled = true;
        }
    }
}
