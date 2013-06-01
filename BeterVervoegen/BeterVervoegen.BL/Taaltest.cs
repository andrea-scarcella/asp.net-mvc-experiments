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
        public  int ID { get; set; }
        public IEnumerable<TestDeel> vragen { get; set; }
    }
}
