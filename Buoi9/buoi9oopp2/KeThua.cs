/*
class con kế thừa thuộc tính và phương thúc từ class cha

class KhungLong
{

}


class ConGa : KhungLong
{

}
Con gà là class con kế thừa từ class cha KhungLong
ConGa là class dẫn xuất : derived class
KhungLong là class cơ sở : base class

*/

// class HocVien
// {
//     // ten , tuoi
//     public string Ten;
//     public int Tuoi;
// }
// class Mentor
// {
//     public string Ten;
//     public int Tuoi;
// }
// class GiangVien
// {
//     public string Ten;
//     public int Tuoi;
// }

class NguoiDung
{
    public string Ten  { get; set; } = "";
    public int Tuoi  { get; set; } = 0;
    // vaitro
    public string VaiTro { get; set; } = "";
    private string BiMat = "12345"; // private chỉ class NguoiDung mới truy cập được

    /// <summary>
    /// 
    /// </summary>
    protected string ChiaKhoa = "ABCDE"; // protected : class con kế thừa có thể truy cập được


    // contructor

    public NguoiDung(string ten, int tuoi, string vaiTro)
    {
        Console.WriteLine("Contructor NguoiDung with param");
        Ten = ten;
        Tuoi = tuoi;
        VaiTro = vaiTro;
    }

    public NguoiDung()
    {
        // Ten = "";
        // Tuoi = 0;
        // VaiTro = "";
        Console.WriteLine("Contructor NguoiDung");
    }

    // phương thức
    // show thông tin
    // có thể bị ghi đè : virtual
    public virtual void HienThi()
    {
        Console.WriteLine($"{Ten} - {Tuoi} tuổi - Vai trò: {VaiTro}");
    }
}  


class Mentor : NguoiDung // kế thừa tất cả thuộc tính và phương thức từ NguoiDung có public
{
    public int HeSoLuong { get; set; }

// Khi tạo đối tượng class con thì constructor của class cha được gọi trước, sau đó đến constructor của class con.
//
// Nếu class cha có constructor có tham số (như public NguoiDung(string ten)), mà class con không khai báo constructor, thì sẽ bị lỗi khi bạn tạo đối tượng class con.
    public Mentor()
    {
        Console.WriteLine("Contructor Mentor");
    }
    public Mentor(string ten, int tuoi, string vaiTro, int heSoLuong)
     : base (ten, tuoi, vaiTro) // gọi contructỏ của class cha để khởi tạo thuộc tính kế thừa
    {
        Console.WriteLine("Constructor Mentor with parameters ");
        HeSoLuong = heSoLuong;

        Console.WriteLine($"ChiaKhoa: {ChiaKhoa}");
        // gọi constructor của class cha NguoiDung để khởi tạo thuộc tính kế thừa
    }
    // phương thức bổ sung
    // có thể mở rộng thêm thuộc tính và phương thức riêng
    public void ChamBai()
    {
        Console.WriteLine($"{Ten} đang chấm bài...");
    }
    public void DiemDanh()
    {
        Console.WriteLine($"{Ten} đang điểm danh...");
    }

    // ghi đè lại hàm của class cha
    // override  -  ghi đè  
    // ghi đè cho phép lópe con định nghĩa lại phương thức của lớp cha
    // là phương tiện -> tạo ra tính đa hình 
    public override void HienThi()
    {
        Console.WriteLine($"{Ten} - {Tuoi} tuổi - Vai trò: {VaiTro} - Hệ số lương: {HeSoLuong}");
    }

    public void MoCua(string key)
    {
        if(key == ChiaKhoa)
        {
            Console.WriteLine("Mở cửa thành công!");
        }
        else
        {
            Console.WriteLine("Mở cửa thất bại!");
        }
    }
} 


