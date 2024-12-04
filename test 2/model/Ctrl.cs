using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2.model
{
    public class ViewModel
    {
        public List<lop> DanhSachLop { get; set; }

        public ViewModel()
        {
            // Khởi tạo danh sách lớp
            DanhSachLop = new List<lop>
        {
            new lop
            {
                ten = "Lớp A",
                _sv = new sv { ho = "Nguyễn", ten = "Anh" }
            },
            new lop
            {
                ten = "Lớp B",
                _sv = new sv { ho = "Trần", ten = "Bảo" }
            },
            new lop
            {
                ten = "Lớp C",
                _sv = new sv { ho = "Lê", ten = "Công" }
            }
        };
        }
    }

}
