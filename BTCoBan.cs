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
    // II. Toán tử số học căn bản
    // BT5 Chu vi (P) và Diện tích (S)
    private double P, S;

    public void HinhVuong()
    {
        int canh = 2;
        P = canh * 4;
        S = canh * canh;
            Console.WriteLine("Vuong");
            Console.WriteLine("Chu vi (P): "  + P + " Diện tích (S): "  + S  );
        
    }
    
    //Bài 6: Tính toán trên hình chữ nhật
    // dài: d, rộng: r
    private double d = 14.5, r = 6.2;
    public void HinhChuNhat()
    {
        int canh = 2;
        P = (d+r)*2;
        S = canh * canh;
            Console.WriteLine("Chu Nhat");
        
            Console.WriteLine("Chu vi (P): "  + P + " Diện tích (S): "  + S  );
        
    }
    
    //Bài 7: Hình tròn và hằng số Const
    //Bán kính bk;
    const double PI = 3.14159;
    private double bk = 5.5;
    public void HinhTron()
    {
        P = bk*2*PI;
        //S = PI * (bk^2);  double*int
        S = PI * Math.Pow(bk, 2);
        Console.WriteLine("Tron");
        Console.WriteLine("Diện tích (S): "  + S  );
        S = PI * bk * bk;
        Console.WriteLine("Chu vi (P): "  + P + " Diện tích (S): "  + S  );
        
    }
    
    //Bài 8: Tính vận tốc di chuyển (Bẫy ép kiểu số thực
    private int quangDuong = 105;//km
    private int thoiGian = 2;//h
    //van toc (v) = quang duong / thoi gian
    public void VanToc()
    {
        double v = (double)quangDuong / thoiGian;
        Console.WriteLine("Van toc: " + v +"km/h");
    }
    
    //Bài 9: Chuyển đổi tiền tệ thông minh
    private double USD = 120.5;
    private int tyGia = 25450;
    public void VND()
    {
        double VND = USD * tyGia;
        Console.WriteLine( USD+"USD" +"=" +VND +"VND");
    }
    
    //Bài 10: Chia kẹo cho học sinh (Toán tử / và %)
    private int tongSoKeo = 32;
    private int soHocSinh = 5
        ;
    public void ChiaKeo()
    {
        int ChiaKeo = tongSoKeo / soHocSinh;
        //double ChiaKeo = tongSoKeo / soHocSinh;
        // DuKeo = ChiaKeo - ChiaKeo * soHocSinh;
        int DuKeo = tongSoKeo % soHocSinh; 
        //DuKeo = tongSoKeo - ChiaKeo;
        Console.WriteLine("Môi học sinh có: " + ChiaKeo + "viên kẹo");
        Console.WriteLine("Giáo viên còn:"+DuKeo+"viên");
    }
    
    //III Toán tử chia nâng cao, Gán kết hợp & Tăng/Giảm
    //Bài 11: Phân tách tuần và ngày lẻ
    private int tongSoNgay = 45;
    public void NgayLe(int n = 1, int i = 0)
    {
        if (n <= 45)
        {
            Console.WriteLine("Ngày lẻ: " + n);
            NgayLe(n + 2, i + 1);
            return;
        }
        Console.WriteLine("Tổng số ngày lẻ: " + i);
    }
      
    public void Tuan()
    {
        Console.WriteLine(tongSoNgay+"ngày có " + 45 / 7 + " tuần và dư " + 45%7 + " ngày");
    }
    
    // Bài 12: Quy đổi giây sang Giờ-Phút-Giâ
    private int tongGiay = 3665;
    public void Time()
    {
        Console.WriteLine( tongGiay + "giây = "  + tongGiay/60/60 + "giờ" + tongGiay/60%60 + "phút" + tongGiay%60 + "giây");
    }
    
    //Bài 13: Tính điểm tích lũy (Toán tử gán kết hợp)
    private int diemTichLuy = 100;
    public void DiemTichLuy()
    {
        Console.WriteLine("điểm tích lũy"+diemTichLuy);
        diemTichLuy += 50;
        Console.WriteLine("Cộng thêm 50 điểm thưởng: " + diemTichLuy);
        diemTichLuy -= 30;
        Console.WriteLine("Bị trừ 30 điểm phạt: "+ diemTichLuy);
        diemTichLuy *= 2;
        //diemTichLuy += diemTichLuy;
        Console.WriteLine("Được nhân đôi số điểm hiện có: "+ diemTichLuy);
    }
    
    //Bài 14: Thử thách Tiền tố và Hậu tố (Increment / Decrement)
    public void TienToHauTo()
    { 
        int a = 10;
        int b = a++;
        int c = ++a;
        Console.WriteLine("quan sát và giải thích bản chất tiền tố/hậu tố "+ 
                          "a"+ a +" b"+ b +" c"+ c );
    }
    
    //Bài 15: Tính lương thực lĩnh khấu trừ bảo hiểm
    private int luongCoBan = 12000000;
    private double heSoLuong = 1.5, baoHiem = 10.5;
    public void LuongThucLinh()
    { 
        double tongLuong =  luongCoBan * heSoLuong;
        Console.WriteLine("Thực linh:" +  (tongLuong - tongLuong*baoHiem/100));
    }
    
    //Phần IV: Toán tử so sánh và Toán tử logic (Kết quả Bool
    //Bài 16: Kiểm tra số chẵn không dùng if
    public void SoChan()
    {
       int n = 26;
       bool laSoChan = n%2==0;
       Console.WriteLine("Đây có phải số chăn~?" + laSoChan);
       
    }
    
    //Bài 17: Kiểm tra kết quả đạt/trượt
    public void Dat()
    {
        double diemTrungBinh = 4.8;
        bool laDat = diemTrungBinh >= 5.0;
        Console.WriteLine("Đạt~?"+laDat);
    }
    
    //Bài 18: Kiểm tra số nằm trong khoảng (Toán tử AND)
    public void AND()
    {
        int giaTri = 35;
        bool hopLe = giaTri > 10 && giaTri < 50;
        Console.WriteLine("Hợp lệ~?"+hopLe);
    }
    
    //Bài 19: Điều kiện kích hoạt chuyến đi (Toán tử Logic kết hợp)
    public void ChuyenDi()
    {
        bool troiMua = false;
        bool coTien = true;
        bool diChoi = !troiMua && coTien;
        Console.WriteLine("Không mưa và có tiền"+diChoi);
    }
    
    //Bài 20: Ứng dụng tính BMI và cảnh báo thừa cân
    public void BMI()
    {
        double chieuCao = 1.75;
        double canNang = 78.5;
        double bmi = canNang / (chieuCao * chieuCao);
        bool biThuaCan = bmi >= 25.0;
        Console.WriteLine("BMI = " + bmi);
        Console.WriteLine("Thừa cân: " + biThuaCan);
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
        bt.HinhVuong();
        bt.HinhChuNhat();
        bt.HinhTron();
        bt.VanToc();
        bt.VND();
        bt.ChiaKeo();
        bt.NgayLe();
        bt.Tuan();
        bt.Time();
        bt.DiemTichLuy();
        bt.TienToHauTo();
        bt.LuongThucLinh();
        bt.SoChan();
        bt.Dat();
        bt.AND();
        bt.ChuyenDi();
        bt.BMI();
    }
}