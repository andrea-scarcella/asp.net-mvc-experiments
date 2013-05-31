using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleChoiceQuestions.BL
{
    public class Vraag
    {
        public   int ID { get; set; }
        public Vraag()
        {
            ID = 0;
        }
        public Vraag(int id)
        {
            //Random rnd = new Random();
            ID = id;
            var tmp = new List<Antwoord>();
            for (int i = 0; i < 4; i++)
            {
                var a = new Antwoord(ID+i);
                a.tekst = "Antwoord " + i;
                tmp.Add(a);
            }
            antwoorden = tmp;
        }
        public string tekst { get; set; }
        public IEnumerable<Antwoord> antwoorden { get; set; }
        public int? gekozenAntwoord { get; set; }
    }
}
