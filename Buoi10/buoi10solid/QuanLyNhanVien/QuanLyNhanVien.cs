using Newtonsoft.Json;

public class QuanLyNhanVien<T> where T : NhanVien
{
    public List<T> Items = new List<T>();
    public static string duongDan = "nhanvien.json";
    public QuanLyNhanVien()
    {

    }

    // thêm
    public void Them(T nv)
    {
        Items.Add(nv);
    }

    // tìm kiếm theo tên
    public List<T> TimKiemTheoTen(string ten)
    {
        return Items.Where(nv => nv.Ten.Contains(ten)).ToList();
    }
    // xoá
    public void Xoa(int maNhanVien)
    {
        var nv = Items.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
        if (nv != null)
        {
            Items.Remove(nv);
        }
    }
    // sửa tên
// ma nhân viên cần sửa và tên mới
// tim xem có nhân viên với mã đó hay không , có thì update lại

    // hiển thị menu chức năng
    public void HienThiMenu()
    {
        Console.WriteLine("1. Thêm nhân viên");
        Console.WriteLine("2. Tìm kiếm nhân viên theo tên");
        Console.WriteLine("3. Xoá nhân viên");
        Console.WriteLine("4. Sửa tên nhân viên");
        Console.WriteLine("5. Hiển thị tất cả nhân viên");
        Console.WriteLine("6. Lưu file");
        Console.WriteLine("7. Đọc file");
        Console.WriteLine("0. Thoát");


        // xuwr lys chon vaf goij hafm tuong ung 
        
    }
    //  lưu file
     public void LuuMenu()
    { // lưu lại dữ liệu vào file
        // lưu file json sẽ lưu dạng string
        // dữ liệu đang có dạng List<Mon> -> string , dùng thư viện hỗ trợ chuyển đổi : Newtonsoft.Json
        // chuyển List -> string dùng hàm SerializeObject của thư viện
        string json = JsonConvert.SerializeObject(Items);
        // lưu string vào file
        // nhận hai tham số : đường dẫn và nội dung cần lưu
        File.WriteAllText(duongDan, json);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("______________________");
        Console.WriteLine("Lưu menu JSON thành công!");
        Console.WriteLine("______________________");
        Console.ResetColor();
    }

    public void DocMenu() // đọc dữ liệu từ file , không cần lấy data cứng từ contructor nữa
    {
        if (File.Exists(duongDan))
        {
            // nếu như file tồn tại thì mình đọc
            var json = File.ReadAllText(duongDan);
            // json đang là string , muốn chuyển thành List<Mon> dùng hàm DeserializeObject
            Items = JsonConvert.DeserializeObject<List<T>>(json);// nhận vào 1 chuỗi json và trả về đối tượng đã được chuyển đổi
                                                                   // List<Mon> là kiểu dữ liệu mà mình muốn chuyển đổi sang , json là chuỗi cần chuyển đổi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________");
            Console.WriteLine("Đọc menu JSON thành công!");
            Console.WriteLine("______________________");
            Console.ResetColor();
        }


    // đọc file



}
}