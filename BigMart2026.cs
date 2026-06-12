using System;

namespace ConsoleApp1
{
    public class BigMart2026
    {
        double tongTienBanDau;
        int loaiThanhVien;
        bool coVoucher;
        int diemTichLuy = 0;
        int phuongThucThanhToan;
        bool coDungDiem;

        public static void Main(string[] args)
        {
            BigMart2026 bm = new BigMart2026();

            while (true)
            {
                bm.Chay();

                Console.WriteLine();
                Console.Write("Tiep tuc mua hang? (Y/N): ");
                string tiepTuc = Console.ReadLine().ToUpper();

                if (tiepTuc == "N")
                {
                    Console.WriteLine("Cam on quy khach!");
                    break;
                }
            }
        }

        public void Chay()
        {
            NhapThongTin();
            TinhHoaDon();
        }

        public void NhapThongTin()
        {
            while (true)
            {
                Console.Write("Nhap tong tien mua hang: ");
                tongTienBanDau = double.Parse(Console.ReadLine());
                if (tongTienBanDau > 0) break;
                Console.WriteLine("Tong tien phai lon hon 0. Vui long nhap lai!");
            }
            Console.WriteLine("************* Loai thanh vien ***************");
            Console.WriteLine("1. Thuong | 2. Silver | 3. Gold | 4. Platinum");
            Console.Write("Nhap loai thanh vien: ");
            loaiThanhVien = int.Parse(Console.ReadLine());
            
            Console.Write("Co su dung voucher khong? Y/N: ");
            string yesNoVoucher = Console.ReadLine().ToUpper();
            while (yesNoVoucher != "Y" && yesNoVoucher != "N")
            {
                Console.Write("Nhap sai. Chi duoc nhap Y hoac N: ");
                yesNoVoucher = Console.ReadLine().ToUpper();
            }
            coVoucher = yesNoVoucher == "Y";

            Console.Write("Nhap so diem tich luy hien co cua khach hang: ");
            diemTichLuy = int.Parse(Console.ReadLine());

            coDungDiem = false;
            if (diemTichLuy > 0)
            {
                Console.Write("Khach hang co muon dung diem de giam tien khong? Y/N: ");
                string yesNoDiem = Console.ReadLine().ToUpper();
                while (yesNoDiem != "Y" && yesNoDiem != "N")
                {
                    Console.Write("Nhap sai. Chi duoc nhap Y hoac N: ");
                    yesNoDiem = Console.ReadLine().ToUpper();
                }
                coDungDiem = yesNoDiem == "Y";
            }

            Console.WriteLine("----------Phuong thuc thanh toan----------");
            Console.WriteLine("1. Tien mat | 2. Chuyen khoan / Vi dien tu");
            Console.Write("Nhap phuong thuc thanh toan: ");
            phuongThucThanhToan = int.Parse(Console.ReadLine());
        }

        public void TinhHoaDon()
        {
            double phanTramGiam = 0;

            // Thiết lập mức giảm cơ bản
            switch (loaiThanhVien)
            {
                case 1: phanTramGiam = 0; break;
                case 2: phanTramGiam = 3; break;
                case 3: phanTramGiam = 5; break;
                case 4: phanTramGiam = 8; break;
                default:
                    Console.WriteLine("Loai thanh vien khong hop le");
                    return;
            }

            // SỬA LỖI 2: Tách biệt các mốc để cộng dồn (không dùng else if)
            if (tongTienBanDau > 2000000)
            {
                if (loaiThanhVien == 1) phanTramGiam += 2;
                else if (loaiThanhVien == 2) phanTramGiam += 4;
                else if (loaiThanhVien == 3) phanTramGiam += 6;
                else if (loaiThanhVien == 4) phanTramGiam += 7;
            }

            if (tongTienBanDau > 5000000)
            {
                if (loaiThanhVien == 1) phanTramGiam += 5;
                else if (loaiThanhVien == 2) phanTramGiam += 7;
                else if (loaiThanhVien == 3) phanTramGiam += 10;
                else if (loaiThanhVien == 4) phanTramGiam += 12;
            }

            double tienSauGiamThanhVien = Math.Round(tongTienBanDau - (tongTienBanDau * phanTramGiam / 100));

            // Áp dụng Voucher
            double tienVoucher = 0;
            if (coVoucher)
            {
                if (tienSauGiamThanhVien > 3000000)
                    tienVoucher = 300000;
                else if (tienSauGiamThanhVien > 1000000)
                    tienVoucher = 100000;
            }

            double tienSauVoucher = Math.Round(tienSauGiamThanhVien - tienVoucher);
            if (tienSauVoucher < 0)
            {
                tienSauVoucher = 0;
            }
            double tienGiamBangDiem = 0;
            int diemDaDung = 0;

            if (coDungDiem)
            {
                double soTienMuonGiam = ((double)diemTichLuy / 100) * 10000;

                if (soTienMuonGiam > tienSauVoucher)
                {
                    tienGiamBangDiem = tienSauVoucher;
                    diemDaDung = (int)Math.Ceiling((tienGiamBangDiem / 10000) * 100);
                }
                else
                {
                    tienGiamBangDiem = soTienMuonGiam;
                    diemDaDung = diemTichLuy;
                }
            }
            
            diemTichLuy -= diemDaDung;

            double tienSauDiem = Math.Round(tienSauVoucher - tienGiamBangDiem);
            if (tienSauDiem < 0) tienSauDiem = 0;
            
            double tienGiamThanhToan = 0;
            if (phuongThucThanhToan == 2)
            {
                tienGiamThanhToan = Math.Round(tienSauDiem * 0.5 / 100);
            }
            else if (phuongThucThanhToan != 1)
            {
                Console.WriteLine("Phuong thuc thanh toan khong hop le");
                return;
            }

            double tongTienCuoi = Math.Round(tienSauDiem - tienGiamThanhToan);
           
            if (tongTienCuoi < 0) tongTienCuoi = 0; 
            
            int diemDuocCong = (int)(tongTienCuoi / 100000);
            diemTichLuy += diemDuocCong;
            
            Console.WriteLine("\n----------HOA DON BIGMART 2026----------");
            Console.WriteLine("Tien ban dau: " + tongTienBanDau);
            Console.WriteLine("Phan tram giam thanh vien: " + phanTramGiam + "%");
            Console.WriteLine("Tien sau giam thanh vien: " + tienSauGiamThanhVien);
            Console.WriteLine("Tien voucher: " + tienVoucher);
            Console.WriteLine("Tien giam bang diem: " + tienGiamBangDiem + $" (Da dung {diemDaDung} diem)");
            Console.WriteLine("Tien giam thanh toan: " + tienGiamThanhToan);
            Console.WriteLine("========================================");
            Console.WriteLine("Tong tien cuoi cung: " + tongTienCuoi);
            Console.WriteLine("Diem duoc cong them: " + diemDuocCong);
            Console.WriteLine("Tong diem tich luy hien tai: " + diemTichLuy);
        }
    }
}