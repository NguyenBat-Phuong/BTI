using System;

public class TienDien
{
    /*public static void Main(string[] args)
    {
        TienDien td = new TienDien();
        td.Chay();
    }*/

    public void Chay()
    {
        int chon = -1;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("===== TINH TIEN DIEN =====");
            Console.WriteLine("1. Tinh tien dien");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");

            chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                TinhTienDien();
            }
            else
            {
                if (chon != 0)
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }
            }

        } while (chon != 0);
    }

    void TinhTienDien()
    {
        Console.Write("Nhap so kWh tieu thu: ");
        int kwh = int.Parse(Console.ReadLine());

        if (kwh < 0)
        {
            Console.WriteLine("So kWh phai >= 0");
        }
        else
        {
            int soBac1 = TinhBac1(kwh);
            int soBac2 = TinhBac(kwh, 50, 100);
            int soBac3 = TinhBac(kwh, 100, 200);
            int soBac4 = TinhBac(kwh, 200, 300);
            int soBac5 = TinhBac(kwh, 300, 400);
            int soBac6 = TinhBac6(kwh);

            double tienBac1 = soBac1 * 1984;
            double tienBac2 = soBac2 * 2050;
            double tienBac3 = soBac3 * 2380;
            double tienBac4 = soBac4 * 2998;
            double tienBac5 = soBac5 * 3350;
            double tienBac6 = soBac6 * 3460;

            double truocVAT = tienBac1 + tienBac2 + tienBac3 + tienBac4 + tienBac5 + tienBac6;
            double vat = truocVAT * 0.08;
            double tongTien = Math.Round(truocVAT + vat);

            Console.WriteLine("");
            Console.WriteLine("===== CHI TIET TIEN DIEN =====");
            Console.WriteLine("Bac 1: " + soBac1 + " kWh x 1984 = " + tienBac1 + " dong");
            Console.WriteLine("Bac 2: " + soBac2 + " kWh x 2050 = " + tienBac2 + " dong");
            Console.WriteLine("Bac 3: " + soBac3 + " kWh x 2380 = " + tienBac3 + " dong");
            Console.WriteLine("Bac 4: " + soBac4 + " kWh x 2998 = " + tienBac4 + " dong");
            Console.WriteLine("Bac 5: " + soBac5 + " kWh x 3350 = " + tienBac5 + " dong");
            Console.WriteLine("Bac 6: " + soBac6 + " kWh x 3460 = " + tienBac6 + " dong");

            Console.WriteLine("Tong truoc VAT: " + truocVAT + " dong");
            Console.WriteLine("VAT 8%: " + vat + " dong");
            Console.WriteLine("Tong phai tra: " + tongTien + " dong");
        }
    }

    int TinhBac1(int kwh)
    {
        int soKwh = 0;

        if (kwh <= 50)
        {
            soKwh = kwh;
        }
        else
        {
            soKwh = 50;
        }

        return soKwh;
    }

    int TinhBac(int kwh, int batDau, int ketThuc)
    {
        int soKwh = 0;

        if (kwh <= batDau)
        {
            soKwh = 0;
        }
        else
        {
            if (kwh <= ketThuc)
            {
                soKwh = kwh - batDau;
            }
            else
            {
                soKwh = ketThuc - batDau;
            }
        }

        return soKwh;
    }

    int TinhBac6(int kwh)
    {
        int soKwh = 0;

        if (kwh <= 400)
        {
            soKwh = 0;
        }
        else
        {
            soKwh = kwh - 400;
        }

        return soKwh;
    }
}