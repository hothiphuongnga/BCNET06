using Newtonsoft.Json;

public class QuanLyMenu
{
    // thuộc tính : ds món , hiển thị ds món() , thêm món(), xoá (), hiển thị danh sách tính năng ()
    List<Mon> dsMon { get; set; } = new List<Mon>();
    // đường dẫn
    public static string duongDan = "menu.json";

    public QuanLyMenu()
    {
        // Constructor 

        // custom giá trị cho thuộc tính  hay muốn lấy dữ liệu / show thông báo , ...
        // có thể lưu lại thông tin menu . VD : thêm , xoá sửa được lưu lại 
        //thêm  5 món mặc định
        // dsMon.Add(new Mon("Phở bò", 50000));
        // dsMon.Add(new Mon("Bún chả", 40000));
        // dsMon.Add(new Mon("Cơm tấm", 45000));
        // dsMon.Add(new Mon("Gỏi cuốn", 30000));
        // dsMon.Add(new Mon("Bánh mì", 20000));
        // thay bằng đọc dữ liệu từ file json
        DocMenu();
    }
    public void Add(Mon mon)
    {
        dsMon.Add(mon);
        LuuMenu(); // lưu lại menu sau khi thêm món mới
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("______________________");
        Console.WriteLine("Thêm món thành công!");
        Console.WriteLine("______________________");
        Console.ResetColor();
    }
    // show ds món
    public void HienThiDsMon()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("-----Danh sách món ăn-----");
        // chạy vòng lặp qua từng món và gọi hàm HienThi 
        for (int i = 0; i < dsMon.Count; i++)
        {
            dsMon[i].HienThi(i + 1);
        }
        Console.WriteLine("--------------------------");
        Console.ResetColor();
    }
    // xoá món
    public void XoaMon(int index)
    {
        if (index < 1 || index > dsMon.Count)
        {
            // sai thì thông báo lỗi
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("______________________");
            Console.WriteLine("Chỉ số món không hợp lệ!");
            Console.WriteLine("______________________");
            Console.ResetColor();
            return;
        }
        dsMon.RemoveAt(index - 1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("đã xoá món thành công!");
        Console.ResetColor();
        LuuMenu(); // lưu lại menu sau khi xoá món
    }
    // hiển thị chức năng
    public void HienThiChucNang()
    {
        while (true)
        {
            // luôn chạy lần đầu vì true 
            Console.WriteLine("-----Quản lý Menu-----");
            Console.WriteLine("1. Hiển thị danh sách món ăn");
            Console.WriteLine("2. Thêm món ăn");
            Console.WriteLine("3. Xoá món ăn");
            Console.WriteLine("4. Lưu file");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng (1-5): ");
            int chon;
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui lòng nhập số: ");
                continue;
            }
            // đi xử lý yêu cầu theo lựa chọn
            switch (chon)
            {
                case 1:
                    {
                        HienThiDsMon();
                        break;
                    }
                case 2:
                    {
                        // gọi thêm món 
                        Mon monMoi = new Mon();
                        monMoi.Nhap();
                        Add(monMoi);
                        break;
                    }
                case 3:
                    {
                        // gọi xoá món
                        Console.Write("Nhập chỉ số món cần xoá: ");
                        int index;
                        if (!int.TryParse(Console.ReadLine(), out index))
                        {
                            Console.WriteLine("Vui lòng nhập số: ");
                            continue;
                        }
                        XoaMon(index);
                        break;
                    }
                case 4:
                    {
                        // lưu file
                        LuuMenu();
                        break;
                    }
                case 5:
                    {
                        // thoát
                        Console.WriteLine("Thoát chương trình quản lý menu.");
                        return; // thoát hàm
                    }
                default:
                    {
                        Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                        break;
                    }
            }

        }
    }

    // khi nào cần menu? 
    public void LuuMenu()
    { // lưu lại dữ liệu vào file
        // lưu file json sẽ lưu dạng string
        // dữ liệu đang có dạng List<Mon> -> string , dùng thư viện hỗ trợ chuyển đổi : Newtonsoft.Json
        // chuyển List -> string dùng hàm SerializeObject của thư viện
        string json = JsonConvert.SerializeObject(dsMon);
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
            dsMon = JsonConvert.DeserializeObject<List<Mon>>(json);// nhận vào 1 chuỗi json và trả về đối tượng đã được chuyển đổi
                                                                   // List<Mon> là kiểu dữ liệu mà mình muốn chuyển đổi sang , json là chuỗi cần chuyển đổi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________");
            Console.WriteLine("Đọc menu JSON thành công!");
            Console.WriteLine("______________________");
            Console.ResetColor();
        }


    }
}