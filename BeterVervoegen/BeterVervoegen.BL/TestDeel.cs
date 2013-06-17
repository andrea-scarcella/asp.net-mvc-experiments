using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    [Serializable]
    public class TestDeel
    {
        public int? ID { get; set; }
        public TestDeel()
        {
            ID = null;
            goedeAntwoorden = new List<TestOnderdeel>();
            antwoorden = new List<TestOnderdeel>();
        }
        public string tekst { get; set; }
        public IList<TestOnderdeel> goedeAntwoorden { get; set; }
        public IList<TestOnderdeel> antwoorden { get; set; }
        public void add(string tekst, string antwoord, bool goedeAntwoord)
        {
            TestOnderdeel t = new TestOnderdeel();
            t.tekst = tekst;
            t.antwoord = antwoord;
            IList<TestOnderdeel> lst = null;
            if (goedeAntwoord)
            {
                lst = goedeAntwoorden;
            }
            else
            {
                lst = antwoorden;
            }
            lst.Add(t);
        }

        public bool corrigeren()
        {
            fouten = (from ant in antwoorden
                      from ga in goedeAntwoorden
                      where !(ant.antwoord.Equals(ga.antwoord))
                      select ant);
            return (fouten ?? new TestOnderdeel[] { }).Count() > 0;
        }


        private IEnumerable<TestOnderdeel> fouten { get; set; }

        internal void corrigeren(TestDeel testVraag)
        {
            fouten = (from ant in testVraag.antwoorden
                      from ga in goedeAntwoorden
                      where !(ant.antwoord.Equals(ga.antwoord))
                      select  ant);
            //return (fouten ?? new TestOnderdeel[] { }).Count() > 0;
        }
    }
}
