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
    class Info:ICloneable
    {
        public int info {get; }
        public int Result { set; get; }
        public Info(int info)
        {
            this.info = info;
        }

        public object Clone()
        {
            return this.Clone();
        }
    }
    class Program
    {
        static void Start()
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
                Console.WriteLine(new string('-', 10));
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
                Console.WriteLine(new string('-', 30));
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
        static int Split()
        {
            var result =  Enumerable.Range(1, 1000)
                .Split(10)
                .Select(x => Task<int>.Run(() => x.Sum()));
            Task.WaitAll(result.ToArray());
            return result.Select(x => x.Result).Sum();
        }
        static void Addition()
        {
            var result = new List<Info>()
            {
                new Info(123),new Info(2132)
            };
            var res = result.Addition(3).Select(x => Task.Run(() => {
                x.Result = 1 * x.info;
                return x;
            }));
            Task.WaitAll(res.ToArray());
        }
        static void Multiplication()
        {
            var result = new List<Info>()
            {
                new Info(123),new Info(2132)
            };
            var x = result.Multiplication(3);
            List<Task> list = new List<Task>();
            foreach (var item in x)
            {
                var task = Task.Run(() =>
                {
                    return item.Select(b =>
                    {
                        b.Result = b.info + 1;
                        return b;
                    });
                });
                list.Add(task);
            }
            Task.WaitAll(list.ToArray());
        }
        static void Main(string[] args)
        {
            List<string> ls = Enumerable.Range(0, 100).Select(x => x.ToString()).ToList();
            var result = ls.Split(-10);
            Console.ReadKey();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
