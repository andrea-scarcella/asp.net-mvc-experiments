using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    [Serializable]
    public class TestOnderdeel
    {
     
        public string tekst { get; set; }
        public string antwoord { set; get; }
        public int? ID { get; set; }
    }
}
