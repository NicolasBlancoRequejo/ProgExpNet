using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamics
{
    class Program
    {
        static dynamic y;

        static void Main(string[] args)
        {
            dynamic a = 1;
            Console.WriteLine(a);

            a = new string[0];
            Console.WriteLine(a);

            a = Test();
            Console.WriteLine(a);

            y = "carrot";

            Console.WriteLine(y.Foo());
        }

        static dynamic Test()
        {
            return 1;
        }
    }
}
