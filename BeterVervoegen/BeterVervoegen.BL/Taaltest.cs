using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    public class Taaltest
    {
        public Taaltest()
        {
            vragen = new List<TestDeel>();
            fouten = new List<TestDeel>();
            //Random rnd = new Random();
            //ID = 1;
            //var tmp = new List<TestDeel>();
            //for (int i = 0; i < 4; i++)
            //{
            //    var f = new TestDeel();
            //    f.tekst = "Vraag " + i;

            //    tmp.Add(f);
            //}
            //vragen = tmp;
        }
        public int ID { get; set; }
        public IList<TestDeel> vragen { get; set; }

        public void corrigeren()
        {
            foreach (var item in vragen)
            {
                if (item.corrigeren())
                {
                    fouten.Add(item);
                }
            }
        }

        public IList<TestDeel> fouten
        {
            get;
            private set;
        }

        public void corrigeren(Taaltest taalTestUitslag)
        {

            var testUitslaagAntwoorden =
                from tttf in this.vragen
                join ttuf in taalTestUitslag.vragen on tttf.ID equals ttuf.ID
                select (
                from to1 in tttf.antwoorden
                join to2 in ttuf.antwoorden
                on to1.ID equals to2.ID
                select new { ID = tttf.ID, data = new TestOnderdeel { ID = to2.ID, tekst = to2.tekst, antwoord = to2.antwoord } }
                ).ToList();

            var testUitslaagTestOnderdeelList = testUitslaagAntwoorden.SelectMany(i => i);

            this.vragen.ForEach(v => v.antwoorden.ForEach(
                a => a.antwoord = testUitslaagTestOnderdeelList.Where(
                    testOnderdeelWrapper => (testOnderdeelWrapper.ID == v.ID)
                    ).
                Where(
                testOnderdeel => (testOnderdeel.data.ID == a.ID)
                ).First().data.antwoord)
                );
            this.corrigeren();

        }




    }
}
