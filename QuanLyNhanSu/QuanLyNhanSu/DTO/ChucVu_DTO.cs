using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
   public class ChucVu_DTO   //b1 thêm public để các lớp khác có thể gọi
    {
        public ChucVu_DTO(string MaChucVu,string ChucVu) //b3 tạo 2 hàm khởi tạo. Cái này biến ae đặt giống CSDL để sau truy vấn k bị nhầm
        {
            this.MaChucVu = MaChucVu; // this.MaChucVu là biến get/set. còn MaChucVu là biến khởi tạo để sau truyền parameter vào
            this.ChucVu = ChucVu;
        }
        public ChucVu_DTO(DataRow row) //b4 viết hàm khởi tạo thứ 2
        { 
            this.MaChucVu = row["MaChucVu"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
        }
    


        private string maChucVu; //b2 private + kiểu dữ liệu bên SQL cộng tên cột chữ cái đầu không viết hoa. Sau đó ctrl + R+E

        private string chucVu;

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
