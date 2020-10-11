using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SplitArray.Work;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using SplitArray;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Addition
            Console.WriteLine("Addition");
            var result = Enumerable.Range(0, 10)
                .Select(x => x.ToString())
                .Addition(2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine(new string('.', 36));
            #region Multiplication
            Console.WriteLine("Multiplication");
            var result_two = Enumerable.Range(0, 10)
            .Select(x => x.ToString())
            .Multiplication(2);
            foreach (var xxx in result_two)
            {
                foreach (var y in xxx)
                {
                    Console.WriteLine(y);
                }
                Console.WriteLine(new string('-',10));
            }
            #endregion
            Console.WriteLine(new string('.', 36));
            #region Split
            Console.WriteLine("Split");
            var result_three = Enumerable.Range(0, 10).Select(x => x.ToString()).Split(3);
            foreach (var mmm in result_three)
            {
                foreach (var qqq in mmm)
                {
                    Console.WriteLine(qqq);
                }
                Console.WriteLine(new string('-',30));
            }
            #endregion
            Console.WriteLine(new string('.', 36));
            #region Subtract
            Console.WriteLine("Subtract");
            var result_four = Enumerable.Range(0, 10).Select(x => x.ToString()).Subtract(3);
            foreach (var item in result_four)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine(new string('.', 36));
            Console.ReadKey();
        }
    }
}
