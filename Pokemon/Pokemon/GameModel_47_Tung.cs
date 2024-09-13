using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    // Khai báo lớp GameModel_47_Tung để tạo ra một mảng hai chiều chứa các cặp Pokemon ngẫu nhiên.
    internal class GameModel_47_Tung
    {
        // Khai báo mảng hai chiều đại diện cho bảng chơi
        private int[,] table_47_Tung;
        // Khai báo hai biến để lưu trữ chiều rộng và chiều cao của bảng.
        private int width_47_Tung, height_47_Tung;

        // Định nghĩa thuộc tính Width_47_Tung để truy cập và cập nhật chiều rộng của bảng.
        public int Width_47_Tung
        {
            get { return width_47_Tung; }
            set { width_47_Tung = value; }
        }

        // Định nghĩa thuộc tính Height_47_Tung để truy cập và cập nhật chiều cao của bảng.
        public int Height_47_Tung
        {
            get { return height_47_Tung; }
            set { height_47_Tung = value; }
        }

        // Lớp khởi tạo bảng chơi với kích thước và số lượng loại Pokémon cụ thể.
        //numOfType_47_Tung : số lượng loại pokemon
        public GameModel_47_Tung(int width_47_Tung, int height_47_Tung, int numOfType_47_Tung)
        {
            // Khởi tạo chiều rộng và chiều cao của bảng từ tham số truyền vào.
            this.width_47_Tung = width_47_Tung;
            this.height_47_Tung = height_47_Tung;

            // Tạo mảng hai chiều với kích thước truyền vào
            table_47_Tung = new int[height_47_Tung, width_47_Tung];

            // Khởi tạo một HashSet để lưu trữ các chỉ số ô đã được sử dụng (số ô của mảng = height_47_Tung * width_47_Tung)
            HashSet<int> cellIndex_47_Tung = new HashSet<int>();

            // Tạo đối tượng Random để sinh số ngẫu nhiên.
            Random random_47_Tung = new Random();

            // Vòng lặp để phân phối ngẫu nhiên các cặp Pokémon lên bảng.
            for (int i_47_Tung = 0; i_47_Tung < width_47_Tung * height_47_Tung / 2; i_47_Tung++)
            //Phải chạy width_47_Tung * height_47_Tung / 2 lần vì mỗi lần sẽ gán hai ô cùng một loại pokemon
            {
                // Random một loại Pokémon ngẫu nhiên.
                int typeOfPokemon_47_Tung = random_47_Tung.Next(1, numOfType_47_Tung + 1);

                // Random ngẫu nhiên một ô trên bảng để gán pokemon sao cho ô này chưa nằm trong cellIndex_47_Tung.
                int cell1_47_Tung = random_47_Tung.Next(random_47_Tung.Next(0, width_47_Tung * height_47_Tung + 1));
                while (cellIndex_47_Tung.Contains(cell1_47_Tung))
                {
                    cell1_47_Tung = random_47_Tung.Next(random_47_Tung.Next(0, width_47_Tung * height_47_Tung + 1));
                }
                // Gán loại Pokémon vừa random vào ô đầu tiên của cặp.
                //cell1_47_Tung / width_47_Tung sẽ cho kết quả là chỉ số dòng của ô nằm trong bảng
                //cell1_47_Tung % width_47_Tung sẽ cho kết quả là chỉ số cột của ô nằm trong bảng
                table_47_Tung[cell1_47_Tung / width_47_Tung, cell1_47_Tung % width_47_Tung] = typeOfPokemon_47_Tung;
                // Thêm ô này vào cellIndex_47_Tung để trách bị sự dụng lại.
                cellIndex_47_Tung.Add(cell1_47_Tung);

                // Tương tự như ô thứ nhất, random ô thứ hai sao cho ô này chưa nằm trong cellIndex_47_Tung.
                int cell2_47_Tung = random_47_Tung.Next(random_47_Tung.Next(0, width_47_Tung * height_47_Tung + 1));
                while (cellIndex_47_Tung.Contains(cell2_47_Tung))
                {
                    cell2_47_Tung = random_47_Tung.Next(random_47_Tung.Next(0, width_47_Tung * height_47_Tung + 1));
                }
                // Gán tiếp loại Pokémon ô thứ nhất vào ô thứ hai.
                table_47_Tung[cell2_47_Tung / width_47_Tung, cell2_47_Tung % width_47_Tung] = typeOfPokemon_47_Tung;
                // Thêm ô này vào cellIndex_47_Tung để trách bị sự dụng lại.
                cellIndex_47_Tung.Add(cell2_47_Tung);
            }
        }

        // Phương thức để lấy giá trị của một ô trong bảng dựa trên tọa độ x, y.
        public int getCell_47_Tung(int x, int y)
        {
            return table_47_Tung[x, y];
        }
    }

}
