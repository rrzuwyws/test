using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squaresincircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[сторона квадрата] [радиус окружности]:");
            string input = Console.ReadLine();
            double a = double.Parse(input.Split()[0]);
            double R = double.Parse(input.Split()[1]);
            int full = 0;
            int cut = 0;
            int temp = (int)Math.Floor(R / a);
            if (temp * a == R)
            {
                cut -= 2;
            }
            for (int i = 1; i <= Math.Floor(R / a); ++i)
            {
                double l = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(i * a, 2));
                int temp2 = (int) Math.Floor(l / a);
                cut += (1 + temp - temp2);
                full += temp2;
                temp = temp2;
            }
            cut += 1 + temp;
            cut *= 4;
            full *= 4;
            Console.WriteLine("cut: {0}, full: {1}, total: {2}", cut, full, cut + full);
            Console.ReadKey();
        }
    }
}
