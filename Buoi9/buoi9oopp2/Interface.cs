/*
INTERFACE
- là là 1 cái hợp đồng, quy định bắt buộc các class implement interface (thực thi) phải triển khai các phương thức, thuộc tính đã khai báo trong interface
- khai báo thuọc tính và phương thức nhưng không có phần thân, chỉ khai báo
- không khởi tạo đối tượng từ interface vì nó không phải là 1 thực thể cụ thể
- tất cả nhưng gì khai báo trong interface mặc định là public
- tính đa kế thừa : 1 class có thể implement nhiều interface cùng lúc
- không có contructor

- ở những phiên bản c# mới thì có cho phép viết phần thân cho phương thức trong interface nhưng không phổ biến, thường chỉ dùng để khai báo thôi
*/


public interface IHinhHoc
{
    // thuộc tính
    double Canh { get; set; }
    // interface chỉ có khai báo , không có phần thân
    // phương thức chu vi diện tích
    void TinhChuVi();
    void TinhDienTich();
    // {
    //     Console.WriteLine("Your text here");
    // }
}

// IHienThi
public interface IHienThi
{
    void HienThiThongTin();
}

public class HinhVuong : IHinhHoc , IHienThi
{
    // triển khai các phương thức và thuộc tính từ interface IHinhHoc
    public double Canh { get; set; } =10;

    public void HienThiThongTin()
    {
        Console.WriteLine("Hình Vuông");
    }

    public void TinhChuVi()
    {
        Console.WriteLine("Chu vi hình vuông: " + (Canh * 4));
    }

    public void TinhDienTich()
    {
        Console.WriteLine("Diện tích hình vuông: " + (Canh * Canh));
    }
}
public class HinhTron : IHinhHoc
{
    public double Canh { get; set; } = 7; // bán kính

    public void TinhChuVi()
    {
        Console.WriteLine("Chu vi hình tròn: " + (2 * Math.PI * Canh));
    }

    public void TinhDienTich()
    {
        Console.WriteLine("Diện tích hình tròn: " + (Math.PI * Canh * Canh));
    }
}