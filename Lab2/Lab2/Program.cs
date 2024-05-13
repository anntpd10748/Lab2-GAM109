using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bai1a");
            Bai1.bai1();
            Console.WriteLine();

            Console.WriteLine("bai1b");
            Bai1b.bai1b();
            Console.WriteLine();

            Console.WriteLine("bai1c");
            userData bai1c = new userData("123","abc",123);
            bai1c.Xuat();
            Console.ReadLine();
        }
    }
}
