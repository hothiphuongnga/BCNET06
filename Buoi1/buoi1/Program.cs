// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Console.ReadLine(); 
// lệnh chạy dotnet run

// Program.cs : mặc định là file khởi động của ứng dụng .NET, nó sẽ chaỵ mặc đinh hàm Main khi ứng dụng được khởi động.
// .csproj: file cấu hình của dự án , thiết lập các thông tin như tên dự án, phiên bản, các thư viện tham chiếu, các thiết lập build,...


// bin : chứa output của dự án khi buil  
// obj : chứa các file tạm thời được tạo ra trong quá trình build dự án

// lệnh xuất output Console.WriteLine -> lệnh in ra màn hình console -> output

// In ra hello + tên của bạn
// Ví dụ Phương Nga
// sau đó đổi phương nga thành Minh Phát
Console.WriteLine("Hello Minh Phát");
Console.WriteLine("Hello Minh Phát");
Console.WriteLine("Hello Minh Phát");
Console.WriteLine("Hello Minh Phát");


// biến 


// nhiệt kế lúc chưa đo : 28 độ c => 28 là giá triij tạm 

// Khi đo xong : 36.5 độ c => 36.5 là giá trị mới

// nhiệt kế là biến , biến này chứa dữ liệu tạm thời là nhiệt độ

// biến : là 1 vùng nhớ đặt tên , dùng để lưu trữ dữ liệu trong quá trình chương trình chạy
// Cú pháp khai báo biến trong C#

var nhietKe = 28 ; // nhiệt kế lúc chưa đo => tự động hiểu là kiểu số nguyên int
// var : từ khoá để khai báo biến đơn giản nhất
// nhietKe : tên biến
// 28 : là giá trị của biến nhietKe

nhietKe = 40; // cú pháp thay đổi giá trị cho biến => gán 


// terminal   dùng để chạy những lệnh bắt đầu dotnet ....


var ten = "Nguyên"; // biến tên kiểu chuỗi
Console.WriteLine("Hello " + ten); // đây là  cách nối chuỗi trong C# dùng dấu + 
Console.WriteLine("Hello " + ten);
Console.WriteLine("Hello " + ten);
Console.WriteLine("2 " + " 2"); //"2  2"

//KIỂU DỮ LIỆU

// chia phạm vi dữ liệu mà 1 biến có thể chứa
// VD thực tế : Ly để thịt sống và ly uống nước
// VD lập trình : biến chứa số tài sản (là những con số), biến tên người yêu cũ (là chuỗi)

// Cú pháp
// <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo> ;
// kiểu dự liệu : xác định phạm vi dữ liệu mà biến có thể lưu trữ
// dữ liệu số nguyên                        int 
// dữ liệu số không nguyên => số thực       double, float
// dữ liệu chuỗi ký tự                      string
// dữ liệu đúng sai true/ false             bool (boolean)
// dư liệu ký tự đơn, 1 ký tự               char (1 ký tự ví dụ 'a', 'b', '1', '@'....)
// dự liệu tiền tệ                          decimal

// var là từ khoá khai báo biến đơn giản , tự động xác định kiểu dữ liệu dựa trên giá trị khởi tạo

var soTaiSan = 10; // tự động hiểu là kiểu int
var diemTrungBinh = 8.5; // tự động hiểu là kiểu double
var tenNguoiYeuCu = "Phương Nga"; // tự động hiểu là kiểu string
var dangCoNguoiYeu = false; // tự động hiểu là kiểu bool => 

// Khai báo biến có kiểu dữ liệu rõ ràng

int soTaiSan1 = 10;
double diemTrungBinh1  = 8.5;
string tenNguoiYeuCu1 = "Phương Nga";
bool dangCoNguoiYeu1 = false;

Console.WriteLine("Số tài sản " + soTaiSan1); // cộng chuỗi  =>  in ra 10
Console.WriteLine("Điểm trung bình " + diemTrungBinh1);
Console.WriteLine("Tên người yêu cũ " + tenNguoiYeuCu1);
Console.WriteLine("Đang có người yêu " + dangCoNguoiYeu1);


// string int  = "Hello";// => lỗi vì int là từ khoá của ngôn ngữ C#

// Quy tắc đặt tên biến
/*
- tên biến không được trùng nhau
- không được bắt đầu bằng số
- viết liền không khoảng cách
- không được chứa ký tự đặc biệt trừ dấu gạch dưới _
- không được sử dụng từ khoá của ngôn ngữ . VD: int, var, class, public, void   .....

QUY ƯỚC 
- camelCase : chữ cái đầu tiên của từ đầu viết thường, chữ cái đầu tiên của các từ sau viết hoa VD : tenNguoiYeuCu
- PascalCase : chữ cái đầu tiên của tất cả các từ viết hoa VD : TenNguoiYeuCu
- Đặt tên biến có nghĩa, dễ hiểu
Ví dụ : int soLuong = 100;

Biến có thể thay đổi giá trị trong quá trình chương trình chạy bằng cách gán lại giá trị mới cho biến đó Ví dụ :
int soLuong = 100;
soLuong = 200; // gán lại giá trị mới cho biến soLuong
*/

soTaiSan1 = 20; // gán lại giá trị mới cho biến soTaiSan1

Console.WriteLine("");
Console.WriteLine("Số tài sản mới " + soTaiSan1); // in ra 20

// soTaiSan1 = "30"; // lỗi vì soTaiSan1 là kiểu int không thể gán giá trị chuỗi được
soTaiSan1 = 30;


// Output 
// Console.Write("");  và Console.WriteLine(""); 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Hello ");
Console.Write("Minh Phát ");

// biến , kiểu dữ liệu

// input
// Hello + tenBien
// Hello + tên / gía trị nhập từ bàn phím 
// Console.ReadLine(); // lệnh chờ nhập dữ liệu từ bàn phím kêt thúc bằng phím Enter
// Cần có câu dẫn nhập dữ liệu từ bàn phím
Console.WriteLine("Mời bạn nhập tên người dùng (Sau đó nhấn enter để tiếp tục): ");

// Cần khai báo biến để lưu trữ dữ liệu nhập từ bàn phím
var tenNguoiDung = Console.ReadLine(); // lệnh nhập dữ liệu từ bàn phím , dữ liệu nhập vào sẽ được gán cho biến tenNguoiDung
// Console.ReadLine() luôn trả về kiểu dữ liệu chuỗi string dù nhập số hay ký tự

Console.WriteLine("Tên người dùng nhập từ bàn phím là " + tenNguoiDung); 


// BT nhỏ 
// nhập vào tên và tuổi từ bàn phím và in ra màn hình câu "chào" + ten_ban + ", " + tuoi_ban + " tuoi"
/*
B1: In câu mời nhập tên
B2: Khai báo biến ten_ban để lưu trữ tên nhập từ bàn phím 
B3: In câu mời nhập tuổi
B4: Khai báo biến tuoi_ban để lưu trữ tuổi nhập từ bàn phím
B5: In ra màn hình
*/
Console.Write("Nhập tên : "); // Nhập tên :     
string tenBan = Console.ReadLine();
Console.Write("Nhập tuổi : "); // Nhập tuổi :
string tuoiBan = Console.ReadLine();

Console.WriteLine("chào " + tenBan + ", " + tuoiBan + " tuổi");
Console.WriteLine($"Hello {tenBan}, {tuoiBan} age"); // Cách dùng chuỗi định dạng trong C# sử dụng $ trước chuỗi và {} để chèn biến vào chuỗi



// {}  dấu móc  
// <> ngoặc nhọn
Console.ForegroundColor = ConsoleColor.Green; // bắt đầu đổi màu chữ

Console.WriteLine("Text");


Console.ResetColor();// trả về màu mặc định

// TOÁN TỬ
// toán tử số học : + - * / 
Console.ForegroundColor = ConsoleColor.Cyan;
int a = 10;
int b =3;
int tong = a + b;  // 10 + 3 = 13
int hieu = a - b;  // 10 - 3 = 7
int tich = a * b;  // 10 * 3 = 30
int thuong = a / b; // 10 / 3 phép chia lấy phần nguyên
int du = a % b;    // 10 % 3 phép chia lấy phần dư 1
Console.WriteLine("Tổng a và b là " + tong);
Console.WriteLine($"Hiệu a và b là {hieu}");
Console.WriteLine($"Tích a và b là {tich}");
Console.WriteLine($"Thương a và b là {thuong}");
Console.WriteLine($"Phần dư a chia b là {du}");

Console.ResetColor();

// Toán tử gán 
// = : gán giá trị cho biến. VD:  a = 20
// += : tăng giá trị biến lên n giá trị. VD: a += n => a = a + n
a +=1 ; // a  = a + 1;
b += 99; // b = b + 99;

// -= : giảm giá trị biến đi n giá trị. VD: a -= n => a = a - n
a -= 2; // a = a - 2 
// *= : nhân giá trị biến với n giá trị. VD: a *= n => a = a * n
b *= 2; // b = b * 2
// /= : chia giá trị biến cho n giá trị. VD: a /= n => a = a / n
b /= 3; // b = b / 3
// %= : lấy phần dư giá trị biến chia cho n giá trị. VD: a %= n => a = a % n
a %= 3; // a = a % 3


int c =101; // khởi nghiệp với 101
c+=100; // c = 101 + 100  => 201 , gán cho c giá trị mới  => 201
Console.WriteLine($"Giá trị c sau khi +=100 là {c}"); // 201
c-=50; // c = 201 - 50 => 151 , gán cho c giá trị mới // 
Console.WriteLine($"Giá trị c sau khi -=50 là {c}"); // 151


// 




