using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
    public class TaiKhoan_DTO
    {
        public TaiKhoan_DTO(int id, string TenTaiKhoan, string TenHienThi, int capDoTaiKhoan, string MatKhau = null)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.TenHienThi = TenHienThi;
            this.MatKhau = MatKhau;
            
            this.Id = id;
            this.CapDoTaiKhoan = capDoTaiKhoan;
        }
        public TaiKhoan_DTO(DataRow row)
        {
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.TenHienThi = row["TenHienThi"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            
            this.Id = (int)row["id"];
            this.CapDoTaiKhoan = (int)row["capDoTaiKhoan"];
        }

        private int capDoTaiKhoan;

        public int CapDoTaiKhoan
        {
            get { return capDoTaiKhoan; }
            set { capDoTaiKhoan = value; }
        }

        


        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string tenHienThi;

        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }


        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
