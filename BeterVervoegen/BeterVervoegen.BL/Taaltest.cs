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

            foreach (var templateVraag in this.vragen)
            {
                var taalTestUitslagVraag =
                    taalTestUitslag.vragen.Where(x => x.ID == templateVraag.ID).First();
                var nieuweTestOnderdelen = from uf in taalTestUitslagVraag.antwoorden
                                           join tf in templateVraag.antwoorden on uf.ID equals tf.ID
                                           select new TestOnderdeel { ID = tf.ID, tekst = uf.tekst, antwoord = uf.antwoord };
                templateVraag.antwoorden.Clear();
                foreach (var onderdeel in nieuweTestOnderdelen)
                {
                    templateVraag.antwoorden.Add(onderdeel);
                }
            }
            this.corrigeren();

        }
    }
}
