using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BeterVervoegen.BL;
namespace BeterVervoegen.Test
{
    [TestFixture]
    public class TaatestTest : TestBase
    {
        [SetUp]
        public void Init()
        {
        }
        [Test]
        public void wrongAnswersAreDetected()
        {
            Taaltest t = new Taaltest();
            TestDeel td = new TestDeel();
            
            td.add("Tekst", "Fout", false);
            td.add("Tekst", "A1", true);
            t.vragen.Add(td);
            t.corrigeren();
            IList<TestDeel> fouten = t.fouten;
            //Has.Exactly(1).Member(t)
            Assert.AreEqual(fouten.AsEnumerable().Count(), 1);
        }
    }
}
