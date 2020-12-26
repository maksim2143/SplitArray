using System;
using System.Net.Http;
using Fast;
using System.Text.RegularExpressions;

namespace TestFast
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            ParallelL.For(0, 100, x => {
               var s =  client.GetAsync("https://spaces.im/").Result.
                                    Content.
                                    ReadAsStringAsync()
                                    .Result;
                Console.WriteLine(Regex.Match(s ?? "","<title>(?<title>[^<>]+)</title>")
                    .Groups["title"]
                    .Value);
                Console.WriteLine(x);
            },10);
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
