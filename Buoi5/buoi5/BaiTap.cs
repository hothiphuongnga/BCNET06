class BaiTap
{
    int a = 10; // biến non static

    public static void BTDiemTrungBinh()
    {
        // nhập điểm toán lý hóa
        int toan = 0;
        int ly = 0;
        int hoa = 0;
        toan = NhapDiem("Toán");
        ly = NhapDiem("Lý");
        hoa = NhapDiem("Hoá");
        // tính điểm trung bình (tách hàm và gọi hàm ở đây)
        double dtb = TinhDiemTrungBinh(toan, ly, hoa);


        // kiểm tra điều kiện đậu rớt (tách hàm và gọi ở đây) kiểm tra dựa trên điểm trung bình
        string ketQua = XetDiem(dtb);
        Console.WriteLine($"Điểm trung bình: {dtb}, Kết quả học tập: {ketQua}");

    }
    // hàm nhập liệu và kiểm tra hợp lệ điểm số từ 0-10
    public static int NhapDiem(string monHoc)
    {
        Console.WriteLine($"Nhập điểm {monHoc}: ");
        int diem;
        while (!int.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại điểm từ 0 đến 10.");
        }
        return diem; 
        Console.WriteLine(""); // dòng này sẽ không được thực hiện vì đã có return ở trên
    }

    public static double TinhDiemTrungBinh(double toan, double ly, double hoa)
    {
        return (toan + ly + hoa) / 3;
    }
    public static string XetDiem(double dtb)
    {
        if (dtb >= 5)
        {
            return "Đậu";
        }
        else
        {
            return "Rớt";
        }

    }

    public static void HienThiThongTin(string ten, int tuoi)
    {
        Console.WriteLine($"Hello {ten}, {tuoi} tuổi. Tôi có thể giúp gì cho bạn?");
    }

    public static void HienThiThongTin(string ten, int tuoi, string ngheNghiep)
    {
        Console.WriteLine($"Hello {ten}, {tuoi} tuổi, Nghề nghiệp: {ngheNghiep}. Tôi có thể giúp gì cho bạn?");
    }
    /// <summary>
    /// Hàm hiển thị thông tin với số nhân khẩu
    /// </summary>
    /// <param name="ten">Tên của bạn</param>
    /// <param name="tuoi">Tuổi của bạn</param>
    /// <param name="soNhanKhau">Số thành viên trong gia đình</param>

    public static void HienThiThongTin(string ten, int tuoi, int soNhanKhau)
    {
        Console.WriteLine($"Hello {ten}, {tuoi} tuổi, Số nhân khẩu: {soNhanKhau}. Tôi có thể giúp gì cho bạn?");
    }

// gắn giá trị mặc định cho tham số 
// Tham số có giá trị mặc đinh ưu để ở sau
// 
    public static void HienThiThoiGian(int gio =10, int phut = 10, int giay = 10)
    {
        Console.WriteLine($"Bây giờ là {gio} giờ {phut} phút {giay} giây");
    }













}