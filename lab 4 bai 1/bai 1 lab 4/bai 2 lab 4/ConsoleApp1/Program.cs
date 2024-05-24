using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class userDataLab4
    {
        public string name;
        public int level;

        public userDataLab4(string _name, int lv)
        {
            name = _name;
            level = lv;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<userDataLab4> list = new List<userDataLab4>();
            list.Add(new userDataLab4("GTA 5", 10));
            list.Add(new userDataLab4("Genshin impact", 15));
            list.Add(new userDataLab4("Gunny", 5));
            list.Add(new userDataLab4("Liên minh huyền thoại", 100));

            var selectedData = list.Select(u => new { u.name, u.level });
            foreach (var item in selectedData)
            {
                Console.WriteLine("Name: " + item.name + " | level: " + item.level);
            }

  
            var sortedData = list.OrderByDescending(u => u.level).Select(u => new { u.name, u.level });
            Console.WriteLine("\nDanh sách sắp xếp theo thứ tự giảm dần của level:");
            foreach (var item in sortedData)
            {
                Console.WriteLine("Name: " + item.name + " | level: " + item.level);
            }
        }
    }
}
