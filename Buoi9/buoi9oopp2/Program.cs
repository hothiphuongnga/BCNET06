class Program
{
    public static void Main(string[] args)
    {
        // gọi hàm từ class khách

        //    QuanLyMenu qlMenu = new QuanLyMenu();
        //    qlMenu.HienThiChucNang();

        // khởi tạo 1 người dùng
        // NguoiDung nd = new NguoiDung();
        // nd.Ten = "Nguyễn Văn A";
        // nd.Tuoi = 25;
        // nd.VaiTro = "Vai trò chung";
        // // nd.BiMat = "54321"; // lỗi vì BiMat là private

        // nd.HienThi();

        // Mentor phat = new Mentor();
        // phat.Ten = "Lê Văn Phát";
        // phat.Tuoi = 10;
        // phat.HienThi();
        // phat.ChamBai();
        // phat.DiemDanh();
        // // phat.BiMat = "54321"; // lỗi vì BiMat là private của class NguoiDung
        // // phat.ChiaKhoa = "XYZ"; // lỗi vì ChiaKhoa là protected của class NguoiDung



        // // khởi tạo người dùng với constructor có tham số
        // NguoiDung nd2 = new NguoiDung("Trần Thị B", 22, "Học viên");
        // Mentor mentor2 = new Mentor("Phạm Văn C", 30, "Mentor", 5);



        // L1 l1 = new L1();
        // // l1.SanChoi = "Sân chơi của L1"; // lỗi vì SanChoi là protected của class ChungCu




        // NhanVienKinhDoanh nvkd = new NhanVienKinhDoanh();

        // GENERIC TYPE
        var hop1 = new BlindBox<string>(); // khởi tạo đối tượng từ class BlindBox với kiểu dữ liệu là string
         hop1.Ten = "Món đồ chơi bất ngờ"; // gán giá trị cho thuộc tính Ten của đối tượng hop1, giá trị này có kiểu dữ liệu là string
         hop1.HienThi();
         var hop2 = new BlindBox<Mentor>(); // khởi tạo đối tượng từ class BlindBox với kiểu dữ liệu là Mentor
         hop2.Ten = new Mentor();// gán giá trị cho thuộc tính Ten của đối tượng hop2, giá trị này có kiểu dữ liệu là Mentor
         hop2.HienThi();



        // CRUD
        var quanLyMon = new CRUD<NguoiDung>();
        quanLyMon.Add(new NguoiDung());
        quanLyMon.Add(new NguoiDung());
        quanLyMon.Add(new NguoiDung());
        
        quanLyMon.Show();

        // CRUD Mentor 
        var quanLyMentor = new CRUD<Mentor>();
        quanLyMentor.Add(new Mentor("Phạm Văn C", 30, "Mentor", 5));
        quanLyMentor.Add(new Mentor());
        quanLyMentor.Add(new Mentor());
        quanLyMentor.Show();


        // // ql ds string
        var quanLyString = new CRUD<string>();
        // quanLyString.Add("Hello");
        // quanLyString.Add("World");
        // quanLyString.Show();

// var qlhourse = new CRUD2<NguoiDung>(); // lỗi vì NguoiDung không implement interface IHienThi
var qlHinhVuong = new CRUD2<HinhVuong>(); // lỗi vì NguoiDung không implement interface IHienThi




// ACTIVATOR
    // khởi tạo không dùng new mà dùng Activator

    // HinhVuong
    var hv1 = new HinhVuong(); // khởi tạo bằng new
    var hv2 = Activator.CreateInstance(typeof(HinhVuong));// khởi tạo bằng Activator

var hv3 = Activator.CreateInstance<HinhVuong>();

    }




    /*
    PREVIEW OOP 
    4 tính chất
    1. Tính đóng gói (Encapsulation): Đóng gói dữ liệu và phương thức liên quan vào một đơn vị (class) để bảo vệ dữ liệu và kiểm soát truy cập.
    2. Tính kế thừa Inheritance: Cho phép tạo ra một class mới dựa trên một class đã tồn tại, kế thừa các thuộc tính và phương thức của class cha.
    3. Đa hình Polymorphism : 1 phương có nhiều cách thể thiện khác nhau  thể hiện qua virtual / override, 
    4. Tính tr tượng Abstraction :Ẩn chi tiết và chỉ hiển thị các tính năng quan trọng. abstract và interface
    
    */





}

// contructor : 
// Khi 1 class không định nghĩa contructo thì sẽ có 1 contructor mặc định không tham số được tự động tạo ra bởi trình biên dịch, có nhiệm vụ khởi tạo các thuộc tính của đối tượng với giá trị mặc định (null, 0, false,...).
// từ khoá base
// từ khoá virtual : cho phép phương thức của lớp cha có thể bị ghi đè bởi lớp con, để tạo ra tính đa hình
// từ khoá override: cho phép lớp con ghi đè lại phương thức của lớp cha đã được đánh dấu là virtual, để cung cấp một triển khai cụ thể hơn cho phương thức đó trong lớp con.
// từ khoá abstract : dùng để khai báo một lớp trừu tượng hoặc một phương thức trừu tượng, lớp trừu tượng không thể được khởi tạo và có thể chứa các phương thức trừu tượng mà các lớp con phải triển khai.
// từ khoá interface: dùng để khai báo một giao diện, định nghĩa các phương thức và thuộc tính mà các lớp thực thi (implement) phải triển khai, cho phép tạo ra tính đa kế thừa trong C#.
// kế thừa : đơn kế thừa.
// sealed: chặn kế thừa, chặn ghi đè phương thức

// static : từ khoá static được sử dụng để khai báo các thành phần tĩnh (thuộc về lớp, không thuộc về đối tượng), có thể truy cập mà không cần tạo đối tượng của lớp.
/*
public class NhanVien
{
    public static int Count =0;

    ....
}
Console.WriteLine(NhanVien.Count); // truy cập biến static mà không cần tạo đối tượng

*/ 

