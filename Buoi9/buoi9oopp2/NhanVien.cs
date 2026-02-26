/*
abstract class : Lớp trừu 
: bắt buộc các class con phải ghi đè, 
: abstract method : phương thức trừu tượng , không có phần thân , chỉ có khai báo, chỉ được khai báo trong abstract class
: không khởi tạo đối tượng từ class trừu tượng
THường dùng để làm lớp cha cho các lớp con kế thừa, dịnh nghĩa các phương thức chung mà các lớp con phải triển khai
- có thể chưa thuộc tính , phương thức bình thường 

*/ 


public abstract class NhanVien
{

    //thuộc tính : tên , lương cơ bản , tinhLuong()
    public string Ten { get; set; } = "";
    public double LuongCoBan { get; set; } = 0;
    public double TongLuong { get; set; } = 0;


    public abstract void TinhLuong(); // bắt buộc các class con phải ghi đè phương thức này
    
}
// nhân viên kinh doanh : nhan vien
public  class NhanVienKinhDoanh : NhanVien , IHienThi
{
    public double DoanhSo { get; set; } = 0;
    public double HoaHong { get; set; } = 0;

    public void HienThiThongTin()
    {
        throw new NotImplementedException();
    }

    // ghi đè phương thức tính lương
    public override void TinhLuong()
    {
        TongLuong = LuongCoBan + (DoanhSo * HoaHong / 100);
    }
    
}

// nhân vien sx: nhan vien  có thêm sản lượng  -> tính lương theo sản lượng
public class NhanVienSanXuat : NhanVien
{
    public int SanLuong { get; set; } = 0;
    public double DonGia { get; set; } = 0; // kiếm thêm 5k 1 sp 

    // ghi đè phương thức tính lương
    public override void TinhLuong()
    {
        TongLuong = LuongCoBan + (SanLuong * DonGia);
    }
}