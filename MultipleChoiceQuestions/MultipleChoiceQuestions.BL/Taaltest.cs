using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleChoiceQuestions.BL
{
    public class Taaltest
    {
        public Taaltest()
        {
            Random rnd = new Random();
            ID = 1;
            var tmp = new List<Vraag>();
            for (int i = 0; i < 4; i++)
            {
                var f = new Vraag(ID+i);
                f.tekst = "Vraag " + i;
                
                tmp.Add(f);
            }
            vragen = tmp;
        }
        private int ID { get; set; }
        public IEnumerable<Vraag> vragen { get; set; }
    }
}