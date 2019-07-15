using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    /// <summary>
    /// Lớp SelectList tùy chọn
    /// </summary>
    /// <typeparam name="T">Kiểu tùy ý</typeparam>
    public class MySelectList<T>
    {
        //do nhu cầu đồ án nếu sử dụng kiểu dữ liệu tự sinh quá khó
        //mình sẽ định nghĩa lại dữ liệu mới

        //Danh sách dữ liệu chọn
        public List<T> Data { get; set; }
        //thông tin mã đang chọn
        //nếu trường hợp create nó sẽ null
        public int? Selected { get; set; }
    }
}
