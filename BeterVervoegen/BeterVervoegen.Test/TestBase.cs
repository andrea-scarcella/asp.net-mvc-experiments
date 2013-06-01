using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Diagnostics;

namespace BeterVervoegen.Test
{
    public class TestBase
    {
        public void Describes(string message)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------");

        }
        public void IsPending()
        {
            Console.WriteLine(" {0} -- PENDING -- ", GetCaller());
            Assert.Inconclusive();
        }
        public string GetCaller()
        {
            StackTrace stack = new StackTrace();
            return stack.GetFrame(2).GetMethod().Name.Replace("_", " ");
        }
    }
}
