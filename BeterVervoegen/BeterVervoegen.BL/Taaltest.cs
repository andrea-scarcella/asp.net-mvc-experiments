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
    }
}
