public class ChungCu 
{
    
    // thuộc tên , địa chỉ, khu quan lý 
    public string Ten { get; set; } = ""; // ai cũng có thể truy cập
    public string DiaChi { get; set; } = ""; 
    public string KhuQuanLy { get; set; } = "";
    public  string HoBoi { get; set; } = "";
    
    protected string SanChoi { get; set; } = ""; // chỉ class con kế thừa mới truy cập được 



    private string PhongBaoVe;  //
    // l1 -> l8 


}
class L1: ChungCu
{
    public void SuDungSanChoi()
    {
        Console.WriteLine(SanChoi);
        // PhongBaoVe = "Phòng bảo vệ L1"; // lỗi vì PhongBaoVe là private của class ChungCu
    }
}