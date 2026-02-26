// HỮU LỢI x2, Anh Vũ , Khánh Vy.
// chạy timeout từ 10 đến 0 và kết thúc
// Console.WriteLine("Bắt đầu đếm ngược");
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
//     Thread.Sleep(1000); // tạm dừng 1 giây
// }
// Console.WriteLine("");

// while, for, và do ...while


// SO SÁNH for và while
// for : thường dùng khi biết trước số lần lặp. VD : in ra 30 lần, tính tổng từ 1 đến 100
// while : thường dùng khi không biết trước số lần lặp, lặp đến khi nào điều kiện sai thì dừng . VD : nhập mật khẩu đúng mới dừng, nhập số hợp lệ mới dừng
// do while : dùng khi muốn chạy thân vòng lặp ít nhất 1 lần dù điều kiện sai. 
// foreach : dùng để duyệt qua từng phần tử trong mảng, danh sách, chuỗi ,... không quan tâm đến vị trí index cua phần tử

var tenDoanhNghiep = "CYBERSOFT";
// in ra hello CYBERSOFT 30 lần

//  viết vòng lặp để xử lý 

// for 
/*
CÚ PHÁP
for (khởi_tạo_biến; điều_kiện; bước_lặp)
{
    // khối lệnh được thực thi trong mỗi vòng lặp
}
khởi_tạo_biến : thường sẽ là biến để đếm i  ,  VD: int i=0, int i= 1 ; =10 ......
điều_kiện: điều kiện để vòng lặp tiếp tục chạy , VD: i<10, i<=30, i>0, i>=1
bước_lặp: sau mỗi lần thực thi khối lệnh thì biến đếm sẽ thay đổi như thế nào 

Các yếu tố tạo nên vòng lặp 
-  biến đếm :  i  = 1
-  điều kiện   : i<=30 
- Thân vòng lặp : xử lý nếu điều kiện đúng
- bước lặp: thay đổi giá trị của biến đếm . 
*/
for (int i = 1; i <= 3; ++i) // in ra 30 dong tenDoanhNghiep
{
    Console.WriteLine($"{i} Hello " + tenDoanhNghiep);
}

// b1 khởi tạo biến đếm : chạy 1 lần vào lần đầu tiên
// b2 kiểm tra điều kiện : i=1 <=3 đúng -> chạy thân vòng lặp, nêú sai thì thoát vòng lặp
// b3 thân vòng lặp : in ra dòng chữ
// b4 bước lặp : ++i -> i =2
// bay lại b2

// lần 1 i =1 > 0 -> chạy , 
// lần 2 i =2 >0 -> chạy

// Toán tử tăng giảm

var number = 10;

// number++;// tăng 1 đơn vị cho biến number
// number--; // giảm 1 đơn vị cho biến number
// ++number; // tăng 1 đơn vị cho biến number
// --number; // giảm 1 đơn vị cho biến number
var result = number++;// ++ dùng trước, tăng sau 
var result2 = number--;
Console.WriteLine("Result: " + result); // 10
Console.WriteLine("Result2: " + result2);
Console.WriteLine("Number: " + number);

var soTien = 1000;
var soDu = --soTien; // tăng trước, dùng sau
var soDu2 = ++soTien; // giảm trước, dùng sau
Console.WriteLine("Số Dư: " + soDu); // 999
Console.WriteLine("Số Dư2: " + soDu2); // 100
Console.WriteLine("Số Tiền" + soTien); // 1000

int a = 126;
int b = a++; // b = 126 , a = 127
a--; // a = 126
a += 10; // a = 136
--a; // a = 135
// b= bao nhiêu 
// a= bao nhiêu

#region tính tổng các số từ 1 đến 100
// 1+ 2 + 3 + ... + 100 
int tong = 0;
// cần lấy ra các số từ 1 , 2 , 3 , ... 100 để cộng dồn vào biến tong
//  tong = tong + con số được lấy ra từ vòng lặp 
for (int i = 1; i <= 100; i++)
{
    tong += i;
}
Console.WriteLine("Tổng từ 1 đến 100 là: " + tong);
#endregion

// while
/*
cú pháp

// B1:  khởi tạo biến đếm 

while (điều kiện) // B2: ktr điều kiện
{
    //B3 khối lệnh được thực thi trong mỗi vòng lặp - thân vòng lặp

    //B4 bước lặp - thay đổi giá trị biến đếm
}

*/
int bienDem = 1;
int tongWhile = 0;
while (bienDem <= 100)
{
    tongWhile += bienDem;
    // B4
    bienDem++;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Tổng từ 1 đến 100 là: " + tongWhile);

// 

#region Nhập n tính tổng từ số chẵn từ 2 đến 2n

// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.Write("Nhập vào n cần tính : ");
// int numberB2;
// int kdb2 = 0;
// bool isValid = int.TryParse(Console.ReadLine(), out numberB2);
// // if (!isValid)// nếu lỗi
// // {
// //     // thông báo lỗi và kết thúc chương trình
// //     Console.ForegroundColor = ConsoleColor.Red;
// //     Console.WriteLine("Vui lòng nhập số hợp lệ");
// //     return; // kết thúc chương trình. vì đang ở trong hàm main() nên return sẽ kết thúc chương trình
// // }
// while (!isValid)// nếu lỗi
// {
//     // thông báo lỗi và kết thúc chương trình
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.Write("Vui lòng nhập số hợp lệ: ");
//     isValid = int.TryParse(Console.ReadLine(), out numberB2);
//     Console.ResetColor();


// }
// //for chạy từ 2 đến 2n 
// // 2 4 6 8 
// for (int i = 2; i <= 2 * numberB2; i += 2)
// {
//     // l1 : 2 tăng 2 đơn vị
//     // l2 : 4
//     kdb2 += i;
// }
// Console.WriteLine($"Tổng các số chẵn từ 2 đến {2 * numberB2} là: " + kdb2);




// Console.ResetColor();


#endregion

#region DO ... WHILE
// do while 
// chạy thân vòng lặp ít nhất 1 lần dù điều kiện sai

// VÍ DỤ: nhập mật khẩu đúng mới dừng
// do
// {
//     // thực hiện thân vòng lăp
// }
// while(điều kiện);

string matKhau = "";
// do
// {
//     Console.WriteLine("Nhập mật khẩu :");
//     matKhau = Console.ReadLine();

//     // nếu sai thì thông báo
//     if (matKhau != "123456")
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write("Mật khẩu không đúng, vui lòng nhập lại.\n");
//         Console.ResetColor();
//     }
// }
// while (!(matKhau == "123456")); // nếu khác 123456 thì nhập lại

// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("Đăng nhập thành công");
// Console.ResetColor();

#endregion


#region BT4 tổng bình phương
// int soB4;
// bool isValidB4;
// double tongB4 = 0;
// do
// {
//     Console.Write("Hãy nhâp số n cần tính: ");
//     isValidB4 = int.TryParse(Console.ReadLine(), out soB4);
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine("Vui lòng nhập lại số hợp lệ.");
//     Console.ResetColor();
// }
// while (isValidB4 == false);// quay lại nhập nếu isValidB4 == false

// // 1 đến n
// for (int i = 1; i <= soB4; i++)
// {
//     // tính bình phương
//     tongB4 = tongB4 + (i * i);
// }

// Console.WriteLine($"Tổng bình phương từ 1 đến {soB4} là: " + tongB4);

#endregion

#region BT5 
// kiểm tra số nguyên tố
// int soB5;
// bool isValidB5;
// do
// {
//     Console.Write("Hãy nhâp số n cần kiểm tra: ");
//     isValidB5 = int.TryParse(Console.ReadLine(), out soB5);
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine("Vui lòng nhập lại số hợp lệ.");
//     Console.ResetColor();
// }
// while (isValidB5 == false);// quay lại nhập nếu isValidB5 == false


// // chạy từ 1 đến n xem có bao nhiêu ước số
// // nếu ước =2 thì là số nguyên tố
// // ước > 2 thì không phải số nguyên tố
// // 1 đến n

// // chạy từ 2 đến căn bậc 2 của số n
//  // nếu không có ước nào thì là số nguyên tố
//  // nếu có ước thì không phải số nguyên tố
// int soUoc = 0;
// for (int i = 2; i <= Math.Sqrt(soB5); i++) 
// {
//     if (soB5 % i == 0)
//     {
//         soUoc++;
//     }
// }
// if(soUoc == 0)
// {
//     Console.WriteLine($"{soB5} là số nguyên tố");
// }
// else
// {
//     Console.WriteLine($"{soB5} không phải số nguyên tố");
// }


#endregion


#region Xử lý chuỗi
string chuoi = "Tháng một"; 
// từng lý tự sẽ được đánh số vị trí bắt đầu từ 0
// được tạo thành từ nhiều ký tự  char
// T H á n g   m ộ t
// lấy ra T sau + " "
// lấy ra h sau + " " 
// lấy ra kí tự 
// 1 2 3 4 5 6 7 8 9
// T h a n g   m ộ t
// 0 1 2 3 4 5 6 7 8
Console.WriteLine(chuoi[0]);
// lấy ký tự cuối 
Console.WriteLine(chuoi[8]);
Console.WriteLine(chuoi[chuoi.Length -1]);

// hàm lấy độ dài chuỗi
Console.WriteLine(chuoi.Length);

// contains : kiểm tra chuỗi có chứa ký tự hoặc chuỗi con hay không
bool kqContains = chuoi.Contains(" ");

// indexof : tìm vị trí đầu tiên chuỗi con trong chuỗi cha
int kqIndexOf = chuoi.IndexOf("n"); // trả về vị trí
Console.WriteLine("vị trí xuất hiênk 'n' là " + kqIndexOf);



Console.WriteLine("Kết quả contains: " + kqContains);


Console.ResetColor();



Console.WriteLine("__________________________");
// chạy vòng lặp qua từng ký tự trong chuỗi
string kqChuoi="";
for(int i = 0; i < chuoi.Length; i++ )
{
    // từng ký tự  
    // chuoi[i]
    kqChuoi += chuoi[i] + "_";// 
    // l1: i=0 -> T => kqChuoi= "T "
    // l2: i=1 -> h => kqChuoi= "T h "
    // l3: i=2 -> á => kqChuoi= "T h á "
    //.....
}
Console.WriteLine( kqChuoi);

#endregion

#region Đảo chuỗi
// đảo ngược chuỗi
string chuoiDaoNguoc;
do 
{
    Console.Write("Nhập chuỗi cần đảo ngược: ");
    chuoiDaoNguoc = Console.ReadLine();
}
while (string.IsNullOrEmpty(chuoiDaoNguoc));// nếu chuỗi rỗng thì nhập lại

// PHUONG NGA
// chạy vòng lặp từ cuối chuỗi về đầu chuỗi
string kqDaoNguoc = "";
for(int i = chuoiDaoNguoc.Length - 1; i >=0; i--)
// tại sao lại là lenght - 1 
// vì tạo vị trí length không có kí tự phù hợp
{
    // l1 : A -> in luôn chữ A Consolw.Write('A')
    // l2 : G -> in luôn chữ G Consolw.Write('G') => AG
    Console.Write(chuoiDaoNguoc[i]);
    kqDaoNguoc += chuoiDaoNguoc[i];
}
#endregion

// Foreach 

// foreach cunxg là vòng lăp nhưng hay dùng cho duyệt chuỗi , mảng , danh sách,...
// không có biến đếm -> không cần quan tâm vị trí, 
// 
// cần duyệt cái gì : qua từ ký tự của chuỗi 

// bỏ qua khoảng trắng
var kqDaoNguocForeach = "";
foreach (char c in chuoiDaoNguoc) // 
{
    // l1 : P =>  kqDaoNguocForeach = "" + "P" = "P"
    // l2 : H => kqDaoNguocForeach = "H" + "P" = "HP"
    // l3 : U => kqDaoNguocForeach = "U" + "HP" = "UHP"
    // l4 : " " => bỏ qua 
    if(c == ' ')
    {
        // return : kết thúc hàm / chương trình
        // break : kết thúc vòng lặp
        // continue: bỏ qua lần lặp hiện tại và chuyển sang lần lặp tiếp theo
        // bỏ qua ký tự này và chuyển sang ký tự tiếp theo
        continue;
    }
    kqDaoNguocForeach = c + kqDaoNguocForeach; 
}
Console.WriteLine("\nKết quả đảo ngược bằng foreach: " + kqDaoNguocForeach);


var res = chuoiDaoNguoc[^1];
// reindex
Console.WriteLine("ký tự cuối của chuỗi là: " + res);

// reindex vị trí từ cuối về đầu ^1 : vị trí cuối cùng
// ^2 : vị trí kế cuối
// ^3 : vị trí thứ 3 từ cuối lên    
// ^n : với n = chuoiDaoNguoc.Length  là vị trí đầu tiên
//  duyệt xuôi : biến đêm tăng
// duyệt ngược : biến đếm giảm

for(int i = 1; i >=chuoiDaoNguoc.Length; i++)
{
    Console.Write(chuoiDaoNguoc[^i]);
}
