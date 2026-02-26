// BlindBox - xé túi mù
// 
// class là generictype : Hop : 
// TenClass<T> : T là kiểu dữ liệu mà mình muốn sử dụng khi khởi tạo đối tượng từ class này. Có thể thay T bằng bất kỳ tên nào khác, nhưng T thường được sử dụng để đại diện cho "Type" (kiểu dữ liệu).

// 
class BlindBox<T>
{
    public T Ten { get; set; }

    public void HienThi()
    {
        Console.WriteLine(Ten);
    }
}

