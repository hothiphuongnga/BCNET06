public class NguoiDung
{
    /*
    public: có thể truy cập từ bên ngoài lớp
    private: chỉ có thể truy cập bên trong lớp

    */

    // thuộc tính 
    public string TenDangNhap = "nguoi dung 01";
    private string MatKhau = "123456";
    public string Email = "email@example.com";
    public string SoDienThoai = "0123456789";

    // CONTRUCTOR: là một phương thức đặc biệt được sử dụng để khởi tạo đối tượng của lớp. Trùng tên với class, không có kiểu trả về
    // contructor default : là hàm tạo không tham số, luôn được định nghĩa ngầm trong class khi class không không có contructor nào khác
    // 

    // contructor có tham số

    // nhận tham số là 
    public NguoiDung()
    {
        TenDangNhap = "hihi";
    }

    public NguoiDung(string TenDangNhap, string matKhau, string email, string soDienThoai)
    {
        // gán giá trị cho thuộc tính
        this.TenDangNhap = TenDangNhap;
        MatKhau = matKhau;
        Email = email;
        SoDienThoai = soDienThoai;
    }

    // phương thức
    // show thông tin người dùng
    public void HienThiThongTin()
    {
        Console.WriteLine($"Thông tin người dùng: \nTên đăng nhập: {TenDangNhap} \nEmail: {Email} \nSố điện thoại: {SoDienThoai}");
    }
    // nhận vào tên dang nhập và mật khẩu
    /// <summary>
    /// Đăng nhập người dùng
    /// </summary>
    /// <param name="tenDangNhap">Tên đăng nhập của người dùng</param>
    /// <param name="matKhau">Mật khẩu của người dùng</param>
    public void DangNhap(string tenDangNhap, string matKhau)
    {
        // kiểm tra xem có đúng không
        if (tenDangNhap == TenDangNhap && matKhau == MatKhau)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Đăng nhập thành công");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Đăng nhập thất bại");
            Console.ResetColor();
        }
    }

    public void DangXuat()
    {

        Console.WriteLine("Đăng xuất thành công");
    }

}