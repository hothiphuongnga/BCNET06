using System.Runtime.Intrinsics.Arm;
using Newtonsoft.Json;

public class QuanLyNhanVien
{
    public List<NhanVien> Items = new List<NhanVien>();
    public static string duongDan = "nhanvien.json";
    public QuanLyNhanVien()
    {
        DocFile();
    }

    // thêm
    public void Them(NhanVien nv)
    {
        Items.Add(nv);
        Console.WriteLine("Them nv thanh cong");
        LuuFile();
    }

    // tìm kiếm theo tên
    public void TimKiemTheoTen(string ten)
    {
        var ketQua = Items.Where(nv => nv.Ten.Contains(ten)).ToList();
        if (ketQua.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm:");
            foreach (var nv in ketQua)
            {
                nv.HienThiThongTin();
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên với tên đó");
        }
    }
    // xoá
    public void Xoa(int maNhanVien)
    {
        var nv = Items.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
        if (nv != null)
        {
            Items.Remove(nv);
            Console.WriteLine("Xóa nhân viên thành công");
            LuuFile();
        }
    }
    // sửa tên
    // ma nhân viên cần sửa và tên mới
    // tim xem có nhân viên với mã đó hay không , có thì update lại
    public void SuaTen(int maNhanVien, string tenMoi)
    {
        // tìm nhân viên theo mã
        var nv = Items.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
        // nếu có thì thây đổi tên
        if (nv != null)
        {
            nv.Ten = tenMoi;
            Console.WriteLine("Sua ten thanh cong");
            LuuFile();
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên với mã đó");
        }

    }
    // SHOW DS
    public void HienThiDS()
    {
        foreach (var nv in Items)
        {
            nv.HienThiThongTin();
        }
    }

    // hiển thị menu chức năng
    public void HienThiMenu()
    {
        int chon;
        do
        {

            Console.WriteLine("______________________");
            Console.WriteLine("QUẢN LÝ NHÂN VIÊN");
            Console.WriteLine("______________________");
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Tìm kiếm nhân viên theo tên");
            Console.WriteLine("3. Xoá nhân viên");
            Console.WriteLine("4. Sửa tên nhân viên");
            Console.WriteLine("5. Hiển thị tất cả nhân viên");
            Console.WriteLine("6. Lưu file");
            Console.WriteLine("7. Đọc file");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    var nv = new NhanVien();
                    nv.NhapThongTin();
                    Them(nv);
                    break;
                case 2:
                    Console.Write("Nhập tên nhân viên cần tìm: ");
                    var ten = Console.ReadLine();
                    TimKiemTheoTen(ten);

                    break;
                case 3:
                    Console.Write("Nhập mã nhân viên cần xoá: ");
                    var maNhanVien = int.Parse(Console.ReadLine());
                    Xoa(maNhanVien);
                    break;
                case 4:
                    Console.Write("Nhập mã nhân viên cần sửa: ");
                    var maNV = int.Parse(Console.ReadLine());
                    Console.Write("Nhập tên mới: ");
                    var tenMoi = Console.ReadLine();
                    SuaTen(maNV, tenMoi);
                    break;
                case 5:
                    Console.WriteLine("Danh sách nhân viên:");
                    HienThiDS();
                    break;
            }



        } while (chon != 0);


        // xuwr lys chon vaf goij hafm tuong ung 

    }
    //  lưu file
    public void LuuFile()
    { // lưu lại dữ liệu vào file
        // lưu file json sẽ lưu dạng string
        // dữ liệu đang có dạng List<Mon> -> string , dùng thư viện hỗ trợ chuyển đổi : Newtonsoft.Json
        // chuyển List -> string dùng hàm SerializeObject của thư viện
        string json = JsonConvert.SerializeObject(Items, Formatting.Indented, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All // thêm thông tin kiểu vào JSON để hỗ trợ khi đọc lại
        });
        // lưu string vào file
        // nhận hai tham số : đường dẫn và nội dung cần lưu
        File.WriteAllText(duongDan, json);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("______________________");
        Console.WriteLine("Lưu menu JSON thành công!");
        Console.WriteLine("______________________");
        Console.ResetColor();
    }

    public void DocFile() // đọc dữ liệu từ file , không cần lấy data cứng từ contructor nữa
    {
        if (File.Exists(duongDan))
        {
            // nếu như file tồn tại thì mình đọc
            var json = File.ReadAllText(duongDan);
            // json đang là string , muốn chuyển thành List<Mon> dùng hàm DeserializeObject
            Items = JsonConvert.DeserializeObject<List<NhanVien>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All // sử dụng cùng cài đặt với khi lưu file
            });
            // nhận vào 1 chuỗi json và trả về đối tượng đã được chuyển đổi
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