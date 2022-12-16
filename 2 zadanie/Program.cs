using System;

namespace _2_zadanie
{
    class Program
    {
        static double F(double m, double n)
        {  
            double s, nf = 1, mf = 1, nm = 1;
            for (int i = 1; i <= n; i++)
                nf = nf * i;
            for (int j = 1; j <= m; j++)
                mf = mf * j;
            for (int j = 1; j <= n - m; j++)
                mf = mf * j;
            s = nf / (mf * nm);
            return s;
        }
            static void Main(string[] args)
            {
                double m;
                Console.WriteLine("введите m");
                while (!double.TryParse(Console.ReadLine(), out m))
                    Console.WriteLine("Некорректный ввод данных");
                double n;
                Console.WriteLine("введите n");
                while (!double.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Некорректный ввод данных");
                Console.WriteLine( F(m, n));
            }
        }
    }

