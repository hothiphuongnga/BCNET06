/*
Chặn kế thừa class: seal class
- không cho phép class khác kế thừa từ class đã được đánh dấu sealed




*/
public sealed class TaiSan
{
    public double GiaTri { get; set; } = 0;
    public void Show()
    {
        Console.WriteLine("Class A sealed - Chặn kế thừa");
    }
}

// public class TaiSanKeThua : TaiSan // lỗi vì TaiSan đã bị chặn kế thừa
// {
    
// }


/*
chặn ghi đè phương thức : sealed method



*/

public class User // ông
{
    public virtual void Work()
    {
        Console.WriteLine("User is working");
    }  
}

public class Admin : User // cha
{
    public override sealed void Work() // chặn ghi đè tiếp
    {
        Console.WriteLine("SuperAdmin is working with super power");
    }
}


public class SuperAdmin : Admin // con của cha ,
{
    
    // không dược ghi đè lại hàm work
    //  public override void Work() // không đè được vì bị chặn ở cáp Admin 
    // {
    //     Console.WriteLine("SuperAdmin is working with super power");
    // }
}


// Những trường hợp sử dụng chặn kế thừa 
/*
- class đã hoàn thiện, 
- Công thức tính toán cố định 
- đảm bảo tính toàn vẹn và tránh thay đổi ngoài ý muốn


*/



 