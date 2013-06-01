using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeterVervoegen.BL;

namespace BeterVervoegen.DAL
{
    public class DummyTestDeelRepository : ITestDeelRepository
    {
        private List<TestDeel> _repo = new List<TestDeel>();
        private int lastIdx = 0;
        public TestDeel create()
        {
            TestDeel t = new TestDeel();
            return t;
        }

        public TestDeel save(TestDeel t)
        {
            lastIdx++;
            t.ID = lastIdx;
            _repo.Add(ObjectCopier.Clone(t));
            return t;
        }

        public TestDeel update(TestDeel t)
        {
            delete(t);
            _repo.Add(ObjectCopier.Clone(t));
            return t;
        }

        private IEnumerable<TestDeel> findById(TestDeel t)
        {
            var match = from td in _repo where td.ID == t.ID select td;
            if (match == null)
            {
                throw new ApplicationException("Object not found");
            }
            return match;
        }

        IEnumerable<TestDeel> IRepository<TestDeel, string>.get(string lookupData)
        {
            var result = from td in _repo where td.tekst.Contains(lookupData) select td;
            return result;
        }


        public TestDeel delete(TestDeel t)
        {
            var match = findById(t);
            _repo.Remove(match.FirstOrDefault());
            return t;
        }
    }
}
