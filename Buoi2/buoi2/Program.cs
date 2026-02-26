// giải bài tập

#region Bài 1: Viết chương trình nhập vào độ C và chuyển đổi sang độ F
/*
B1: Câu lệnh yêu cầu nhâp độ C
B2: nhập giá trị độ C từ bàn phím 
B3: chuyển đổi string sang số thực
B4: công thức chuyển đổi độ C sang độ F
    F = C * 9/5 + 32
B5: in kết quả
*/
// Console.Write("Hãy nhâp nhiệt độ hiện tại (độ C): ");
// string strDoC = Console.ReadLine();


// bool kiemTra = double.TryParse(strDoC,out double doC);
// // kiemtra có thể là true hoặc false 
// // vui lòng nhập đúng định dạng số

// var ketQua = doC * 9 / 5 + 32; 
// Console.WriteLine($"Nhiệt độ tương ứng của {doC} độ C là: {ketQua} độ F");



#endregion


#region Bài 2: Tính chu vi và diện tích hình tròn Viết chương trình nhận vào bán kính của hình tròn. Tính và in ra chu vi và diện tích của hình tròn đó
/* 3 BÀI ĐẦU TIÊN  +5/100 Khanh new, anh vũ, khánh vy
B1: yêu cầu nhập bán kính hình tròn
B2: nhập giá trị bán kính từ bàn phím
B3: chuyển đổi chuỗi sang số thực
B4: công thức tính chu vi và diện tích hình tròn
    Chu vi = 2 * π * r
    Diện tích = π * r * r
B5: in kết quả
*/
// Console.Write("Hãy bán kính: ");
// string banKinh = Console.ReadLine();


// bool isBanKinh = double.TryParse(banKinh,out double r);
// // kiemtra có thể là true hoặc false 
// // vui lòng nhập đúng định dạng số

// var chuVi = 2 * Math.PI * r;
// var dienTich = Math.PI * r * r;
// Console.WriteLine($"Chu vi hình tròn là: {Math.Ceiling(chuVi)}");
// Console.WriteLine($"Diện tích hình tròn là: {dienTich:N2}"); // N2: 2 số thập phân


#endregion


#region Bài 3 Viết chương trình nhập vào cân nặng (kg) và chiều cao (m) của một người. Tính và in ra chỉ số BMI (Body Mass Index) của người đó.
/*
b1, 2 ,3,4,5 tương tự bài trên Bảo Lâm , Đăng Khoa, Minh PJ
Công thức tính BMI:
    BMI = cân nặng (kg) / (chiều cao (m) * chiều
*/

// ĐÁP ÁN TRÊN GROUP CHAT

// var canNang = 750000000.0; // kg
// Console.WriteLine($"{canNang:F2}");// F2 thì chỉ làm tròn theo n số thập phân
// Console.WriteLine($"{canNang:N2}"); // N2: n số thập phân và có chia dấu phẩy hàng nghìn


#endregion


// 0.5 Khánh Vy, 1 cho Hữu Lợi, 1 cho Viet Hung
#region Bài tập 4: Tính số ngày trong tuần và số ngày lẻ
//Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.
// Input: 
// Process:
// OutPut: 
// Mã giả:

// Console.WriteLine("Nhập số ngày cần tính: ");
// int soNgay;
// int.TryParse(Console.ReadLine(),out soNgay);
// int soTuan = soNgay / 7; // lấy phần nguyên của phép chia
// int soNgayLe = soNgay % 7; // lấy phần dư của phép chia, hoặc dùng công thức: soNgay - (soTuan * 7)
// Console.WriteLine($"với {soNgay} ngày thì có {soTuan} tuần và {soNgayLe} ngày lẻ.");

#endregion

#region Bài tập 5: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
//Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.

// ĐÁP ÁN TRÊN GROUP CHAT

#endregion





#region CẤU TRÚC RẺ NHÁNH
// đưa ra quyết định dựa trên điều kiện đúng sai
// điều kiện đúng -> thực hiện hành động A
// điều kiện sai -> thực hiện hành động B
// Toán tử so sánh
/*
Nếu điều kiện đúng thì thực hiện hành động A
Điều kiện sẽ có dạng là bool
if(Điều kiện)
{
    // hành động A
}
*/
// if (10 < 5) // đúng
// {// scope 
//     // 
//     Console.WriteLine("Đúng");
// }
// else // nếu điều kiện sai thì thực hiện hành động B
// {
//     // hành động B
//     Console.WriteLine("Sai");
//     Console.WriteLine("Dòng này được in vì điều kiện sai ");
// }



// var nhietDo = 20; 
// // kiểm tra nhiet độ và in ra console tương ứng
// // kiểm tra điều kiện
// if (nhietDo < 25) // 24 23 22 21... 
// {
//     Console.WriteLine("Không bật mát lạnh");// chạy xong lệnh này thì kêt thúc lệnh if else
// }
// else
// {
//     Console.WriteLine("Bật mát lạnh");
// }

// Console.WriteLine("chạy tiếp và bỏ quả phần còn lại của else");


#endregion
#region kiểm tra số chẳn hay lẻ
// Console.Write("Nhập số cần kiểm tra: ");
// int soCanKiemTra;
// int.TryParse(Console.ReadLine(), out soCanKiemTra);

// bool kiemTra = soCanKiemTra % 2 == 0; //  10 % 2 =0, 9%2 =1

// ! phủ định 

// kiemtra = true => !kiemtra  => false
// if(!kiemTra)
// {
//     // hành động A -> in ra câu tương ứng
//     Console.WriteLine("Số lẻ");
// }
// else
// {
//     // hành động B -> in ra câu tương ứng
//     Console.WriteLine("Số chẵn");
// }




#endregion 

/*
 if (điều kiện)
 {
    // nhưng công việc sẽ được thực hiện nếu điều kiện đúng
 }
 else
 {
    // những công việc sẽ được thực hiện nếu điều kiện sai
 }



*/



// BT chon trang phục 

// input : con số
Console.WriteLine(@"Hãy nhập số theo tình hình thời tiết:
1. Nắng nóng\
2. Mưa
3. Lạnh
4. Tuyết
");
int.TryParse(Console.ReadLine(), out int tinhHinhThoiTiet);

if(tinhHinhThoiTiet == 1)
{
    Console.WriteLine("Áo thun, quần short, dép xăng đan");
}
else
{
    // có phải là 2 hay không
    if(tinhHinhThoiTiet == 2)
    {
        Console.WriteLine("áo mưa");
    }
    else
    {
        // có phải là 3 hay không 
        if(tinhHinhThoiTiet ==3)
        {
            Console.WriteLine("áo ấm");
        }
        else
        {
            // mặc áo len là số 4 rơi vào trường hợp cuối
            if(tinhHinhThoiTiet ==4)
            {
                Console.WriteLine("áo len");
            }
            else
            {
                Console.WriteLine("Số bạn nhập không hợp lệ");
            }
        }
        
    }
}
// nếu không phải 1 thì 2 , 3 , 4
// if(tinhHinhThoiTiet == 2)
// {
//    Console.WriteLine("áo mưa"); 
// }
// if(tinhHinhThoiTiet == 3)
// {
//    Console.WriteLine("áo ấm"); 
// }
// if(tinhHinhThoiTiet == 4)
// {
//    Console.WriteLine("áo len"); 
// }

// process: kiểm tra số theo điều kiện
 // output: câu in ra trang phục 

