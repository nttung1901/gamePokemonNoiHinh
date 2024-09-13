using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
namespace Pokemon
{
    public class PX_47_Tung : PictureBox
    {
        public int status_47_Tung;// Lưu trạng thái của ô (0 là đã bị xóa, -1 là bị click, 1 là vẫn tồn tại)
        public int x_47_Tung;// Lưu chỉ số dòng của ô trong mảng hai chiều
        public int y_47_Tung;// Lưu chỉ số cột của ô trong mảng hai chiều
        public int hinh_47_Tung;// Lưu giá trị số của hình
    }
}
