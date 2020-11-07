using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitArray.Work;

namespace TestProjectZ
{
    class Clone : ICloneable
    {
        public int Id { set; get; }
        public Clone(int Id)
        {
            this.Id = Id;
        }
        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {

            return (obj as Clone).Id == this.Id;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NewTest()
        {
            for (int i = 0; i < 20000; i++)
            {
                Check();
            }
           
        }
        public void Check()
        {
            int check = 0;
            List<Clone> list = Enumerable
                                 .Range(0, 1000).Select(x => new Clone(x)).ToList();
            Addition addition = new Addition();
            var result = addition.Start(list, 10);
            var z = result.Distinct().OrderBy(x => x.Id).ToList();
            CollectionAssert.AreEqual(z, list);
        }
        [TestMethod]
        public void TestMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                MultiThreadTest();
            }
            
        }
        public void MultiThreadTest()
        {
            int check = 0;
            var l = Enumerable
                                 .Range(0, 1000).Select(x => new Clone(x)).ToList(); 
            var list = new LinkedList<Clone>(l);
            Addition addition = new Addition();
            var res = Task.Run(()=> addition.Start(list, 10));
            List<Task> tasks = new List<Task>();
            Task.Run(() => addition.Start(list, 10));
            Task.Run(() => addition.Start(list, 10));
            tasks.Add(Task.Run(() => addition.Start(list, 10)));
            tasks.Add(Task.Run(() => addition.Start(list, 10)));
            var result = res.Result;
            Task.WaitAll(tasks.ToArray());
            var z = result.Distinct().OrderBy(x => x.Id).ToList();
            CollectionAssert.AreEqual(z,list);
        }
        
    }
}
