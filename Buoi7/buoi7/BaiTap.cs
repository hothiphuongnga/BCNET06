class BaiTap
{
    public static void TwoSum(int target)
    {
        List<int> nums = new List<int> { 2, 7, 11, 15 };
        bool found = false; // bật cờ tìm thấy hay chưa
                            // lần 1 số cần tìm là 9 - 2 = 7
                            // có số 7 thì lấy ra vị trí của số 7 , trả về mảng [vị trí của 2 và vị trí của 7]]

        for (int i = 0; i < nums.Count; i++)
        {
            // tìm hiệu số cần tìm 
            int complement = target - nums[i];

            for (int j = i; j < nums.Count; j++)
            {
                if (nums[j] == complement)
                {
                    // in ra i và j tương ứng với 2 giá trị cần tìm
                    Console.WriteLine($"[{i}, {j}]");
                    found = true; // bật cờ tìm thấy
                    break;
                }
            }
            if (found) break; // thoát vòng lặp ngoài nếu đã tìm thấy
        }
        if (!found) // nếu không tìm thấy thì in ra dong này
            Console.WriteLine("[-1, -1]");


    }

    // 
    public static void TwoSumDict(int target)
    {
        int a = 0;
        int a1 = 0;
        List<int> nums = new List<int> { 2, 7, 11, 15 };
        Dictionary<int, int> dict = new Dictionary<int, int>(); // lưu 
        // ds chứa key : giá trị của mảng , value : vị trí của giá trị đó trong mảng
        // chạy vòng lặp
        for (int i = 0; i < nums.Count; i++)
        {
            // nums[i] = 2
            // tìm xem trong dict có chứa số cần timnf hay không
            int need = target - nums[i]; // 9 - 2 = 7
            if (!dict.ContainsKey(need))
            {
                dict[nums[i]] = i; // thêm vào từ điển
            }
            // nếu có  tức là mình tìm thấy cặp số tương ứng
            else
            {

                Console.WriteLine($"[{dict[need]}, {i}]");
                break;
            }
        }
    }

    // Bài tập 3: nhập n sinh viên -> nhập điểm n SV -> in ds -> tính đtb, -> tìm min, max

    public static void BaiTapSinhVien()
    {
        // nhập số lượng sinh viên
        double n;
        bool isValid;
        do
        {
            Console.Write("Nhập số lượng SV: ");
            isValid = double.TryParse(Console.ReadLine(), out n);
        }
        while (!isValid); // còn sai thì nhập lại
        List<Dictionary<string, object>> listStudents = new List<Dictionary<string, object>>();
        // chyaj vòng lặp từ 1 đến n để nhâp điểm và tên SV 
        // Danh sách lưu có dạng List<Dictionary<string, double>>
        //  name: Nga
        // score: 9.5
        //


        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Nhập tên SV thứ {i}: ");
            string name = Console.ReadLine();
            double score;
            do
            {
                Console.Write($"Nhập điểm của {name}: ");
            }
            while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 10); // điểm phải từ 0 đến 10
            // tạo dictionary để lưu thông tin sv
            Dictionary<string, object> student = new Dictionary<string, object>();
            student["name"] = name;
            student["score"] = score;
            listStudents.Add(student); // thêm sv vào ds
        }
        // in ds
        // tính dtb
        double totalScore = 0;
        double minScore = (double)listStudents[0]["score"];
        double maxScore = (double)listStudents[0]["score"];
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("|            Danh sách sinh viên và điểm:           |");
        Console.WriteLine("----------------------------------------------------");
        foreach (var student in listStudents)
        {
            Console.WriteLine("" + student["name"] + " : " + student["score"]);
            totalScore += (double)student["score"];
            // tìm min , max
            var diem = (double)student["score"];
            if (diem > maxScore)
            {
                maxScore = diem;
            }
            if (diem < minScore)
            {
                minScore = diem;
            }

        }
        // tính dtb
        double averageScore = totalScore / n;
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Điểm trung bình của lớp là: {averageScore}");
        Console.WriteLine("----------------------------------------------------");



        // tìm min max
        Console.WriteLine($"Điểm cao nhất của lớp là: {maxScore}");
        Console.WriteLine($"Điểm thấp nhất của lớp là: {minScore}");

    }


    // 
    public static void ThamChieuThamTri()
    {
        // Value Type - kiểu giá trị
        // int, double , bool, char ,....
        // biến kiểu giá trị lưu trực tiếp giá trị trong stack, khi gán cho biến khác thì sẽ tạo bản sao và lưu ở địa chỉ khác, không ảnh hưởng lẫn nhau

        int a = 5;  // a được lưu trong stack với giá trị 5 . D/C của a là 0x01
        int b = a; // b được lưu trong stack với giá trị 5 (bản sao của a)  đia chỉ khác a 0x02
        b = 10;  // khi thay đổi giá trị của b thì không ảnh hưởng đến a, vì b là bản sao của a và có d/c khác
        Console.WriteLine($"a = {a}, b = {b}"); // a =
        // ref Type - kiểu tham chiếu
        // collection : array, list, dictionary , HashSet ,...
        // biến kiểu tham chiếu lưu địa chỉ của giá trị trong stack, khi gán cho biến khác thì cả 2 biến cùng tham chiếu đến 1 địa chỉ trong heap, khi thay đổi giá trị thông qua 1 biến thì biến còn lại cũng bị ảnh hưởng
        List<int> ints = new List<int>() { 1, 2, 3 }; // ints được lưu trong heap , d/c của ints là 0x03
        // d/c 0x03 chưa 3 địa chỉ (d/c cho ba giá trị bên trong)
        List<int> ints2 = ints;  // ints2 tham chiếu đến cùng d/c với ints là 0x03
        ints2.Add(4); // thêm phần vào d/c 0x03, 
        // in ra ds ints và ints2
        ints2.Add(5);
        ints.Add(6);
        Console.WriteLine($"Danh sách ints: {string.Join(", ", ints)}");
        Console.WriteLine($"Danh sách ints2: {string.Join(", ", ints2)}");


        // string cũng ref : string là kiểu tham chiếu nhưng có tính bất biến (immutable)
        string str1 = "Hello";
        string str2 = str1;
        str2 += " World";
        Console.WriteLine($"str1 = {str1}");
        Console.WriteLine($"str2 = {str2}");

    }

    public static void TypeDetermination()
    {
        // value type xác định kiểu tại thời gian biên dịch
        int a = 10;

        Console.ReadLine();

        // a  = "hello"; // lỗi biên dịch  , được xác ở thời gian biên dịch

        dynamic b = 10; // kiểu động xác định kiểu tại thời gian chạy
        Console.WriteLine(b + 20);
        b = "hello";

        // Console.WriteLine(b / 10); // lỗi chạy , vì không thể chia chuỗi cho số  

        object c = 10;
        Console.WriteLine((int)c + 20);
        c = "134"; // 

    }

    public static void TinhLoiNhuan()
    {
        // ds giá
        List<int> dsGia = new List<int>() { 10, 1, 2, 5, 3, 6, 4 };
        // tại dict
        Dictionary<int, int> dictPrices = new Dictionary<int, int>();
        // tính lợi nhuận tối đa 

        // ý tưởng : 
        /*
        Tìm giá thấp nhất
        Tính lợi nhuận lớn nhất bằng cách tính lợi từng ngày
        */
        int minPrice = dsGia[0];
        int ngayMuaThapNhat = 0;
        int maxProfit = 0;
        // int ngayMuaCaoNhat = 0;
        for (int i = 1; i < dsGia.Count; i++)
        {
            // tính lợi nhuận nếu bán vào ngày i
            int profit = dsGia[i] - minPrice;
            // cập nhật giá thấp nhất
            if (dsGia[i] < minPrice)
            {
                minPrice = dsGia[i]; // đổi min thành giá ngày hiện tại nếu giá ngày hiện tại thấp hơn
                ngayMuaThapNhat = i;
            }
            // cập nhật lợi nhuận tối đa 
            if (profit > maxProfit)
            {
                maxProfit = profit; // đổi lợi nhuận tối đa nếu lợi nhuận hiện tại lớn hơn
            }
            dictPrices[i] = profit;

        }
        // key là ngày thứ i : lợi nhuận tương ứng 
        // ngày thứ i 
        Console.WriteLine($"Lợi nhuận cao nhất là :{maxProfit}, mua ngày thứ {ngayMuaThapNhat + 1}, bán vào ngày {dictPrices.FirstOrDefault(x => x.Value == maxProfit).Key + 1}");

    }

    public static void TimSanhDaiNhat()
    {
        List<int> dsLaBai = new List<int>() { 100, 4, 200, 1, 3, 2, 9, 10, 15, 14, 13, 12, 11 };
        // xếp bài 
        // tìm sãnh dài nhất
        //sort
        dsLaBai.Sort(); // sắp xếp tăng dần
        // 1 2 3 4 5 
        int maxLength = 1;
        // duyệt ds đã sắp xếp
        // kiểm tra xem giá trị kế bên có phải là giá trị hiện tại + 1 không

        for (int i = 0; i < dsLaBai.Count -1; i++)
        {
            int lenght =1; // sãnh tại lần duyệt
            // lá hiện tại
            int currentCard = dsLaBai[i];
            // lá tiếp theo
            int j = i+1;
            int nextCard = dsLaBai[j];
            while(currentCard + 1 == nextCard)
            {
                // 2 3 4 5 7
                lenght++;

                // i++; // tăng biến đếm để không bị trùng khi gãy sãnh 
                currentCard = dsLaBai[j]; //
                j++; 
                // cần có điểm dừng cho while 
                nextCard = dsLaBai[j];
                if(j> dsLaBai.Count)
                {
                    break;
                }
            }
            i = j-1;

            if(lenght > maxLength)
            {
                maxLength = lenght;
            }
            
        }
        Console.WriteLine($"sãnh lớn nhất là {maxLength} lá");


    }
}