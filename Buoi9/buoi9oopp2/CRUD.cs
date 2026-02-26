using System.Reflection;

public class CRUD<T> where T: class// T là kiểu dữ liệu mà mình muốn sử dụng khi khởi tạo đối tượng từ class này. Có thể thay T bằng bất kỳ tên nào khác, nhưng T thường được sử dụng để đại diện cho "Type" (kiểu dữ liệu).
{
    public List<T> Items { get; set; } = new List<T>();
    

    // constructor
    public CRUD()
    {
        // Items.Add(new T());// không khởi t = new dc 
        Items.Add(Activator.CreateInstance(typeof(T)) as T);
    }

    // Create // items.Add

    public void Add(T item)
    {
        // thêm T vào list<T>
        Items.Add(item);
        Console.WriteLine("Thêm thành công!");   
    }

    // xoá 
    public void Remove(int idx)
    {
        if (idx < 1 || idx > Items.Count)
        {
            Console.WriteLine("Chỉ số không hợp lệ!");
            return;
        }
        Items.RemoveAt(idx);
        Console.WriteLine("Xoá thành công!");
    }


    // show ds
    public void Show()
    {
        Console.WriteLine("Danh sách:");
        for (int i = 0; i < Items.Count; i++)
        {
            // in ra tên của từng item
            // Console.WriteLine($"{i + 1}. {Items[i]}");
            // sử dụng phương show thông tin của từng item tương ứng. VD : tên , tuổi , ...
            // lấy ra ds các thuộc tính của từng item 
            PropertyInfo[] dsThuocTinh = typeof(T).GetProperties(); // lấy ra ds các thuộc tính của kiểu dữ liệu T
            // VD : nếu T là Mentor thì sẽ lấy ra được các thuộc tính Ten , Tuoi , VaiTro , HeSoLuong
            // nếu T là Mon thì sẽ lấy ra được các thuộc tính TenMon , GiaTien
            // sau đó chạy lặp qua ds các thuộc tính đó để in ra thông tin
             foreach (var thuocTinh in dsThuocTinh)
            {
             Console.WriteLine($"{thuocTinh.Name}: {thuocTinh.GetValue(Items[i])}");  
            }
        }
    }

     // update



    //tìm kiếm
}


public class CRUD2<T> where T : IHienThi
{
    
}