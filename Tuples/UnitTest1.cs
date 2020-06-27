using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tuples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tuple<int, int, string> tt = new Tuple<int,int,string>(10, 200, "Hi");
            Console.WriteLine(tt);
            
        }
    }
}
