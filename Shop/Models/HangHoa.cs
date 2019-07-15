using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [MaxLength(50)]
        [Display(Name = "Tên hàng hóa")]
        public string TenHh { get; set; }
        [MaxLength(150)]
        [Display(Name = "Hình")]
        [DataType(DataType.MultilineText)]
        public string Hinh { get; set; }
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
        [Display(Name = "Đơn giá")]
        [DisplayFormat(DataFormatString = "{0:N0} đ")] //định dạnh tại model
        public double DonGia { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Loại")]
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        [Display(Name = "Loại")]
        public Loai Loai { get; set; }

    }
}
