using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    public class Test
    {
        public Guid Id
        {
            get;
            private set;
        }
        public Test()
        {
            Id = Guid.NewGuid();
            Items = new List<TestItem>();
        }

        public Test(IEnumerable<TestItem> itemList)
        {
            // TODO: Complete member initialization
            Items = itemList;
            Id = Guid.NewGuid();
        }
        public IEnumerable<TestItem> Items { get; private set; }


        public TestItem Item(int p1)
        {
            return Items.Where(x => x.Id == p1).FirstOrDefault();
        }

        public void Evaluate()
        {
            foreach (TestItem item in Items)
            {
                item.Evaluate();
            }
            //int okCount=Items.Where(x => x.Result().Equals("OK")).Count();
            int okCount = Items.Where(x => x.Result().Equals("OK")).Count();
            int count = Items.Count();
            correct = okCount == count;
        }

        public string Result()
        {

            return correct ? "OK" : "KO";

        }

        private bool correct { get; set; }

        public decimal Score()
        {
            decimal okCount = Items.Sum(x => x.Score);

            decimal maxScore = Items.Sum(x => x.MaxScore());
            decimal outp = 0;
            outp = 100.0m * okCount / maxScore;
            outp = Math.Truncate(outp);
            return outp;
            //throw new NotImplementedException();
        }
    }
}
