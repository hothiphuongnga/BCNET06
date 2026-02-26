// Name, Health, Power, IsAlive, 
// Nhảy(), chạy()
// bị tấn công -> giảm máu
// trúng đạn -> giảm 1 mạng
// ăn nấm -> tăng mạng và tăng sức mạnh
public class Mario
{
    // static thuộc tính
    // thuộc tính thuộc về class , thuộc về cái "khuôn" 
    public static int TongSoMario = 0;
    public static string TenNguoiChoi = "Người chơi 01";

    // thuộc tính thuộc về instance
    public string Name { get; set; } = "Mario";
    public int Health { get; set; }
    public int Power { get; set; }
    public bool IsAlive { get; set; }

    public int SoMang { get; private set; } = 3; // mặc định có 3 mạng
    // không cho gán giá trị khi ở bên ngoài lớp

    // mật khẩu, OTP, token, 
    // 111111  -> kdsfjkdsfj32748jkjk453ưhkjkasdjhaskfdhas

    // 111111 -> iiiiuiuyeasghdvzscjhasjdhaskdkjfsdkfsdkf 




    public string MaBiMat { private get; set; } // chỉ cho phép lấy giá trị bên trong lớp


    // contructor
    public Mario()
    {
        // Constructor
        IsAlive = true;
        Health = 100;
        Power = 10;

        // mỗi khi tạo ra 1 mario thì tăng tổng số mario lên 1
        TongSoMario++;
    }
    public Mario(string name, int health, int power, bool isAlive)
    {
        Name = name;
        Health = health;
        Power = power;
        IsAlive = isAlive;

        // mỗi khi tạo ra 1 mario thì tăng tổng số mario lên 1
        TongSoMario++;
    }

    // static contructor
    static Mario()
    {
        // được gọi 1 lần duy nhất khi lần đầu tiên truy cập vào class Mario
        // nó sẽ chạy trước cả contructor thường //
        // chỉ có thể truy cập các thuộc tính static
        Console.WriteLine("Lần khởi tạo static đầu tiên của class Mario");


    }

    // phương thúc static
    public static void ShowTotalMarios()
    {
        // chỉ có thể truy cập các thuộc tính static
        // Console.WriteLine($"Tổng số Mario hiện tại: {TongSoMario}");
        // show tên Mario 
        // Console.WriteLine(Name); // lỗi vì Name không phải static
        Console.WriteLine($"Tổng số Mario hiện tại: {TongSoMario}");
        Console.WriteLine($"Xin chào người chơi : {TenNguoiChoi}");

    }


    // phương thức

    public void Jump()
    {
        Console.WriteLine($"{Name} is jumping!");
    }
    public void Run()
    {
        Console.WriteLine($"{Name} is running!");
    }

    // bị tấn công
    public void TakeDamage(int damage)
    {
        Health -= damage; // giảm máu
        if (Health <= 0)
        {
            IsAlive = false;
            Console.WriteLine($"{Name} has lost all health.");
            Console.WriteLine($"{Name} has died.");
        }
        else
        {
            Console.WriteLine($"{Name} took {damage} damage, remaining health: {Health}");
        }
    }
    // ăn nấm
    public void EatMushroom(int healthBoost)
    {
        Health += healthBoost;
        Console.WriteLine($"{Name} ate a mushroom! Health increased to {Health}");
    }
    // hàm tăng giảm mạng 
    public void ChangeLives(int amount)
    {
        SoMang += amount;
        if (SoMang < 0)
        {
            SoMang = 0;
        }
        Console.WriteLine($"{Name} now has {SoMang} lives.");
    }
}