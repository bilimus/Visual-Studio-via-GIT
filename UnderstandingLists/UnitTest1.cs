using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnderstandingLists
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Student> st = new List<Student>();

            st.Add(new Student());
            st.Add(new Student());
            st.Add(new Student());

            foreach(Student item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st.Count);

        }
    }
}
