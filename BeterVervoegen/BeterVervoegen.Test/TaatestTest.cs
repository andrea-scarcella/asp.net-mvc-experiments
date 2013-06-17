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
            Assert.AreEqual(1, fouten.AsEnumerable().Count());
        }

        [Test]
        public void testTemplateDetectsWrongAnswers()
        {

            ///#AS:2013/06/18: fundamentally wrong, use a repository implementation 
            //to get taaltest instances
            Taaltest templateTaaltest = new Taaltest();
            TestDeel templateTd = new TestDeel();
            templateTd.add("Tekst", "A1", true);
            templateTaaltest.vragen.Add(templateTd);

            Taaltest t = new Taaltest();
            TestDeel td = new TestDeel();
            td.add("Tekst", "Fout", false);
            t.vragen.Add(td);

            templateTaaltest.corrigeren(t);

            IList<TestDeel> fouten = templateTaaltest.fouten;
            //Has.Exactly(1).Member(t)
            Assert.AreEqual(1, fouten.AsEnumerable().Count());
        }
    }
}
