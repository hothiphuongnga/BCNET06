/* 
quản lý Công việc 
Danh sách nhiều cv (Tên , trạng thái, Hoàn thành(), hiển thị() )
 
 quản lý cv : thuộc tính là danh sách các task, thêm cv (), xóa cv(), hiển thị tất cả cv()

*/

public class Task
{
    public string TenTask { get; set; }
    public bool TrangThai { get; set; } // trạng thái : Chưa bắt đầu
    public Task(string ten)
    {
        TenTask = ten;
        TrangThai = false; // mặc định chưa hoàn thành
    }
    public void HoanThanh()
    {
        TrangThai = true;
    }
    public void HienThi(int index)
    {
        string trangThaiStr = TrangThai ? "Hoàn thành" : "Chưa hoàn thành";
        Console.WriteLine($"{index}. Công việc: {TenTask} - Trạng thái: {trangThaiStr}");
    } 

    // nhập liệu 

}


public class QuanLyTask
{
    // thuộc tính : danh sách các task
    public List<Task> DanhSachTask { get; set; } = new List<Task>(); // khởi tạo danh sách task rỗng

    public QuanLyTask()
    {
        // constructor
    }
    // phương thức : thêm cv (), xóa cv(), hiển thị tất cả cv()
    public void ThemTask(Task task)
    {
        // thêm task vào danh sách
        DanhSachTask.Add(task);
        // 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Đã thêm công việc: {task.TenTask}");
        Console.ResetColor();
    }
    public void HoanThanh(int index)
    {
        // đánh dấu công việc tại vị trí index là hoàn thành
        // kiểm tra index hợp lệ hay không 
        // index từ người dùng 

        // index đang nhận là số  
        // kiểm tra hợp lệ 
        var checkIndex = index - 1; // chuyển sang chỉ số mảng
        // nếu checkIndex < 0 hoặc > = độ dài mảng thì không hợp lệ
        if (checkIndex < 0 || checkIndex >= DanhSachTask.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chỉ số công việc không hợp lệ.");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;

        DanhSachTask[checkIndex].HoanThanh();
        Console.WriteLine("Hoàn thành task");
        Console.ResetColor();

    }
    // hiển thị tất cả cv
    public void HienThiTatCaTask()
    {
        Console.WriteLine("Danh sách công việc:");
        for (int i = 0; i < DanhSachTask.Count; i++)
        {
            DanhSachTask[i].HienThi(i + 1);
        }
    }

    // hiển thị ds chức năng 
    public void HienThiChucNang()
    {
        int chon = 0;

        // chạy vòng lặp nếu chọn = 4 thì thoát còn chọn kahcs 4 thì thực hiện chức năng tương ứng
        do
        {
            Console.WriteLine("Chức năng quản lý công việc:");
            Console.WriteLine("1. Thêm công việc");
            Console.WriteLine("2. Hoàn thành công việc");
            Console.WriteLine("3. Hiển thị tất cả công việc");
            Console.WriteLine("4. Thoát");
            var checkINput = int.TryParse(Console.ReadLine(), out chon);
            if (!checkINput) // không chuyển được kiểu
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vui lòng nhập số từ 1 đến 4");
                Console.ResetColor();
                continue;
            }
            if (chon == 4)
            {
                Console.WriteLine("Thoát chương trình quản lý công việc.");
                break;
            }

            // nếu =1 thì gọi phương thúcq Themtask
            switch (chon)
            {
                case 1:
                    Console.WriteLine("thêm task");
                    // tạo task từ input
                    Console.Write("Nhập tên công việc: ");
                    string tenTask = Console.ReadLine();
                    Task cv = new Task(tenTask);
                    ThemTask(cv);
                    break;
                case 2:
                    Console.WriteLine("hoàn thành task");
                    // gọi hàm hoàn thành task 
                    // lấy vị trí từ input 
                    HienThiTatCaTask();
                    Console.Write("Nhập số thứ tự công việc đã hoàn thành: ");
                    int index;
                    var checkIndex = int.TryParse(Console.ReadLine(), out index);
                    // kiểm tra phải số hay không
                    HoanThanh(index);
                    break;
                case 3:
                    Console.WriteLine("show thông tin");
                    HienThiTatCaTask();
                    break;
                default:
                    Console.WriteLine("không hiểu"); break;

            }













        } while (chon != 4);

    }
}