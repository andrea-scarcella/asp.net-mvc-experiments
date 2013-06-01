using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    public class TestDeel
    {
        public int ID { get; set; }

        public TestDeel(int p)
        {
            // TODO: Complete member initialization
            this.ID = p;
        }
        public string tekst { get; set; }
        public IEnumerable<TestOnderdeel> goedeAntwoorden;
        public IEnumerable<TestOnderdeel> antwoorden;
    }
}
