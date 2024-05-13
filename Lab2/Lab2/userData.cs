using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class userData
    {
        public string id, userName;
        public int level;
        public userData()
        {
            id = "0";
            level = 0;
            userName = "null";
        }
        public userData(string id, string userName, int level)
        {
            this.id = id;
            this.userName = userName;
            this.level = level;
        }
        public void Xuat()
        {
            Console.WriteLine("Id: " +  id);
            Console.WriteLine("UserName: " +  userName);
            Console.WriteLine("level: " +  level);
        }

    }
}
