using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_533
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<<< задача 10 >>>");
            Console.Write("Введите число n = ");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            TwoList twoList = new TwoList();
            for (int i = 0; i < n; i++)
            {
                twoList.Add(random.Next(20));
            }

            twoList.Show();

            int p = twoList.Calc();

            Console.WriteLine($"Результат = {p}");
            Console.ReadLine();
        }
    }
}
