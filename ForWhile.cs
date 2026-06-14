namespace ConsoleApp1;

public class ForWhile
{
    public static void Main()
    {
        ForWhile bt = new ForWhile();
        bt.Chay();
    }

    public void Chay()
    {
        Bai1();
        Bai2();
        Bai3();
        Bai4();
        Bai5();
        Bai6();
        Bai7();
        Bai8();
        Bai9();
        Bai10();
        Bai11();
        Bai12();
        Bai13();
        Bai14();
        Bai15();
        Bai16();
        Bai17();
        Bai18();
        Bai19();
        Bai20();
        Bai21();
        Bai22();
        Bai23();
        Bai24();
        Bai25();
        Bai26();
        Bai27();
        Bai28();
        Bai29();
        Bai30();
    }
    
    /*public void Bai26()
    {
        string sao = "*****";

        while (sao.Length > 0)
        {
            Console.WriteLine(sao);
            sao = sao.Substring(0, sao.Length - 1);
        }
    }*/
    public void Bai27()
    {
        int i = 5;
        
        Console.WriteLine("Bai 26");
        
        while (i >= 1)
        {
            int j = 1;

            while (j <= i)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i--;
        }
    }
    public void Bai28()
    {
        int i = 5;
        
        Console.WriteLine("Bai 27");
        
        while (i >= 1)
        {
            int j = 1;

            while (j <= 5)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i--;
        }
    }

    public void Bai30()
    {
        int i = 9;

        while (i >= 2)
        {
            int j = 1;

            while (j <= 9)
            {
                Console.WriteLine("Bảng " + i + ": " + i + " x " + j + " = " + (i * j));
                j++;
            }

            Console.WriteLine();
            i--;
        }
    }
    

    public void Bai1()
    {
        int i = 1;
        Console.WriteLine("Bai 1");

        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public void Bai2()
    {
        int i = 10;
        Console.WriteLine("Bai 2");

        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    public void Bai3()
    {
        int i = 0;
        Console.WriteLine("Bai 3");

        while (i <= 20)
        {
            Console.WriteLine(i);
            i += 2;
        }
    }

    public void Bai4()
    {
        int i = 1;
        Console.WriteLine("Bai 4");

        while (i <= 19)
        {
            Console.WriteLine(i);
            i += 2;
        }
    }

    public void Bai5()
    {
        int i = 5;
        Console.WriteLine("Bai 5");

        while (i <= 50)
        {
            Console.WriteLine(i);
            i += 5;
        }
    }

    public void Bai6()
    {
        int i = 1;
        int dem = 0;
        Console.WriteLine("Bai 6");

        while (i <= 100)
        {
            dem++;
            i++;
        }

        Console.WriteLine(dem);
    }

    public void Bai7()
    {
        int i = 50;
        Console.WriteLine("Bai 7");

        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    public void Bai8()
    {
        int i = 1;
        Console.WriteLine("Bai 8");

        while (i <= 30)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }

            i++;
        }
    }

    public void Bai9()
    {
        int i = 1;
        Console.WriteLine("Bai 9");

        while (i <= 100)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }

            i++;
        }
    }

    public void Bai10()
    {
        int i = 100;
        Console.WriteLine("Bai 10");

        while (i >= 0)
        {
            Console.WriteLine(i);
            i -= 10;
        }
    }

    public void Bai11()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 11");

        while (i <= 10)
        {
            tong += i;
            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai12()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 12");

        while (i <= 100)
        {
            tong += i;
            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai13()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 13");

        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                tong += i;
            }

            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai14()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 14");

        while (i <= 100)
        {
            if (i % 2 != 0)
            {
                tong += i;
            }

            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai15()
    {
        int i = 1;
        int tich = 1;
        Console.WriteLine("Bai 15");

        while (i <= 5)
        {
            tich *= i;
            i++;
        }

        Console.WriteLine(tich);
    }

    public void Bai16()
    {
        int n = 20;
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 16");

        while (i <= n)
        {
            tong += i;
            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai17()
    {
        int i = 1;
        int dem = 0;
        Console.WriteLine("Bai 17");

        while (i <= 100)
        {
            if (i % 7 == 0)
            {
                dem++;
            }

            i++;
        }

        Console.WriteLine(dem);
    }

    public void Bai18()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 18");

        while (i <= 50)
        {
            if (i % 3 == 0)
            {
                tong += i;
            }

            i++;
        }

        Console.WriteLine(tong);
    }

    public void Bai19()
    {
        int i = 2;
        int tong = 0;
        Console.WriteLine("Bai 19");

        while (i <= 100)
        {
            tong += i;
            i += 2;
        }

        Console.WriteLine(tong);
    }

    public void Bai20()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 20");

        while (i <= 99)
        {
            tong += i;
            i += 2;
        }

        Console.WriteLine(tong);
    }

    public void Bai21()
    {
        Console.WriteLine("Bai 21");
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;

        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public void Bai22()
    {
        Console.WriteLine("Bai 22");
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int i = n;

        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    public void Bai23()
    {
        int i = 30;
        Console.WriteLine("Bai 23");

        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    public void Bai24()
    {
        int i = 1;
        int giaiThua = 1;
        Console.WriteLine("Bai 24");

        while (i <= 6)
        {
            giaiThua *= i;
            i++;
        }

        Console.WriteLine(giaiThua);
    }

    public void Bai25()
    {
        int i = 1;
        int tong = 0;
        Console.WriteLine("Bai 25");

        while (tong <= 100)
        {
            tong += i;
            i++;
        }

        Console.WriteLine(i - 1);
    }

    public void Bai26()
    {
        int i = 1;

        Console.WriteLine("Bai 26");

        while (i <= 5)
        {
            int j = 1;

            while (j <= i)
            {
                Console.Write("*");
                j++;
            }

            Console.WriteLine();
            i++;
        }
    }

    public void Bai29()
    {
        int i = 1;

        Console.WriteLine("Bai 29");

        while (i <= 9)
        {
            Console.WriteLine("2 x " + i + " = " + (2 * i));
            i++;
        }
    }
}