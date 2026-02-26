public class NhanVien
{
    private static int nextId = 1; // id tự động tăng, bắt đầu bằng 1
    public int MaNhanVien { get; private set; }
    public string Ten { get; set; }
    public double Luong1H { get; set; }
    public int SoGioLam { get; set; }
    public NhanVien()
    {

    }
    // tính lương
    public double TinhLuong()
    {
        return Luong1H * SoGioLam;
        // trên 2tr thì bị trừ thuế 10%
        // 

    }

    // hiển thị thông tin nhân viên
    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã nhân viên: {MaNhanVien}, Tên: {Ten}, Lương 1 giờ: {Luong1H}, Số giờ làm: {SoGioLam}, Lương: {TinhLuong()}");
    }
    // Nhập thông tin
    public void NhapThongTin()
    {
        Console.Write("Nhập mã nhân viên: ");
        MaNhanVien = int.Parse(Console.ReadLine());
        Console.Write("Nhập tên nhân viên: ");
        Ten = Console.ReadLine();
        Console.Write("Nhập lương 1 giờ: ");
        Luong1H = double.Parse(Console.ReadLine());
        Console.Write("Nhập số giờ làm: ");
        SoGioLam = int.Parse(Console.ReadLine());
    }


}