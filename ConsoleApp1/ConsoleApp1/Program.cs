using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> abc = new List<string>
            {
                "a",
                "b",
                "c"
            };
            var t1 = abc.ToList();
            var t2 = abc as List<string>;

            t1.Add("d");
            t2.Add("e");

            Console.Write(string.Join(",", t2));
        }
    }
}
