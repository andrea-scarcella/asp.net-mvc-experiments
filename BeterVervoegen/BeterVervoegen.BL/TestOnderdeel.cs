using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    public class TestOnderdeel
    {
        public TestOnderdeel()
        {
            ID = 0;
        }
        public TestOnderdeel(int id)
        {
            ID = id;

        }
        public string tekst { get; set; }
        public string antwoord { set; get; }
        public int ID { get; set; }
    }
}
