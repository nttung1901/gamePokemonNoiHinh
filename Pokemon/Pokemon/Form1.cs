using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        const int height_47_Tung = 12; //Setup chiều cao mảng 2 chiều 
        const int width_47_Tung = 22;// Setup chiều rộng mảng 2 chiều
        int soCap_47_Tung = ((height_47_Tung - 2) * (width_47_Tung - 2)) / 2;// Số cặp pokemon trong mảng 
        int diem_47_Tung = 0;// Biến đếm tính điểm
        const int typeOfPokemon_47_Tung = 36;// Số lượng loại pokemon, tối đa 36
        //Tạo mảng 2 chiều chứa các cặp pokemon ngẫu nhiên (mảng số)
        GameModel_47_Tung gameModel_47_Tung = new GameModel_47_Tung(width_47_Tung - 2 , height_47_Tung - 2, typeOfPokemon_47_Tung);
        List<Point> pxClicked_47_Tung = new List<Point>();//Khởi tạo danh sách chứa các ô đang click (tối đa 2)
        //Khởi tạo mảng hai chiều chứa các cặp pokemon (dạng hình)
        PX_47_Tung[,] bang_47_Tung = new PX_47_Tung[height_47_Tung, width_47_Tung];


        //Hàm kiểm tra kết nối giữa 2 ô cùng trên một dòng
        public bool checkLineX(int y1_47_Tung, int y2_47_Tung, int x_47_Tung)
        {
            int min_47_Tung = Math.Min(y1_47_Tung, y2_47_Tung);
            int max_47_Tung = Math.Max(y1_47_Tung, y2_47_Tung);
    
            for (int y_47_Tung = min_47_Tung; y_47_Tung <= max_47_Tung; y_47_Tung++)
            {
                if (bang_47_Tung[x_47_Tung, y_47_Tung].status_47_Tung == 1)
                {
                    return false;
                }
            }
            return true;
        }

        //Hàm kiểm tra kết nối giữa 2 ô cùng trên một cột
        public bool checkLineY(int x1_47_Tung, int x2_47_Tung, int y_47_Tung)
        {
            int min_47_Tung = Math.Min(x1_47_Tung, x2_47_Tung);
            int max_47_Tung = Math.Max(x1_47_Tung, x2_47_Tung);

            for (int x_47_Tung = min_47_Tung; x_47_Tung <= max_47_Tung; x_47_Tung++)
            {
                if (bang_47_Tung[x_47_Tung, y_47_Tung].status_47_Tung == 1)
                {
                    return false;
                }
            }
            return true;
        }


        //Hàm kiểm tra kết nối giữa hai ô trong hình chữ nhật (đường chữ Z) theo chiều ngang
        public bool checkRectX(Point p1_47_Tung, Point p2_47_Tung)
        {
            Point pMinY_47_Tung = p1_47_Tung, pMaxY_47_Tung = p2_47_Tung;
            if(p1_47_Tung.Y > p2_47_Tung.Y)
            {
                pMinY_47_Tung = p2_47_Tung;
                pMaxY_47_Tung = p1_47_Tung;
            }
            for(int y_47_Tung = pMinY_47_Tung.Y + 1; y_47_Tung < pMaxY_47_Tung.Y; y_47_Tung++)
            {
                if(checkLineX(pMinY_47_Tung.Y, y_47_Tung, pMinY_47_Tung.X)
                    && checkLineY(pMinY_47_Tung.X, pMaxY_47_Tung.X, y_47_Tung)
                    && checkLineX(y_47_Tung, pMaxY_47_Tung.Y, pMaxY_47_Tung.X))
                {
                    return true;
                }
            }
            return false;
        }

        //Hàm kiểm tra kết nối giữa hai ô trong hình chữ nhật (đường chữ Z) theo chiều dọc
        public bool checkRectY(Point p1_47_Tung, Point p2_47_Tung)
        {
            Point pMinX_47_Tung = p1_47_Tung, pMaxX_47_Tung = p2_47_Tung;
            if (p1_47_Tung.X > p2_47_Tung.X)
            {
                pMinX_47_Tung = p2_47_Tung;
                pMaxX_47_Tung = p1_47_Tung;
            }
            for (int x_47_Tung = pMinX_47_Tung.X + 1; x_47_Tung < pMaxX_47_Tung.X; x_47_Tung++)
            {
                if (checkLineY(pMinX_47_Tung.X, x_47_Tung, pMinX_47_Tung.Y)
                    && checkLineX(pMinX_47_Tung.Y, pMaxX_47_Tung.Y, x_47_Tung)
                    && checkLineY(x_47_Tung, pMaxX_47_Tung.X, pMaxX_47_Tung.Y))
                {
                    return true;
                }
            }
            return false;
        }

        //Hàm kiểm tra kết nối giữa hai ô mở rộng theo chiều ngang
        public bool checkMoreLineX(Point p1_47_Tung, Point p2_47_Tung, int type_47_Tung)
        {
            
            Point pMinY_47_Tung = p1_47_Tung, pMaxY_47_Tung = p2_47_Tung;
            if (p1_47_Tung.Y > p2_47_Tung.Y)
            {
                pMinY_47_Tung = p2_47_Tung;
                pMaxY_47_Tung = p1_47_Tung;
            }
         
            int y_47_Tung = pMaxY_47_Tung.Y;
            int row_47_Tung = pMinY_47_Tung.X;
            if (type_47_Tung == -1)
            {
                y_47_Tung = pMinY_47_Tung.Y;
                row_47_Tung = pMaxY_47_Tung.X;
            }

            if (checkLineX(pMinY_47_Tung.Y, pMaxY_47_Tung.Y, row_47_Tung))
            {
                while (bang_47_Tung[pMinY_47_Tung.X, y_47_Tung].status_47_Tung != 1
                        && bang_47_Tung[pMaxY_47_Tung.X, y_47_Tung].status_47_Tung != 1)
                {
                    if (checkLineY(pMinY_47_Tung.X, pMaxY_47_Tung.X, y_47_Tung))
                    {
                        return true;
                    }
                    y_47_Tung += type_47_Tung;
                }
            }
            return false;
        }


        //Hàm kiểm tra kết nối giữa hai ô mở rộng theo chiều dọc
        public bool checkMoreLineY(Point p1_47_Tung, Point p2_47_Tung, int type_47_Tung)
        {
            Point pMinX_47_Tung = p1_47_Tung, pMaxX_47_Tung = p2_47_Tung;
            if (p1_47_Tung.X > p2_47_Tung.X)
            {
                pMinX_47_Tung = p2_47_Tung;
                pMaxX_47_Tung = p1_47_Tung;
            }
            int x_47_Tung = pMaxX_47_Tung.X;
            int col_47_Tung = pMinX_47_Tung.Y;
            if (type_47_Tung == -1)
            {
                x_47_Tung = pMinX_47_Tung.X;
                col_47_Tung = pMaxX_47_Tung.Y;
            }
            if (checkLineY(pMinX_47_Tung.X, pMaxX_47_Tung.X, col_47_Tung))
            {
                while (bang_47_Tung[x_47_Tung, pMinX_47_Tung.Y].status_47_Tung != 1
                        && bang_47_Tung[x_47_Tung, pMaxX_47_Tung.Y].status_47_Tung != 1)
                {
                    if (checkLineX(pMinX_47_Tung.Y, pMaxX_47_Tung.Y, x_47_Tung))
                    {
                        return true;
                    }
                    x_47_Tung += type_47_Tung;
                }
            }
            return false;
        }

        // Hàm kiểm tra hai ô có kết nối được không
        public bool checkTwoPoint(Point p1_47_Tung, Point p2_47_Tung)
        {
            if (p1_47_Tung.X == p2_47_Tung.X)
            {
                if (checkLineX(p1_47_Tung.Y, p2_47_Tung.Y, p1_47_Tung.X))
                {
                    return true; // Trả về true nếu kết nối được trên cùng một dòng
                }
            }
            if (p1_47_Tung.Y == p2_47_Tung.Y)
            {
                if (checkLineY(p1_47_Tung.X, p2_47_Tung.X, p1_47_Tung.Y))
                {
                    return true; // Trả về true nếu kết nối được trên cùng một cột
                }
            }
            if (checkRectX(p1_47_Tung, p2_47_Tung))
            {
                return true; // Trả về true nếu kết nối được theo hình chữ nhật theo chiều ngang
            }
            if (checkRectY(p1_47_Tung, p2_47_Tung))
            {
                return true; // Trả về true nếu kết nối được theo hình chữ nhật theo chiều dọc
            }
            if (checkMoreLineX(p1_47_Tung, p2_47_Tung, 1))
            {
                return true; // Trả về true nếu kết nối được theo chiều ngang với một hàng trống ở giữa
            }
            if (checkMoreLineX(p1_47_Tung, p2_47_Tung, -1))
            {
                return true; // Trả về true nếu kết nối được theo chiều ngang với một hàng trống ở giữa (ngược lại)
            }
            if (checkMoreLineY(p1_47_Tung, p2_47_Tung, 1))
            {
                return true; // Trả về true nếu kết nối được theo chiều dọc với một cột trống ở giữa
            }
            if (checkMoreLineY(p1_47_Tung, p2_47_Tung, -1))
            {
                return true; // Trả về true nếu kết nối được theo chiều dọc với một cột trống ở giữa (ngược lại)
            }
            return false; // Nếu không kết nối được, trả về false
        }
        //Hàm kiểm tra chiến thắng nếu status các ô trong mảng đều  = 0 (đã bị xóa hết)
        public bool chekWin()
        {
            for(int i_47_Tung = 1; i_47_Tung < height_47_Tung - 1; i_47_Tung++)
            {
                for(int j_47_Tung = 1; j_47_Tung < width_47_Tung - 1; j_47_Tung++)
                {
                    if (bang_47_Tung[i_47_Tung, j_47_Tung].status_47_Tung == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Hàm xáo các hình pokemon giữa các ô trong mảng với nhau
        public void shuffle()
        {
            //Khởi tạo danh sách lưu các hình pokemon hiện có trong mảng
            List<int> images_47_Tung = new List<int>();

            //Duyệt để lưu các hình pokemon vào images_47_Tung
            for (int i_47_Tung = 1; i_47_Tung < height_47_Tung - 1; i_47_Tung++)
            {
                for (int j_47_Tung = 1; j_47_Tung < width_47_Tung - 1; j_47_Tung++)
                {
                    if (bang_47_Tung[i_47_Tung, j_47_Tung].status_47_Tung != 0)
                    {
                        images_47_Tung.Add(bang_47_Tung[i_47_Tung, j_47_Tung].hinh_47_Tung);
                    }
                }
            }

            //Khởi tạo biến random
            Random random_47_Tung = new Random();
            //Khởi tạo biến số lượng hình pokemon
            int n_47_Tung = images_47_Tung.Count;
            //Duyệt để thay đổi vị trí của các hình trong danh sách
            while (n_47_Tung > 1)
            {
                n_47_Tung--;
                int k_47_Tung = random_47_Tung.Next(n_47_Tung + 1);
                int value = images_47_Tung[k_47_Tung];
                images_47_Tung[k_47_Tung] = images_47_Tung[n_47_Tung];
                images_47_Tung[n_47_Tung] = value;
            }
            int index_47_Tung = 0;
            //Duyệt để đổi hình lại từng ô từ danh sách 
            for (int i_47_Tung = 1; i_47_Tung < height_47_Tung - 1; i_47_Tung++)
            {
                for (int j_47_Tung = 1; j_47_Tung < width_47_Tung - 1; j_47_Tung++)
                {
                    if (bang_47_Tung[i_47_Tung, j_47_Tung].status_47_Tung != 0)
                    {
                        bang_47_Tung[i_47_Tung, j_47_Tung].hinh_47_Tung = images_47_Tung[index_47_Tung];
                        string name_47_Tung = "pieces" + bang_47_Tung[i_47_Tung, j_47_Tung].hinh_47_Tung.ToString() + ".png";
                        bang_47_Tung[i_47_Tung, j_47_Tung].Image = Image.FromFile(name_47_Tung);
                        index_47_Tung++;
                    }
                }
            }
        }

        //Hàm xử lý khi có sự kiện click trên ô
        public void pictureBoxClickEventhandle(object sender_47_Tung, EventArgs e_47_Tung)
        {
            if(sender_47_Tung is PX_47_Tung clikedPictureBox)
            {
                clikedPictureBox.status_47_Tung = -1;//Đưa về trạng thái bị click
                clikedPictureBox.Enabled = false;//Vô hiệu hóa ô
                //Tạo điểm lưu tọa độ của ô trong mảng
                Point point_47_Tung = new Point(clikedPictureBox.x_47_Tung, clikedPictureBox.y_47_Tung);
                pxClicked_47_Tung.Add(point_47_Tung);//Thêm điểm của ô vào danh sách chờ kiểm tra
                if (pxClicked_47_Tung.Count == 2)//Đợi đủ 2 ô bị click
                {
                    //kiểm tra 2 ô có giống nhau không?
                    if (bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].hinh_47_Tung == bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].hinh_47_Tung)
                    {
                       //Kiểm tra hai ô có kết nối với nhau được không
                        if (checkTwoPoint(pxClicked_47_Tung[0], pxClicked_47_Tung[1]))
                        {
                            diem_47_Tung++;//Nối được một cặp cộng thêm 1 điểm
                            bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].Image = null;//ô trong suốt
                            bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].Image = null;//ô trong suốt
                            bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].hinh_47_Tung = 0; 
                            bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].hinh_47_Tung = 0;
                            //Trạng thái đã bị xóa
                            bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].status_47_Tung = 0;
                            //Trạng thái đã bị xóa
                            bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].status_47_Tung = 0;
                        }
                        else
                        {
                            //Bật lại trạng thái bình thường
                            bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].status_47_Tung = 1;
                            //Bật lại trạng thái bình thường
                            bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].status_47_Tung = 1;
                            //Ô hoạt động bình thường
                            bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].Enabled = true;
                            //Ô hoạt động bình thường
                            bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].Enabled = true;
                        }
                    }
                    else
                    {
                        //Bật lại trạng thái bình thường
                        bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].status_47_Tung = 1;
                        //Bật lại trạng thái bình thường
                        bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].status_47_Tung = 1;
                        //Ô hoạt động bình thường
                        bang_47_Tung[pxClicked_47_Tung[0].X, pxClicked_47_Tung[0].Y].Enabled = true;
                        //Ô hoạt động bình thường
                        bang_47_Tung[pxClicked_47_Tung[1].X, pxClicked_47_Tung[1].Y].Enabled = true;
                    }
                    pxClicked_47_Tung.Clear();//Làm rỗng danh sách chờ
                    lbKQDiem_47_Tung.Text = diem_47_Tung + "/" + soCap_47_Tung;//Sửa điểm
                    //Kiểm tra chiến thắng
                    if (chekWin())
                    {
                        MessageBox.Show("Chiến thắng!");
                    }
                }
                
            }
        }


        //Hàm xử lý khi có sự kiện đưa chuột vào ô
        public void pictureBoxMouseHoverEventhandle(object sender_47_Tung, EventArgs e)
        {
            (sender_47_Tung as PX_47_Tung).BackColor = Color.Red;
        }

        //Hàm xử lý khi có sự kiện đưa chuột rời khỏi ô
        public void pictureBoxMouseLeaveEventhandle(object sender_47_Tung, EventArgs e)
        {
            (sender_47_Tung as PX_47_Tung).BackColor = Color.Transparent;
        }
        public Form1()
        {
            InitializeComponent();
            //Duyệt hết mảng hai chiều
            for(int i_47_Tung = 0; i_47_Tung <= height_47_Tung - 1; i_47_Tung++)
            {
                for(int j_47_Tung = 0; j_47_Tung <= width_47_Tung - 1; j_47_Tung++)
                {
                    PX_47_Tung px_47_Tung = new PX_47_Tung();//Tạo mới một ô
                    px_47_Tung.x_47_Tung = i_47_Tung;//Lưu chỉ số dòng
                    px_47_Tung.y_47_Tung = j_47_Tung;//Lưu chỉ số cột
                    px_47_Tung.status_47_Tung = 1;//Đặt trạng thái (1 là tồn tại, 0 là bị xóa, -1 là bị click)
                    px_47_Tung.Width = 44;//Chiều rộng của ô
                    px_47_Tung.Height = 54;//chiều cao của ô
                    px_47_Tung.Top = 10 + i_47_Tung * 54;//Khoảng cách phía trên của ô
                    px_47_Tung.Left = 10 + j_47_Tung * 44;//Khoảng cách trái của ô
                    px_47_Tung.Click += new EventHandler(pictureBoxClickEventhandle);//Sự kiện click
                    px_47_Tung.MouseHover += new EventHandler(pictureBoxMouseHoverEventhandle);//Sự kiện đưa chuột vào
                    px_47_Tung.MouseLeave += new EventHandler(pictureBoxMouseLeaveEventhandle);//Sự kiện đưa chuột ra
              
                    //Những ô nằm trong 4 cạnh của mảng 2 chiều mặc định là đã bị xóa
                    if (i_47_Tung == 0 || j_47_Tung == 0|| i_47_Tung == height_47_Tung - 1 || j_47_Tung == width_47_Tung - 1)
                    {
                        px_47_Tung.hinh_47_Tung = 0;
                        px_47_Tung.Image = null;
                        px_47_Tung.status_47_Tung = 0;
                        px_47_Tung.Enabled = false;
                    }
                    else
                    {
                        //Lưu chỉ số hình từ mảng số GameModel_47_Tung
                        px_47_Tung.hinh_47_Tung = gameModel_47_Tung.getCell_47_Tung(i_47_Tung - 1, j_47_Tung - 1);
                        String name_47_Tung = "pieces" + gameModel_47_Tung.getCell_47_Tung(i_47_Tung - 1 , j_47_Tung - 1).ToString() + ".png";
                        px_47_Tung.Image = Image.FromFile(name_47_Tung);
                        px_47_Tung.SizeMode = PictureBoxSizeMode.CenterImage;//Canh hình ở trung tâm của ô
                    }
                    bang_47_Tung[i_47_Tung, j_47_Tung] = px_47_Tung;//Thêm vào mảng hai chiều
                    this.Controls.Add(px_47_Tung);//Thêm vào hiển thị màn hình
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //Nút xáo hình
        private void btXao_47_Tung_Click(object sender, EventArgs e)
        {
            shuffle();
        }


        //Nút thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //nút chơi lại
        private void btRePlay_Click(object sender, EventArgs e)
        {
            diem_47_Tung = 0;
            lbKQDiem_47_Tung.Text = "";
            GameModel_47_Tung gameModel_47_Tung = new GameModel_47_Tung(width_47_Tung - 2, height_47_Tung - 2, 36);
            for (int i_47_Tung = 1; i_47_Tung < height_47_Tung - 1; i_47_Tung++)
            {
                for (int j_47_Tung = 1; j_47_Tung < width_47_Tung - 1; j_47_Tung++)
                {
                    bang_47_Tung[i_47_Tung, j_47_Tung].hinh_47_Tung = gameModel_47_Tung.getCell_47_Tung(i_47_Tung - 1, j_47_Tung - 1);
                    string name_47_Tung = "pieces" + bang_47_Tung[i_47_Tung, j_47_Tung].hinh_47_Tung.ToString() + ".png";
                    bang_47_Tung[i_47_Tung, j_47_Tung].Image = Image.FromFile(name_47_Tung);
                    bang_47_Tung[i_47_Tung, j_47_Tung].Enabled = true;
                    bang_47_Tung[i_47_Tung, j_47_Tung].status_47_Tung = 1;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
