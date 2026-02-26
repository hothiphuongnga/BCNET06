class Program
{
    public static void Main(string[] args)
    {
        // conan
        // tạo ra instance (thể hiện) của lớp NhanVat
        // var connan = new NhanVat();
        // // gán giá trị cho thuộc tính
        // connan.Ten = "Conan";
        // connan.GioiTinh = "Nam";
        // connan.Tuoi = 7;
        // connan.GioiThieu();


        // // doremon
        // var doremon = new NhanVat();
        // doremon.Ten = "Doremon";
        // doremon.GioiTinh = "Nam";
        // doremon.Tuoi = 10;
        // doremon.GioiThieu();

        // // tạo nguoidung
        // NguoiDung user1 = new NguoiDung(); // khỏi tạo đối tượng Nguoidung và sử dụng giá trị mặc định của thuộc tính
        // user1.TenDangNhap = "admin";
        // user1.Email = "admin@gmail.com";
        // // user1.MatKhau = "admin123";
        // user1.SoDienThoai = "0987654321";



        // NguoiDung user2 = new NguoiDung()
        // {
        //     TenDangNhap = "user02",
        //     // MatKhau = "user0202",
        //     Email = "user02@gmail.com",
        //     SoDienThoai = "0912345678"
        // };


        // user1.HienThiThongTin();
        // user2.HienThiThongTin();
        // user1.DangNhap("admin", "1234567");


        // var user3 = new NguoiDung("user03", "333333", "user03@gmail.com", "0123456789");

        // user3.HienThiThongTin();




        // // tạo ra 1 con mario từ "khuôn" class Mario
        // var mario1 = new Mario(); // gọi contructor không tham số
        // mario1.Name = "Mario 1";
        // // mario1.SoMang = 9; // lỗi vì thuộc tính SoMang không cho gán giá trị từ bên ngoài lớp
        // Console.WriteLine($"Số mạng của {mario1.Name} là: {mario1.SoMang}");
        // mario1.ChangeLives(1);

        // mario1.Jump();
        // mario1.EatMushroom(20); // tăng 20 máu
        // mario1.TakeDamage(50); // giảm 50 máu
        // mario1.Run();
        // mario1.TakeDamage(80); // giảm 80 máu


        // Mario mario2 = new Mario("Mario 2", 150, 20, true); // gọi contructor có tham số
        // Mario mario3 = new Mario("Mario 3", 200, 30, true);

        // // static thuộc về class 
        // Console.WriteLine($"Tổng số Mario đã tạo: {Mario.TongSoMario}");
        // // gọi phương thức static
        // Mario.ShowTotalMarios();


        var quanLy = new QuanLyTask(); // khởi tạo đối tượng quản lý công việc
        quanLy.HienThiChucNang();


    }
}