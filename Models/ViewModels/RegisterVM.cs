using ECommerceMVC.Data;
using System.ComponentModel.DataAnnotations;

namespace ECommerceMVC.Models.ViewModels
{
    public class RegisterVM
    {
        //MaKH, MatKhau, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, Hinh
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage ="*")]
        [MaxLength(20, ErrorMessage ="Tối đa 20 kí tự")]
        public string MaKh { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; } = true;

        [Display(Name="Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [MaxLength(60, ErrorMessage = "Tối đa 60 kí tự")]
        public string DiaChi { get; set; }

        [MaxLength(24, ErrorMessage = "Tối đa 24 kí tự")]
        [RegularExpression(@"0[9875]\d{8}", ErrorMessage = "Chưa đúng định dạng di động")]
        //Biểu thức chính quy @"0[9875]\d{8}" có thể được phân tích như sau:
        //0: Chuỗi phải bắt đầu bằng chữ số '0'.
        //[9875]: Ký tự thứ hai phải là một trong các chữ số '9', '8', '7', hoặc '5'.
        //\d{8}: Tám ký tự tiếp theo phải là chữ số(0-9).
        public string DienThoai { get; set; }

        [EmailAddress(ErrorMessage ="Chưa đúng định dạng email")]
        public string Email { get; set; } = null!;

        public string? Hinh { get; set; }

    }
}
