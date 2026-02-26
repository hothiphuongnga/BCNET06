#region BT vận dụng else if(điều kiện)
/* 
if(dieukien1)
{

}
else
{
    if (dienkien2)
    {

    }
}


if(điều kiện 1)
{
    thực thi nếu dk1 đúng
}
else if (điều kiện 2)
{
    thực thi khi dk1 sai và  nếu dk2 đúng
}
/// có thể có thêm nhiều else if khác nữa nếu còn dk cần ktra
///  // nếu  hết thứ để ktra thì 
else
{
    thực thi khi tất cả dk sai
}
// nếu code thực thi chỉ có 1 dòng thì có thể bỏ dấu {}
*/
// int so =2;
// if (so == 1) Console.WriteLine("áo mát");

// else if(so == 2) Console.WriteLine("áo dài");
// else if(so == 3)
//     Console.WriteLine("áo sơ mi");
// else
//     Console.WriteLine("không có áo");

#endregion

#region BT tổng 3 ký số
Console.WriteLine("Nhập số có 3 chữ số: ");
int number;
bool checkNumber = int.TryParse(Console.ReadLine(), out number);
if (!checkNumber) // check = true  !check = false
{
    Console.WriteLine("sai định dạng");
}
// nếu là số
// number <100  number > 999

else if (number > 999 || number < 100)
{
    Console.WriteLine("Số yêu cầu phải bé hơn = 999");
}
// else if (number < 100)
// {
//     Console.WriteLine("Số yêu cầu phải lớn hơn = 100");
// }
else
{
    // tách số hàng trăm, hàng chục, hàng đơn vị
    int hangTram = number / 100; // lấy phần nguyên của phép cho 100 
    int hangChuc = (number % 100) / 10;
    int hangDonVi = number % 10; // lấy phần dư của phép chia 10
    int tong = hangTram + hangChuc + hangDonVi;
    Console.WriteLine($"Tổng 3 ký số là: {tong}");
}

#endregion



#region TOÁN TỬ LOGIC
/*
 && : và   tất cả đúng thì mới đúng
 || : hoặc   chỉ cần 1 trong các DK đúng => đúng
VD :    Trời mưa (có) && Bệnh (có)  => ở nhà  (ĐÚNG)
        Tròi mưa (có) && Bệnh (không) => không được ở nhà  (SAI)

VD :    Người yêu(ko)  và bạn (có)  => đi chơi 
        Nguời yêu(ko)  và tiền (có)    => đi chơi
        người yêu (có) bạn (có) ==> di chơi
        có bạn (có) và tiền (kó) => đi chơi 
        tiền (kh)  được mời (có ) => đi chơi 





*/


Console.WriteLine(true && false); // false
Console.WriteLine(true || false); // true
Console.WriteLine(false || false); // false
Console.WriteLine(true && true); // true
#endregion





#region Switch case
/*
switch case : dùng để kiểm tra nhiều điều kiện dựa trên 1 biến
cú pháp:
switch(biến cần kiểm tra){
    case giá trị 1:
        thực thi khi biến = giá trị 1
        break;
    case giá trị 2:
        thực thi khi biến = giá trị 2
        break;
    ...
    default:
        thực thi khi
        }



*/


// Nhập từ 1 đến 7 in ra ngày trong tuần
Console.WriteLine("Nhập số từ 1 đến 7: ");
int dayOfWeek;
bool checkDay = int.TryParse(Console.ReadLine(), out dayOfWeek);
// kiểm tra chuyển thành công hay không
if (!checkDay)
{
    Console.WriteLine("Sai định dạng");
}
else
{
    switch (dayOfWeek)
    {
        case 1:
            {
                Console.WriteLine("Chủ nhật");
                // return;
                break;
            }
        case 2:
            {
                Console.WriteLine("Thứ 2");
                break;
            }
        case 3:
            {
                Console.WriteLine("Thứ 3");
                break;
            }
        case 4:
            {
                Console.WriteLine("Thứ 4");
                break;
            }
        case 5:
            {
                Console.WriteLine("Thứ 5");
                break;
            }
        case 6:
            {
                Console.WriteLine("Thứ 6");
                break;
            }
        case 7:
            {
                Console.WriteLine("Thứ 7");
                break;
            }
        // trường hợp còn lại 
        // không nằm trong các case phía trên
        default:
            {
                Console.WriteLine("Số không hợp lệ");
                break;
            }

    }
    Console.WriteLine("Your text here");



}

#endregion



#region
// >=8 giỏi
// >=6.5 khá
// >=5 trung bình
// <5 yếu

double dtb = 6;
string xepLoai = "";
switch (dtb)
{ 
    // be hơn 10 và lớn hơn 8
    
    case >= 8 and <=10 :   // lấy ra giá trị từ 8 đến 10  lớn hơn 8 và bé hơn 10 => đúng
        {
            xepLoai = "Giỏi";
            break;
        }
    case >= 6.5 :
        {
            xepLoai = "Khá";
            break;
        }
    case >= 5:
        {
            xepLoai = "Trung bình";
            break;
        }
    case < 5:
        {
            xepLoai = "Yếu";
            break;
        }
    default:
        {
            xepLoai = "Điểm không hợp lệ";
            break;
        }
}

Console.WriteLine($"Xếp loại {xepLoai}");




#endregion


#region  Switch expression
double diemTB = 7.5;
string xepLoai2 = diemTB switch
{
    >= 8 and <= 10 => "Giỏi",
    >= 6.5 => "Khá",
    >= 5 => "Trung bình",
    < 5 => "Yếu",
    _ => "Điểm không hợp lệ"
};
Console.WriteLine($"Xếp loại 2: {xepLoai2}");


int so2 = 3;
string ngay = so2 switch
{
    1=>"Chủ nhật",
    2=>"Thứ 2",
    3=>"Thứ 3",
    4=>"Thứ 4",
    5=>"",
    // ...
    _=>"Số không hợp lệ"
};
#endregion

#region
double diemToan;
double diemLy;
double diemHoa;
Console.WriteLine("Nhập điểm toán");
bool checkDiemToan = double.TryParse(Console.ReadLine(), out diemToan);
Console.WriteLine("Nhập điểm Lý");
bool checkDiemLy = double.TryParse(Console.ReadLine(), out diemLy);
Console.WriteLine("Nhập điểm Hóa");
bool checkDiemHoa = double.TryParse(Console.ReadLine(), out diemHoa);


string xepLoaiDTB="";
// nếu toán !sai => đúng  
if(!checkDiemToan || !checkDiemLy || !checkDiemHoa)
{
    Console.WriteLine("Sai định dạng điểm");
}
else
{
    double diemTBMon = (diemToan + diemLy + diemHoa) / 3;
    xepLoaiDTB = diemTBMon switch
    {
        >= 8 and <= 10 => "Giỏi",
        >= 6.5 => "Khá",
        >= 5 => "Trung bình",
        < 5 => "Yếu",
        // _ tương tự default của switch case thường
        _ => "Điểm không hợp lệ"
    };
    Console.WriteLine($"Xếp loại điểm trung bình {diemTBMon:N2}: {xepLoaiDTB}");
}


#endregion


#region Toán tử ba ngôi
Console.ForegroundColor = ConsoleColor.Green;
/*
Toán tử ba ngôi:
cú pháp
biến = điều kiện ? giá trị nếu đúng : giá trị nếu sai;

MỞ RỘNG TOÁN TỬ BA NGÔI
biến = điều kiện ? giá trị nếu đúng : (điều kiện 2 ? giá trị nếu đúng 2 : giá trị nếu sai 2);


*/



Console.WriteLine("Nhập số: ");

bool checkSo = int.TryParse(Console.ReadLine(), out int soNhap);
string ketQua = "";
string ketQua2 ;

if(checkSo) ketQua ="Số hợp lệ";

else ketQua ="Số không hợp";

Console.WriteLine(ketQua);

// 
ketQua2 =  checkSo ? "Giá trị nếu điều kiện đúng" : "Giá trị nếu điều kiện sai";
int soLuong = 10;
var ketQua3 = soLuong == 10 
?// sau dấu ? là giá trị nếu đúng
 "một chục" 
: // sau dấu : là giá trị nếu sai
soLuong == 12 
? 
"1 tá"
: 
"số khác";

Console.ResetColor();
#endregion

#region Toán tử ?? null coalescing

string ten = "Phương Nga";
// null là không có giá trị


string tenHienThi = ten ?? "Chưa có tên";
// nếu như ten == null thì gán giá trị "Chưa có tên" cho tenHienThi


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Tên : {ten}");
Console.WriteLine($"Tên hiển thị: {tenHienThi}");

// toán tử ??= :  nếu soThich == null gán giá trị mới là "Chưa có sở thích" cho nó
string? soThich = null;
soThich ??= "Chưa có sở thích";
Console.WriteLine($"Sở thích: {soThich}");

string? namSinh = Console.ReadLine();
// nullable
// string?  biến này có thể nhận giá trị null 


#endregion