public class Program
{
    public static void Main(string[] args)
    {

        #region In ra ma trận ngôi sao n dòng và m cột
        // nhập liệu dong , cot từ bàn phím

        // duyêt vòng lặp qua số dòng (1)
        // bên trong dòng : mỗi dòng có {cot} ngôi sao  (2)






        //(2) in ra số ngôi sao trên 1 dòng 



        // int dong = 0;
        // int cot = 0;

        // int dong, cot;
        // // trypasre , vòng lặp 
        // while (true) // dùng whle true để nhập liệu và bắt lỗi
        // {
        //     Console.Write("Nhập số dòng: ");
        //     bool isDongValid = int.TryParse(Console.ReadLine(), out dong);
        //     if (isDongValid) // nếu nhập đúng thì kết thúc vòng lặp
        //     {
        //         break;
        //     }
        //     Console.WriteLine("Vui lòng nhập số nguyên hợp lệ cho số dòng.");
        // }

        // while (true)
        // {
        //     Console.Write("Nhập số cột: ");
        //     if (int.TryParse(Console.ReadLine(), out cot)) break;
        //     Console.WriteLine("Vui lòng nhập số nguyên hợp lệ cho số cột.");
        // }


        // // VD 3 dòng và 5 cột
        // /*
        // ⭐ ⭐ ⭐ ⭐ ⭐
        // */
        // // in ra 3 dòng
        // for (int d = 1; d <= dong; d++)
        // {
        //     // in ra 1 dòng  có 5 cột ngôi sao
        //     for (int i = 1; i <= cot; i++)
        //     {
        //         Console.Write("⭐");
        //     }
        //     Console.WriteLine();
        // }
        #endregion


        #region tam giác vuông
        /*
        ⭐           1 
        ⭐ ⭐        2 
        ⭐ ⭐ ⭐     3
        ⭐ ⭐ ⭐ ⭐   4

        */
        // int canh;
        // // trypasre , vòng lặp 
        // while (true) // dùng whle true để nhập liệu và bắt lỗi
        // {
        //     Console.Write("Nhập chiều dài cạnh tam vuông cân: ");
        //     bool isDongValid = int.TryParse(Console.ReadLine(), out canh);
        //     if (isDongValid) // nếu nhập đúng thì kết thúc vòng lặp
        //     {
        //         break;
        //     }
        //     Console.WriteLine("Vui lòng nhập số nguyên hợp lệ cho chiều dài cạnh tam vuông cân.");
        // }
        // // in ra n dòng
        // for (int i = 1; i <= canh; i++)
        // {
        //     // i=1
        //     // i=2 
        //     //ví dụ dòng 4 in ra 4 ngôi sao
        //     for (int d = 1; d <= i; d++)
        //     {
        //         Console.Write("⭐ ");
        //     }
        //     Console.WriteLine();
        // }
        #endregion

        #region Tìm số nguyên tố từ 1 đêsn n

        // int so;
        // // trypasre , vòng lặp 
        // while (true) // dùng whle true để nhập liệu và bắt lỗi
        // {
        //     Console.Write("Nhập số: ");
        //     bool isDongValid = int.TryParse(Console.ReadLine(), out so);
        //     if (isDongValid) // nếu nhập đúng thì kết thúc vòng lặp
        //     {
        //         break;
        //     }
        //     Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
        // }


        // string result = "";

        // // chạy vòng lặp từ 2 đến số cần kiểm tra 
        // for (int i = 2; i <= so; i++)
        // {
        //     // tại i

        //     // kiểm tra số i có phải số nguyên tố không
        //     // ví dụ i =16
        //     // từ từ 2 đến 4
        //     bool kiemTraSNT = true; // giả sử i là số nguyên tố
        //     for (int j = 2; j <= Math.Sqrt(i); j++)
        //     {
        //         if (i % j == 0)
        //         {
        //             kiemTraSNT = false; // không phải số nguyên tố
        //             // không phải số nguyên tố
        //             // continue; // bỏ qua số j để j+1
        //             break; // thoát vòng lặp nhỏ này  để kiểm tra số i+1
        //         }
        //     }
        //     if (kiemTraSNT) // còn đúng thì số i là số NT 
        //     {
        //         result += $"{i}, ";
        //     }
        // }
        // Console.WriteLine($"Các số nguyên tố từ 1 đến {so} là: {result}");



        #endregion


        #region FUNCTION
        //
        /*
        Khái niệm: slide
        cú pháp định nghĩa hàm trong C#

        Có các dạng funtion :
            - Hàm void không tham số
            - Hàm void có tham số
            - hàm có giá trị trả về : return
        void tên-hàm()
        {
            thân hàm
        }

        kiêu-du-lieu

        */


        // void Hello()
        // {
        //     Console.WriteLine("Hello Phương Nga");
        // }

        // // gọi hàm 
        // for (int i = 0; i <= 5; i++)
        // {
        //     Hello();
        // }

        // // tính tổng 2 số a và b 
        // void TongHaiSo(int a, int b) // hàm này sẽ nhận vào 2 giá trị số nguyên a và số nguyên b
        // {
        //     int tong = a + b;
        //     Console.WriteLine($"Tổng của {a} và {b} là: {tong}");
        // }

        // // cách dùng hàm có tham số/ parameter
        // TongHaiSo(5, 10); // a=5, b=10
        //                   // b=10. a=20
        // TongHaiSo(20, 10);


        // // hàm tính trung bình cộng của 3 số , sau đó lấu giá trị của hàm đi xét học lực

        // // giá trị trả về nó có kiểu gì ? có , và kiểu double
        // // có tham số hay không ? và bao nhiêu tham số ? có 3 tham số kiểu double
        // ///
        // double TinhTrungBinhCong(double so1, double so2, double so3)
        // {
        //     double kq = (so1 + so2 + so3) / 3;
        //     return kq;
        // }
        // // cách gọi hàm có giá trị trả về
        // double kqGoiHam = TinhTrungBinhCong(10, 9, 8);
        // Console.WriteLine($"Trung bình cộng là: {kqGoiHam}");

        #endregion


        #region Bài tập hàm

        //  new  tạo ra instance mới dụng được cho nhứng hàm non static



        // BaiTap.BTDiemTrungBinh();

        #endregion


        #region HienThiThongTin 
        // NẠP CHỒNG HÀM - OVERLOADING FUNCTION
        // 1. TRÙNG TÊN
        // 2. KHÁC THAM SỐ (KIỂU DỮ LIỆU, SỐ LƯỢNG THAM SỐ, HOẶC CẢ HAI)



        BaiTap.HienThiThongTin("Phương Nga", 18);
        BaiTap.HienThiThongTin("Phương Nga", 18, "Sinh viên");
        BaiTap.HienThiThongTin("Nga", 18, 4);



        BaiTap.HienThiThoiGian(14, 30, 45);
        BaiTap.HienThiThoiGian(13); // lấy giờ =13 còn phút giây lấy default
        // giữ giờ phút là giá defauil và đổi giay
        BaiTap.HienThiThoiGian(giay: 99);

        #endregion


        #region Lamda expression
        // Lambda là 1 hàm không tên 
        // func : hàm có giá trị trả về 
        // biểu thức lambda
        // cú pháp
        // (tham-số) => biểu-thức
        Func<int, int> binhPhuong = x => x * x;
        // <int , int > : int đầu tiên là tham số truyền vào , int thứ 2 là kiểu dữ liệu trả về
        // x : tham số truyền vào
        // x*x : biểu thức trả về
        Func<int, string> xepHang = diem => $"Điểm của bạn là {diem}, bạn {(diem >= 5 ? "Đậu" : "Rớt")}";

        var kqBinhPhuong = binhPhuong(5);
        var kqXepHang = xepHang(9);
        Console.WriteLine($"Bình phương của 5 là: {kqBinhPhuong}");
        Console.WriteLine(kqXepHang);



        // Action : hàm không có giá trị trả về (void)
        Action<string> inThongBao = thongBao => Console.WriteLine($"Thông báo: {thongBao}");
        // cú pháp
        // Action<kiểu-tham-số-1, kiểu-tham-số-2,...> tên-hàm = (tham-số-1, tham-số-2,
        // <string> : tham số truyền vào là kiểu string
        Action<string> inBaiBao = thongBao =>
        {
            Console.WriteLine("Bài báo bắt đầu");
            Console.WriteLine(thongBao);
            Console.WriteLine("Bài báo kết thúc");
        };
        inThongBao("Học C# tại Cybersoft");
        inBaiBao("Học lập trình để thay đổi cuộc sống");





        Func<int , int , int , double> tinhTrungBinhCong = (a, b, c)=> (a + b + c) / 3;
        
        #endregion

    }
}