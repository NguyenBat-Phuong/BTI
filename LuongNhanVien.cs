namespace ConsoleApp1;

using System;

public class LuongNhanVien
{
    private double luongCoBan;
    private double phuCapChucVu;
    private double phuCapThamNien;
    private double tienOT;
    private double tongThuNhap;
    private double baoHiem;
    private double thueTNCN;
    private double luongThucNhan;

    public static void Main(string[] args)
    {
        LuongNhanVien lnv = new LuongNhanVien();
        lnv.Chay();
    }

    public void Chay()
    {
        NhapLuongCoBan();
        ChonChucVu();
        TinhThamNien();
        TinhGioLamThem();
        TinhKhauTru();
        InKetQua();
    }

    public void NhapLuongCoBan()
    {
        Console.Write("Nhap luong co ban, don vi trieu dong: ");
        double luongTrieu = double.Parse(Console.ReadLine());

        luongCoBan = luongTrieu * 1000000;

        if (luongCoBan < 1000000)
        {
            Console.WriteLine("Luong co ban phai lon hon hoac bang 1.000.000 VND");
            NhapLuongCoBan();
        }
    }

    public void ChonChucVu()
    {
        Console.WriteLine("1. Nhan vien");
        Console.WriteLine("2. Truong nhom");
        Console.WriteLine("3. Truong phong");
        Console.WriteLine("4. Giam doc");
        Console.Write("Chon chuc vu: ");

        int chucVu = int.Parse(Console.ReadLine());

        switch (chucVu)
        {
            case 1:
            {
                phuCapChucVu = 500000;
                break;
            }

            case 2:
            {
                phuCapChucVu = 2000000;
                break;
            }

            case 3:
            {
                phuCapChucVu = 5000000;
                break;
            }

            case 4:
            {
                phuCapChucVu = 12000000;
                break;
            }

            default:
            {
                Console.WriteLine("Chuc vu khong hop le!");
                ChonChucVu();
                break;
            }
        }
    }

    public void TinhThamNien()
    {
        Console.Write("Nhap so nam tham nien: ");
        double namThamNien = double.Parse(Console.ReadLine());

        if (namThamNien < 3)
        {
            phuCapThamNien = 0;
        }
        else if (namThamNien <= 5)
        {
            phuCapThamNien = luongCoBan * 0.05;
        }
        else if (namThamNien <= 10)
        {
            phuCapThamNien = luongCoBan * 0.10;
        }
        else
        {
            phuCapThamNien = luongCoBan * 0.18;
        }
    }

    public void TinhGioLamThem()
    {
        Console.Write("Nhap so gio OT: ");
        int soGioOT = int.Parse(Console.ReadLine());

        double luongGio = luongCoBan / 22 / 8;

        if (soGioOT <= 40)
        {
            tienOT = soGioOT * luongGio * 1.5;
        }
        else
        {
            tienOT = 40 * luongGio * 1.5 + (soGioOT - 40) * luongGio * 2;
        }
    }

    public void TinhKhauTru()
    {
        tongThuNhap = luongCoBan + phuCapChucVu + phuCapThamNien + tienOT;

        baoHiem = (luongCoBan + phuCapChucVu) * 0.105;

        if (tongThuNhap < 10000000)
        {
            thueTNCN = 0;
        }
        else if (tongThuNhap <= 20000000)
        {
            thueTNCN = tongThuNhap * 0.05;
        }
        else if (tongThuNhap <= 35000000)
        {
            thueTNCN = tongThuNhap * 0.10;
        }
        else
        {
            thueTNCN = tongThuNhap * 0.15;
        }

        luongThucNhan = Math.Floor(tongThuNhap - baoHiem - thueTNCN);
    }

    public void InKetQua()
    {
        Console.WriteLine("=======================================================");
        Console.WriteLine("Luong co ban: " + luongCoBan.ToString("N0") + " dong");
        Console.WriteLine("Phu cap chuc vu: " + phuCapChucVu.ToString("N0") + " dong");
        Console.WriteLine("Phu cap tham nien: " + phuCapThamNien.ToString("N0") + " dong");
        Console.WriteLine("Tien lam them gio: " + tienOT.ToString("N0") + " dong");
        Console.WriteLine("Tong thu nhap truoc khau tru: " + tongThuNhap.ToString("N0") + " dong");
        Console.WriteLine("Khau tru BHXH + BHYT: " + baoHiem.ToString("N0") + " dong");
        Console.WriteLine("Khau tru thue TNCN: " + thueTNCN.ToString("N0") + " dong");
        Console.WriteLine("Luong thuc nhan: " + luongThucNhan.ToString("N0") + " dong");
    }
}