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
            //CustomList<string> foo = new CustomList<string>(5);
            //CustomList<int> foo2 = new CustomList<int>();
            //foo.Add("Poke");
            //Console.WriteLine(foo.Count);
            //Console.WriteLine(foo.Capacity);
            //Console.WriteLine(foo[0]);
            //Console.WriteLine(foo[1]);
            //Console.WriteLine(foo.ToString());
            //Console.WriteLine(foo2.ToString());
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            Console.ReadKey();
        }
    }
}
