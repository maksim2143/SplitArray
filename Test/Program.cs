using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitArray.Work;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Split split = new Split();
            var result = split.Start(Enumerable.Range(0, 100), 19);
            int count = 0;
            foreach (var item in result)
            {
                foreach (var ccc in item)
                {
                    Console.WriteLine(ccc);
                }
                Console.WriteLine(new string('-',30));
            }
            Console.WriteLine("Ok");
            Console.ReadKey();
        }
    }
}
