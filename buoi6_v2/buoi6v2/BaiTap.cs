public class BaiTap
{
    //Bài tập tìm độ dài từ cuối cùng trong chuôix 
    /*
    - Nhân vào 1 chuỗi từ người dùng
     VD: "Hello World", "      Hello World     ", "Hello World    Hello", " ", "nga"
          012345678910

     // DUYÊT QUA TỪNG KÝ TỰ 
    */
    public static void DoDaiTuCuoi()
    {
        // nhập chuỗi
        Console.Write("Nhập chuỗi: ");
        string chuoi = Console.ReadLine();

        // xóa khoảng trắng ở đầu và cuối chuỗi
        chuoi = chuoi.Trim();

        // đếm độ dài từ cuối cùng - là funtion tính độ dài của chuỗi sau khi đã xóa khoảng trắng ở đầu và cuối chuỗi
        int doDaiTuCuoi = TinhDoDai(chuoi);
        Console.WriteLine("Độ dài từ cuối cùng: " + doDaiTuCuoi);

    }
    public static int TinhDoDai(string chuoi)
    {
        int lastSpace = chuoi.LastIndexOf(" ");

        if (lastSpace == -1)
        {
            return chuoi.Length;
        }
        else
        {
            return chuoi.Length - lastSpace - 1;
        }
    }

    //CALLBACK FUNCTION
    // MỘT HÀM ĐƯỢC TRUYỀN VÀO LÀM THAM SỐ CHO HÀM KHÁC , VÀ SẼ ĐƯỢC GỌI TRONG HÀM ĐÓ
    // callback được truyền vào hàm TinhTong để hiển thị kết quả sau khi tính tổng
    //
    public static void TinhTong(int a, int b, Action<int> callback)
    {
        int tong = a + b; // cv A
        callback(tong); // xòn cv A thì gọi callback để hiển thị kết quả, cv B là callback sẽ được thực hiện sau khi cv A hoàn thành, cv B sẽ nhận kết quả của cv A (tổng) và hiển thị nó theo cách mà cv B đã định nghĩa (có thể đơn giản hoặc phức tạp tùy vào hàm callback được truyền vào)
    }
    public static void HienThiDonGian(int tong)
    {
        Console.WriteLine("Tổng: " + tong);
    }
    // phuc tap
    public static void HienThiDep(int tong)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Tổng của hai số a và b  là {tong}");
        Console.WriteLine("-----------------------------");
        Console.ResetColor();
    }

}