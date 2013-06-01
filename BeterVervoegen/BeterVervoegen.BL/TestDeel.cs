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
            List<TestOnderdeel> lst = null;
            if (goedeAntwoord)
            {
                lst = (List<TestOnderdeel>)goedeAntwoorden;
            }
            else
            {
                lst = (List<TestOnderdeel>)antwoorden;
            }
            lst.Add(t);
        }
    }
}
