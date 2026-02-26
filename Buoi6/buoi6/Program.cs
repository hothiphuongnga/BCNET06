public class Program
{
    public static void Main(string[] args)
    {
        // BaiTap.LengthOfLast();
        // GỌI HÀM XỬ LÝ HIỂN THỊ 
        // CẦN CÓ 1 CON SỐ VÀ 1 HÀM HIỂN THỊ
        // BaiTap.XuLyHienThi(7, BaiTap.HienThiKetQua);




        #region KIỂU DỮ LIỆU TẬP HƠP - COLLECTION --ARRAY
        // MẢNG - ARRAY: danh sách các phần tử có cùng kiểu dữ liệu , có kích thước cố định, truy xuất phần tử thông qua chỉ số index
        // ds số người trong 5 lớp
        // int[] dsSoNguoiTrongLop = new int[5]; // khai báo mảng có 5 phần tử kiểu int
        // int[] dsSoNguoiTrongLop2 = { 25, 30, 28, 32, 27 }; // khai báo mảng có 5 phần tử kiểu int và khởi tạo giá trị
        // //                            0   1   2   3   4    <- chỉ số index
        // // truy xuất phần tử trong mảng ~ giống với cách truy cập từng ký tự trong chuỗi 
        // int soNguoiLop1 = dsSoNguoiTrongLop2[0]; // lấy số người trong lớp đầu tiên
        // int soNguoiLopCuoi = dsSoNguoiTrongLop2[^1]; // lấy số người trong lớp đầu tiên


        // Console.WriteLine($"Số người trong lớp đầu tiên: {soNguoiLop1}");
        // Console.WriteLine($"Số người trong lớp cuối cùng: {soNguoiLopCuoi}");
        // // đội dài array
        // Console.WriteLine($"Độ dài mảng dsSoNguoiTrongLop2: {dsSoNguoiTrongLop2.Count()}");
        // Console.WriteLine($"Độ dài mảng dsSoNguoiTrongLop2: {dsSoNguoiTrongLop2.Length}");

        // // thay đổi giá trị trong mảng
        // dsSoNguoiTrongLop2[1] = 35; // thay đổi số người trong lớp thứ 2 thành 35
        // // duyệt mảng và in ra số người trong từng lớp
        // for (int i = 0; i < dsSoNguoiTrongLop2.Length; i++)
        // {
        //     Console.WriteLine($"Số người trong lớp thứ {i + 1}: {dsSoNguoiTrongLop2[i]}");
        // }
        // gán sai kiểu dữ liệu cho mảng
        // dsSoNguoiTrongLop2[0] = "abc"; // lỗi

        #endregion



        #region KIỂU DỮ LIỆU TẬP HỢP - COLLECTION -- LIST
        // Console.ForegroundColor = ConsoleColor.Green;
        // // LIST: danh sách các phần tử có cùng kiểu dữ liệu , có kích thước động, truy xuất phần tử thông qua chỉ số index
        // // Cú pháp: List<T> tênDanhSách = new List<T>(); trong đó T là kiểu dữ liệu của phần tử trong danh sách
        // List<string> dsTenHocVien = new List<string>(); // khai báo danh sách rỗng , chưa có phần tử nào
        // // ds tên các toà nhà chi nhánh cybersoft | Khai báo và khởi tạo giá trị luôn
        // List<string> dsToaNhaChiNhanh = new List<string>(){"112 Cao Thắng", "Trần Khắc Trân quận 1","Gò Vấp", "Thủ Đức", "Đà Nẵng"};
        // // CRUD : Create - Read - Update - Delete
        // // C - Create : thêm phần tử vào danh sách
        // dsTenHocVien.Add("Nguyễn Văn A"); // thêm học viên A vào danh sách
        // dsTenHocVien.Add("Trần Thị B"); // thêm học viên B vào danh sách
        // dsTenHocVien.Add("Lê Văn C"); // thêm học viên C vào danh sách
        // // thêm nhiều phần tử cùng lúc
        // dsTenHocVien.AddRange("Phạm Thị D", "Hoàng Văn E", "Vũ Thị F");

        // //Nguyễn Văn A, Trần Thị B, Lê Văn C, Phạm Thị D, Hoàng Văn E, Vũ Thị F
        // // 0                 1           2          3           4           5
        // // Insert : chèn phần tử vào vị trí bất kỳ trong danh sách

        // // chèn B2 vào giữa 1 và 2
        // dsTenHocVien.Insert(2, "B2");
        // // Nguyên văn A, Trần Thị B, B2, Lê Văn C, Phạm Thị D, Hoàng Văn E, Vũ Thị F
        // // 0                 1       2     3          4           5
        // // chèn C2, c3, c4 vào giữa C và D
        // dsTenHocVien.InsertRange(4, new List<string>() { "C2", "C3", "C4" });
        // // Nguyên văn A, Trần Thị B, B2, Lê Văn C, C2, C3, C4, Phạm Thị D, Hoàng Văn E, Vũ Thị F
        // // 0                 1       2     3          4    5   6   7           8           9
        // // chèn vào giữa 1 lần 1 mớ 
        // // R - Read : đọc / truy xuất phần tử trong danh sách / Duyệt mảng/danh sách
        // dsTenHocVien.ForEach(hv => Console.Write($"Học viên: {hv} ; "));
        // dsTenHocVien.ForEach(Console.WriteLine);
        // Console.WriteLine("");
        // // UPDATE - Sửa : sửa phần tử trong danh sách
        // dsTenHocVien[0] = "Nguyễn Văn Á";

        // // Xoá
        // // Remove
        // // dsTenHocVien.Remove("Nguyễn Văn Á"); // xoá bằng giá tri của phần tử
        // // dsTenHocVien.RemoveAt(0); // xoá bằng vị trí
        // //xoá nhiều
        // // dsTenHocVien.RemoveRange(2, 3); // xoá từ vị trí 2 , xoá 3 phần tử 

        // // xoá theo điều kiện
        // dsTenHocVien.RemoveAll(ten => ten.Contains("2") || ten.Contains("3") || ten.Contains("4")); // xoá tất cả học viên có tên chứa chữ "2"
        // // () => biểu thức lambda
        // // ten => ten.Contains("2")  ~ tương đương với hàm 
        // /*
        // bool KiemTra(string ten)
        // { 
        //     return ten.Contains("2");
        // }
        // */
        // // find - tìm kiếm 
        // // tìm kiếm và không làm thay đổi ds ban đầu
        // string hocVienNuSo1 = dsTenHocVien.Find(ten => ten.Contains("Thị")); // tìm học viên có tên chứa "Thị" // tìm phần tử đầu tiên
        // Console.WriteLine($"Học viên nữ số 1: {hocVienNuSo1}");

        // // ds học viên nữ 
        // var dsHVNu = dsTenHocVien.FindAll(t => t.Contains("Thị"));
        
        // Console.ForegroundColor = ConsoleColor.Yellow;

        // Console.WriteLine("Danh sách học viên nữ:");
        // dsHVNu.ForEach(Console.WriteLine);

//  Console.WriteLine("");
//         foreach (string s in dsTenHocVien){
//             Console.WriteLine($"Học viên (foreach): {s}");
//         }
//         Console.ResetColor();

        #endregion
    
        // BÀI TẬP Collection
        // BaiTap.BaiTapCollection();
        // BaiTap.LyThuyetDictionary();
        // BaiTap.LyThuyetHashSet();
        BaiTap.ChuyenDoi();

    
    
    }
}


/*
 danh sách học viên lớp net 06

 danh sách lớp dotnet của cybersoft


 tbêm học viên : thêm bạn Hoàng Anh vào lớp
 sửa : Bìn -> bình
 bớt học viên : xoá ngừoi ra khỏi lớp

*/