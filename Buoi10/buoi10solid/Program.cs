public class Program
{
    public static void Main(string[] args)
    {
        // S - Single Responsibility Principle

        // muốn thêm giỏ hàng , đặt hàng, thanh toán  

        var gioHang = new GioHang();
        var datHang = new DatHang();
        var thanhToan = new ThanhToan();
        gioHang.ThemSanPham();
        datHang.DatHangOnline();
        thanhToan.ThanhToanOnline();


        var muasam = new MuaSamFacade();
        muasam.MuaSamOnline();

    }
}