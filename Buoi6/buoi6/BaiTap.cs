class BaiTap
{
    public static void LengthOfLast()
    {
        // nhập chuỗi từ bàn phím
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine();
        // tính độ dài của từ cuối cùng trong chuỗi
        var kq = DoDaiTuCuoiCung(str);
        // in ra độ dài
        Console.WriteLine($"Độ dài từ cuối cùng: {kq}");
    }

    public static int DoDaiTuCuoiCung(string str)
    {
        // "CHuỗi nhận vào"
        // "   CHuỗi nhận vào   " -> Trim() -> "CHuỗi nhận vào"
        //  
        str = str.Trim(); // loại bỏ khoảng trắng đầu và cuối chuỗi
        // viết hàm tính độ dài từ cuối cùng của chuỗi
        if (str.Length == 0) // nếu chuỗi rỗng sau khi loại bỏ khoảng trắng
        {
            return 0; // trả về độ dài là 0
        }
        //
        // .LastIndexOf(" ) 
        int lastSpaceIndex = str.LastIndexOf(" "); // tìm vị trí khoảng trắng cuối cùng trong chuỗi


        if (lastSpaceIndex == -1) // nếu không tìm thấy khoảng trắng nào , nghĩa là chuỗi chỉ có một từ
        {
            return str.Length; // trả về độ dài của chuỗi
        }
        else
        {
            return str.Length - lastSpaceIndex - 1; // tính độ dài từ cuối cùng
        }

    }

    // CALLBACK FUNCTION
    // LÀ HÀM ĐƯỢC TRUYỀN QUA LÀM THAM SỐ CHO HÀM KHÁC
    public static void XuLyHienThi(int so, Action<int> hienThi) // hàm nhận vào con số và hàm hiển thị để show thông tin
    {
        // tính bình phương số và gọi hàm hiển thị để hiển thị kết quả
        int ketQua = so * so;

        hienThi(ketQua);
    }

    public static void HienThiKetQua(int so) // hàm hiển thị kết quả
    {
        Console.WriteLine($"Con số may mắn là: {so}");
    }


    // lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
    public static void BaiTapCollection()
    {
        List<int> lst = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        //Tính tổng các số lớn hơn 50 trong danh sách

        var tongLonHon50 = 0;
        var tongLonHon50C2 = 0;
        //
        var dsLonHon50 = lst.FindAll(x => x > 50); // tìm tất cả số lớn hơn 50
        // .Sum()
        tongLonHon50 = dsLonHon50.Sum();
        // duyệt qua ds list và tính tổng
        foreach (var tongLonHon in dsLonHon50)
        {
            tongLonHon50C2 += tongLonHon;
        }
        Console.WriteLine($"Tổng các số lớn hơn 50 là: {tongLonHon50}");
        Console.WriteLine($"Tổng các số lớn hơn 50 C2 là: {tongLonHon50C2}");
        // 2. Đếm số phần tử lớn hơn 30
        var demLonHon30 = lst.Count(x => x > 30);
        Console.WriteLine($"Số phần tử lớn hơn 30 là: {demLonHon30}");
        // 3. Tìm số lớn nhất trong danh sách
        var soLonNhat = lst.Max();
        Console.WriteLine($"Số lớn nhất trong danh sách là: {soLonNhat}");
        // chạy vòng lặp để tìm số lớn nhất
        var soLonNhatC2 = lst[0];
        foreach (var so in lst)
        {
            if (so > soLonNhatC2)
            {
                soLonNhatC2 = so;
            }
        }
        Console.WriteLine($"Số lớn nhất trong danh sách C2 là: {soLonNhatC2}");


        // 4. Tính trung bình cộng của các số lẻ
        // ds số lẻ 
        var dsSoLe = lst.FindAll(x => x % 2 != 0); // tìm tất cả số lẻ
        double tbc = dsSoLe.Sum() / (double)dsSoLe.Count();
        // chia hai số nguyên -> kết quả là số nguyên
        Console.WriteLine($"Trung bình cộng của các số lẻ là: {tbc}");
        // 5. In ra các số chẵn trong danh sách
        var dsSoChan = lst.FindAll(x => x % 2 == 0); // tìm tất cả số chẵn
        Console.WriteLine("Các số chẵn trong danh sách là: ");
        dsSoChan.ForEach(x => Console.WriteLine($"{x}, "));





    }


    public static void LyThuyetDictionary()
    {

        //Dictionary chứa danh sách các cặp key- value
        /*
        Ví dụ : key : Mã sinh viên , value: Tên sinh viên
                key: CCCD, value : thông tin của chủ thẻ (tên , ngày sinh, địa chỉ..)

        key phải là duy nhất , không được trùng lặp
        value có thể trùng lặp
        CÚ PHÁP KHAI BÁO:
        Dictionary<kiểu dữ liệu key, kiểu dữ liệu value> tên biến =  new Dictionary<kiểu dữ liệu key, kiểu dữ liệu value>();
        tốc độ truy xuất nhanh hơn List , Array , vì truy cập thông qua key
        
        -> không có thứ tự index như List, Array
        VD sử dụng: list : ds sinh viên dự thi có stt
                    dictionary: sdt trong danh bạ : tên người dùng tương ứng
        - truy cập key không tồn tại sẽ lỗi
        */
        // khai báo Dictionary chứa danh sách sinh viên với key là mã sinh viên (int) và value là tên sinh viên (string)
        Dictionary<int, string> dsSinhVien = new Dictionary<int, string>();
        // Thêm phần tử vào Dictionary
        dsSinhVien.Add(1, "Nguyễn Văn A");
        dsSinhVien.Add(2, "Trần Thị B");
        dsSinhVien.Add(3, "Lê Văn C");

        // Truy cập phần tử trong Dictionary thông qua key 
        // truy cập sinh viên có key =1
        string tenSv1 = dsSinhVien[1]; // lấy tên sinh viên có mã sinh viên là 1
        Console.WriteLine($"Tên sinh viên có mã 1 là: {tenSv1}");

        // ds bệnh nhân với key là số bệnh án (string) và value là tên bệnh nhân (string)
        Dictionary<string, string> dsBenhNhan = new Dictionary<string, string>();
        // thêm bệnh nhân vào ds
        dsBenhNhan.Add("BN001", "Phạm Thị D");
        dsBenhNhan.Add("BN002", "Hoàng Văn E");
        // truy cập bệnh nhân có số bệnh án là BN002
        var tenBenhNhan = dsBenhNhan["BN002"];
        Console.WriteLine($"Tên bệnh nhân có số bệnh án BN002 là: {tenBenhNhan}");

        // dsBenhNhan.Remove("BN001"); // xoá bệnh nhân có số bệnh án BN001 khỏi ds
        var res = dsBenhNhan.Where(x => x.Key == "BN002"); // tìm kiếm bệnh nhân có số bệnh án BN002 ,


        // Console.WriteLine(dsBenhNhan["sdfdsf"]); // lỗi key không tồn tại 
        // kiểm tra key có tồn tại trong Dictionary không
        bool coBN003 = dsBenhNhan.ContainsKey("BN003"); // kiểm tra key BN003 có tồn tại không
        if (coBN003)
        {
            // xoá / in thông tin
            dsBenhNhan.Remove("BN003");
        }
        // duyệt dsBenhNhan và in ra thông tin bệnh nhân
        foreach (var bn in res)
        {
            Console.WriteLine($"[WHERE] Số bệnh án: {bn.Key}, Tên bệnh nhân: {bn.Value}");
        }
        foreach (var bn in dsBenhNhan)
        {
            Console.WriteLine($"Số bệnh án: {bn.Key}, Tên bệnh nhân: {bn.Value}");
        }


        // Dictionary dạng string , object
        Dictionary<string, object> thongTinNguoiDung = new Dictionary<string, object>();
        thongTinNguoiDung.Add("H3oTen", "Nguyễn Văn A");
        thongTinNguoiDung.Add("Tuoi", 25);
        thongTinNguoiDung.Add("DiemTB", 8.5);
        thongTinNguoiDung.Add("GioiTinh", true); // true: nam, false: nữ
        thongTinNguoiDung.Add("DiaChi", "12 Đường ABC, Quận 1, TP.HCM");


        foreach (var item in thongTinNguoiDung)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

    }

    public static void LyThuyetHashSet()
    {
        // HashSet: tập hợp các phần tử duy nhất , không trùng lặp , không có thứ tự index
        // CÚ PHÁP KHAI BÁO:
        // HashSet<kiểu dữ liệu> tên biến = new HashSet<kiểu dữ liệu>();
        HashSet<string> tinhThanhPho = new HashSet<string>(); // khai báo HashSet rỗng
        // khai báo và khởi tạo giá trị luôn
        HashSet<string> dsMauSac = new HashSet<string>() { "Đỏ", "Xanh", "Vàng", "Đen", "Trắng", "Đỏ" };
        // Phần tử "Đỏ" bị trùng lặp nên chỉ được thêm một lần duy nhất
        // Thêm phần tử vào HashSet
        tinhThanhPho.Add("Hà Nội");
        tinhThanhPho.Add("TP.HCM");
        tinhThanhPho.Add("Đà Nẵng");
        tinhThanhPho.Add("Hà Nội"); // phần tử trùng lặp , không được thêm vào
                                    // truy cập phần tử trong HashSet
        bool coMauDen = dsMauSac.Contains("Đen"); // kiểm tra
        string ketQua = coMauDen ? "có" : "không có";
        Console.WriteLine($"Có màu Đen trong dsMauSac: {ketQua}");




        // Clear(): xoá tất cả phần tử trong HashSet
        // dsMauSac.Remove("Đen"): xoá phần tử cụ thể trong HashSet
        dsMauSac.Remove("Đen");
        dsMauSac.Remove("Đen"); // xoá phần tử không tồn tại , không lỗi 
        // hơp nhất 2 HashSet  UnionWith
        // [2,4 5 ] U [4,5,6] = [2,4,5,6]
        HashSet<int> setA = new HashSet<int>() { 2, 4, 5 };
        HashSet<int> setB = new HashSet<int>() { 4, 5, 6 };
        setA.UnionWith(setB); // hợp nhất setB vào setA
        Console.WriteLine("--------------");
        Console.WriteLine("Các phần tử trong setA sau khi hợp nhất với setB:");
        foreach (var so in setA)
        {
            Console.Write($"Số: {so}, ");
        }



        Console.WriteLine("--------------");

        // duyệt HashSet và in ra các màu sắc
        foreach (var mau in dsMauSac)
        {
            Console.WriteLine($"Màu sắc: {mau}");
        }
        Console.WriteLine("--------------");
        foreach (var tp in tinhThanhPho)
        {
            Console.WriteLine($"Tỉnh/Thành phố: {tp}");
        }


    }

    public static void ChuyenDoi()
    {

        // Hashset -> List
        HashSet<int> hashsetSo = new HashSet<int>() { 1, 2, 3, 4, 5 };
        List<int> listSo = hashsetSo.ToList(); //    == chuyển HashSet sang List  chỉ cần .ToList() là xong
        Console.WriteLine("--------");
        foreach (var so in listSo)
        {
            Console.WriteLine($"Số trong List: {so}");
        }
        // list -> HashSet qua .ToHashSet() có lọc trùng
        List<int> listSoTrung = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> hashsetSoTrung = listSoTrung.ToHashSet(); // chuyển List sang HashSet , tự động lọc trùng
        Console.WriteLine("--------");
        foreach (var so in hashsetSoTrung)
        {
            Console.WriteLine($"Số trong HashSet: {so}");
        }

        // Dictionary<key, value> 
        // list key
        // list value
        // -> List<KeyValuePair<key, value>>
        Dictionary<int, string> dsSinhVien = new Dictionary<int, string>()
        {
            {1, "Nguyễn Văn A" },
            {2, "Trần Thị B" },
            {3, "Lê Văn C" }
        };
        List<int> lstKey = dsSinhVien.Keys.ToList(); // lấy danh sách key và chuyển thành List
        List<string> lstValue = dsSinhVien.Values.ToList(); // lấy danh sách value
        Console.WriteLine("--------");

        List<KeyValuePair<int, string>> dictTolst = dsSinhVien.ToList();// chuyển Dictionary thành List<KeyValuePair< key, value>>
        // keyValuePair:  là kiểu dữ liệu đại diện cho một cặp key-value trong Dictionary , là 1 kiểu dữ liệu cấu trúc `struct` ? 



    }
}