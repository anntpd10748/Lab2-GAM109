using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Bai1b
    {
        public static void GetDetail(dynamic value)
        {
            Console.WriteLine("Value: " +  value);
        }
        public static void bai1b()
        {
            GetDetail(10);
            GetDetail("game");
            GetDetail(true);
            GetDetail(9.5);
        }
    }
}
