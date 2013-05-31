using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleChoiceQuestions.BL
{
    public class Antwoord
    {
        public Antwoord()
        {
            ID = 0;
        }
        public Antwoord(int id)
        {
           // Random rnd = new Random();
            ID = id;

        }
        public string tekst { get; set; }
        public int ID { get; set; }
    }
}
