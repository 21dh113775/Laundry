using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NhanVien : BaseEntity
    {
        [Required(ErrorMessage ="Bắt buộc nhập học tên nhân viên !!!")]
        [MaxLength(100)]
        public string HoTenNhanVien { get; set; }
        [Required]
        [Phone]
        public string Sodienthoai { get; set; }
        [MaxLength(250)]
        public string DiaChi { get; set; }
        [MaxLength(12)]
        public string CanCuocCongDan {  get; set; }
        [Required]
        public bool GioiTinh {  get; set; }

        public string GetGioiTinh()
        {
            if (GioiTinh)
            {
                return "Nam";
            }
            return "Nữ";
        }
    }
}
