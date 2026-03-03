// KIỂU DỮ LIỆU HỢP
// ds vật phẩm cần mua
// ds nyc
// ds bạn bè
// ARRAY - DANH SÁCH CÁC PHẦN TỬ CÓ THỨ TỰ 
// là một tập hợp các phần tử có cùng kiểu dữ liệu, được lưu trữ liên tiếp trong bộ nhớ và có thể truy cập thông qua chỉ số (index).
// CÚ PHÁP : <kiểu dữ liệu>[] <tên mảng> = new <kiểu dữ liệu>[<số lượng phần tử>];
public class Collection
{
    public static void CollectionArray()
    {
        int[] mangSoNguyen = new int[5]; // tạo mảng số nguyên có 5 phần tử
        int[] mangSoNguyen2 = new int[] { 1, 2, 3, 4, 5 }; // tạo mảng số nguyên và khởi tạo giá trị  và có thể bỏ qua kích thước mảng vì đã khởi tạo giá trị 

        // ds tên bạn bè
        string[] dsTenBanBe = new string[] { "Mai", "Lan", "Cúc", "Trúc" };
        // index : vị đánh stt                0      1      2     3
        // reindex                            
        // truy xuất phần tử trong mảng : cú pháp : <tên mảng>[<chỉ số>]
        Console.WriteLine(dsTenBanBe[1]);
        // reindex
        Console.WriteLine($"phần tử cuối cùng: {dsTenBanBe[^1]}");

        // độ dài của mảng : số lượng phần tử trong mảng
        // thay đổi giá trị của phần tử trong mảng
        dsTenBanBe[2] = "Hương";
        Console.WriteLine(dsTenBanBe[2]);

        // duyệt qua mảng - xem ds 
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < dsTenBanBe.Length; i++)
        {
            Console.WriteLine(dsTenBanBe[i]);
        }
        Console.ResetColor();

        Console.WriteLine(dsTenBanBe[dsTenBanBe.Length]);// lỗi runtime
    }
    // LIST - DANH SÁCH CÁC PHẦN TỬ CÓ THỨ TỰ NHƯ MẢNG NHƯNG KHÔNG CẦN BIẾT TRƯỚC SỐ LƯỢNG PHẦN TỬ VÀ CÓ NHIỀU PHƯƠNG THỨC HỖ TRỢ
    public static void CollectionList()
    {

        //List<kieu_du_lieu> ten_list = new List<kieu_du_lieu>();
        List<string> dsHocVien2 = new List<string>(); // tạo list rỗng
        List<string> dsHocVien = new List<string> { "Nguyễn Dăn A", "Trần Thị B", "Lê Văn C" }; // tạo list và khởi tạo giá trị 
        // CRUD : Create - Read - Update - Delete
        // Create - thêm phần tử vào list
        dsHocVien.Add("Nguyễn Văn D"); // thêm phần tử vào cuối list
        //=> a b c d
        // Insert - thêm phần tử vào vị trí bất kỳ trong list
        dsHocVien.Insert(0, "Nguyễn Văn E"); // thêm phần tử vào vị trí 0 => e a b c d
        dsHocVien.Insert(2, "Nguyễn Văn F"); // thêm phần tử vào vị trí 2 => e a f b c d
        dsHocVien.AddRange("Nguyễn Văn G", "Trần Thị H"); // thêm nhiều phần tử vào cuối list => e a f b c d g h   
        dsHocVien.InsertRange(3, "Nguyễn Văn I", "Trần Thị K"); // thêm nhiều phần tử vào vị trí bất kỳ trong list => e a f i k b c d g h


        // UPdate
        dsHocVien[0] = "Nguyễn Văn X"; // thay đổi giá trị phần tử tại vị trí 0 => x a f i k b c d g h
                                       // Delete - xóa phần tử khỏi list
        dsHocVien.Remove("Nguyễn Văn X"); // xóa phần tử bằng giá trị=> a f i k b c d g h

        dsHocVien.RemoveAt(2); // xóa phần tử tại vị trí 2 => a f  k b c d g h
                               // Read - truy xuất phần tử trong list
                               // xoá nhiều
        dsHocVien.RemoveRange(3, 2);// nhận 2 giá trị từ vin trí 3 xoá 2 phần tử => a f k d g h
        // xoá theo điều kiện , xoá tên có chữ văn
        // dsHocVien.RemoveAll(x => x.Contains("Văn"));// xoá tất cả phần tử có chứa chữ "Văn" => f k d g h
        /*
        x => x.Contains("Văn")  tương đương với
        bool kiemTra(string x)
        {
            return x.Contains("Văn");
        }
        
        */

        for (int i = 0; i < dsHocVien.Count; i++)
        {
            Console.WriteLine("Học viên " + (i + 1) + ": " + dsHocVien[i]);
        }
        dsHocVien.ForEach(x => Console.WriteLine(x));

        // Find - tìm phần tử trong list
        // tìm phần tử đầu tiên có chứa chữ "d"
        string timKiem = dsHocVien.Find(x => x.ToLower().Contains("d"));// tìm phần tử đầu tiên có chứa chữ "d" => d
        Console.WriteLine("Kết quả tìm kiếm: " + timKiem);
        // tìm tất cả phần tử có chứa chữ "d"
        List<string> timKiemAll = dsHocVien.FindAll(x => x.ToLower().Contains("d"));// tìm tất cả phần tử có chứa chữ "d" => d g h
        Console.WriteLine("Kết quả tìm kiếm tất cả: ");
        timKiemAll.ForEach(x => Console.WriteLine(x));


    }
    public static void BTVanDungList()
    {
        List<int> lst = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

        //Tính tổng các số lớn hơn 50 trong danh sách
        // Yêu cầu: Viết chương trình tính tổng các số trong lstNumber mà lớn hơn 50.
        int TongLonHon50 = lst.FindAll(a => a > 50).Sum();
        Console.WriteLine("Tổng lớn hơn 50 " + TongLonHon50);

        // Đếm số phần tử lớn hơn 30
        // Yêu cầu: Viết chương trình đếm số phần tử trong danh sách lstNumber mà lớn hơn 30.
        int SoPhanTuLonHon30 = lst.Count(a => a > 30);
        Console.WriteLine("Đếm số phần tử lớn hơn 30: " + SoPhanTuLonHon30);
        // Tìm số lớn nhất trong danh sách
        // Yêu cầu: Viết chương trình để tìm số lớn nhất trong lstNumber.
        int SoLonNhat = lst.Max();
        Console.WriteLine("Số lớn nhất: " + SoLonNhat);
        // Tính trung bình cộng của các số lẻ
        // Yêu cầu: Viết chương trình để tính trung bình cộng của các số lẻ trong danh sách lstNumber.
        double TrungBinhCongSoLe = lst.Where(a => a % 2 != 0).Average();
        Console.WriteLine("Trung bình cộng các số lẻ: " + TrungBinhCongSoLe);
        // In ra các số chẵn trong danh sách
        List<int> SoChan = lst.FindAll(a => a % 2 == 0);
        SoChan.ForEach(x => Console.WriteLine(x));
    }

    // dictionnary
    /*
    - là một tập hợp các cặp khóa-giá trị, trong đó mỗi khóa duy nhất được ánh xạ đến một giá trị tương ứng.
    - CÚ PHÁP : Dictionary<kieu_khoa, kieu_gia_tri>
     VD : sst - tên 
     dictionary<int, string>  sttvaten = new Dictionary<int, string>();
     - không trung lặp key trong dictionary nhưng có thể trùng lặp value
        - truy xuất giá trị thông qua key
        - nên kiểm tra sự tồn tại của key trước khi truy xuất giá trị trong dictionary để tránh lỗi runtime
    */
    public static void CollectionDictionary()
    {
        Dictionary<int, string> studentDict = new Dictionary<int, string>();
        // key = 1 , value = "Nguyễn Văn A"
        // key = 2 , value = "Trần Thị B"
        // thêm key - value vào dictionary
        studentDict.Add(1, "Nguyễn Văn A");
        studentDict.Add(2, "Trần Thị B");
        studentDict.Add(3, "Lê Văn C");

        // truye xuất giá trị trong dictionary thông qua key
        Console.WriteLine(studentDict[1]);


        // cập nhật giá trị trong dictionary thông qua key
        studentDict[1] = "Nguyễn Văn X";


        // xoá
        studentDict.Remove(1);
        // duyệt dict
        foreach (var stu in studentDict)
        {
            Console.WriteLine($"Key {stu.Key} - Value {stu.Value}");
        }

        if (studentDict.ContainsKey(1))
        {
            Console.WriteLine(studentDict[1]);
        }
        if (studentDict.ContainsValue("Trần Thị B"))
        {
            Console.WriteLine("Tìm thấy giá trị Trần Thị B trong dictionary");
        }
    }
    /*
    HASHSET: là tập hợp chứa các phần tử duy nhất, không có thứ tự cụ thể và không cho phép trùng lặp. HashSet sử dụng hàm băm (hash function) để xác định vị trí lưu trữ của phần tử trong bộ nhớ, giúp tăng tốc độ truy cập và tìm kiếm.
    */
    public static void CollectionHashSet()
    {
        HashSet<int> numbers = new HashSet<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        Console.WriteLine(numbers.Count);
        numbers.Add(2);
        Console.WriteLine(numbers.Count);
        // kiểm tra sự tồn tại của phần tử trong HashSet
        if (numbers.Contains(2))
        {
            Console.WriteLine("Tìm thấy phần tử 2 trong HashSet");
            numbers.Remove(2);
        }


        // duyêt
        foreach (var i in numbers)
        {
            Console.WriteLine(i);
        }

        // gom 2 hashset lại với nhau

        HashSet<int> hashSet5 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> hashSet6 = new HashSet<int> { 4, 5, 6, 7, 8 };
        hashSet5.UnionWith(hashSet6);
        // hashSet5 sẽ chứa tất cả phần tử từ cả hai HashSet, nhưng không có phần tử nào bị trùng lặp. Kết quả sẽ là: { 1, 2, 3, 4, 5, 6, 7, 8 }

        // chuyển đổi
        List<int> ints = hashSet5.ToList();
        // list -> hashset
        List<int> lst = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        HashSet<int> hs7 = lst.ToHashSet();
        HashSet<int> hs8 = new HashSet<int>(lst);
        // chuyển list -> dict
        List<string> list3 = new List<string> { "Java", "C#", "Python", "PHP" };
        // 1: java, 2: C#, 3: Python, 4: PHP
        Dictionary<int, string> dictL3 = list3.ToDictionary(x => list3.IndexOf(x)+1, x => x);
        //  list3.IndexOf(x)+1: lấy ra index tại giá trị x + 1 
        // x tương ứng giá trị tại phần tử hiện tại trong list3,
        foreach (var item in dictL3)
        {
            Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
        }
        // chuyển dict -> list
        List<string> listFromDict = dictL3.Values.ToList(); // lấy ra tất cả giá trị trong dictL3 và chuyển thành list
        List<int> listKeyFromDict = dictL3.Keys.ToList(); // lấy ra tất cả key trong dictL3 và chuyển thành list

        // 1 list
        // ds các cặp key - value trong dictL3
        List<KeyValuePair<int, string>> listKeyValuePairs = dictL3.ToList();
        // chuyển hashset -> list


    }
}