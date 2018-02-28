using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> foo = new CustomList<string>(5);
            CustomList<int> foo2 = new CustomList<int>();
            foo.Add("Poke");
            Console.WriteLine(foo.Count);
            Console.WriteLine(foo.Capacity);
            Console.WriteLine(foo[0]);
            Console.WriteLine(foo[1]);
            Console.WriteLine(foo.ToString());
            Console.WriteLine(foo2.ToString());
            Console.ReadKey();
        }
    }
}
