using System.Text;

namespace ConsoleApp1;

public class BTCoBan
{
    // I.Khai báo biến, Kiểu dữ liệu và Nối chuỗi cơ bản
    // BT1: Hồ sơ lập trình viên căn bản
    string name = "Phuong";
    int age = 18;
    double height = 1.73;
    char gender = 'M';

    public void ThongTinCuaToi()
    {
        Console.WriteLine("Tên: " + name+ " Tuổi: " + age + " Cao: " + height + " Giới tính: " + gender);
    }
    // BT2 : Tự động tính tuổi
    int currentYear = 2026;
    int birthdayYear = 2003;
    
    public void TinhTuoi()
    {
        if ((-(birthdayYear - currentYear)== 23))
        {
        Console.WriteLine("Tuổi của bạn là: " + 18);
        }
    }
    
    // BT3: Ghép họ và tên chuẩn hóa
    string firstName = "Phương", towName = " Bật ", threeName = "Nguyễn";
    
    public void HoVaTen()
    {
        Console.WriteLine("Họ và tên: " + firstName + towName + threeName);
    }
    
    // BT4: Khai báo thông tin sản phẩm
    // tại sao tự động nhảy private
    private string productName = "Lông", productCode = "ZZZ" ;
    private int productQuantity = 999999999;
    private bool productStatus = true;

    public void ThongTinhSanPham()
    {
        Console.WriteLine("**** Sản phẩm đứng thứ hai thị trường ****");
        Console.WriteLine("Tên sản phẩm: " + productName);
        Console.WriteLine("Mã sản phẩm " + productCode);
        Console.WriteLine("Số lượng sản phẩm " + productQuantity);
            Console.WriteLine("Trạng thái sản phẩm: "  + productStatus );
    }

}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        BTCoBan bt = new BTCoBan();
        bt.ThongTinCuaToi();
        bt.TinhTuoi();
        bt.HoVaTen();
        bt.ThongTinhSanPham();
    }
}