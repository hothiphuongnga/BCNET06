public class Mon
{

    // thuộc tính : ten , gia
    public string Ten;
    public double Gia;

    public Mon()
    {
        // Constructor
    }
    
    public Mon(string ten, double gia)
    {
        Ten = ten;
        Gia = gia;
    }

    // show thông tin
    public void HienThi(int index)
    {
        Console.WriteLine($"{index}. {Ten} - {Gia} VND");
    }
    // nhập liệu
    public void Nhap()
    {
        Console.Write("Nhập tên món ăn: ");
        Ten = Console.ReadLine();
        // bổ sung kiểm tra số
        Console.Write("Nhập giá món ăn: ");
        Gia = double.Parse(Console.ReadLine());
    }

}