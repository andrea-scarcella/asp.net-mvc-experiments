using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeterVervoegen.BL;
using FizzWare.NBuilder;

namespace BeterVervoegen.DAL
{
    public class Class1 : ITaaltestRepository
    {
        public IEnumerable<Taaltest> get(DateTime lookupData)
        {
            Taaltest t = new Taaltest();
            t.ID = 0;
            t.vragen = Builder<TestDeel>
                .CreateListOfSize(4)
                .All()
                .WithConstructor(() => new TestDeel())
                .And(x => x.goedeAntwoorden = Builder<TestOnderdeel>.CreateListOfSize(4).Build())
                .And(x => x.antwoorden = Builder<TestOnderdeel>.CreateListOfSize(4).Build())
                .Build();
            return new List<Taaltest> { t };
        }

        public Taaltest create()
        {
            throw new NotImplementedException();
        }

        public Taaltest save(Taaltest t)
        {
            throw new NotImplementedException();
        }

        public Taaltest update(Taaltest t)
        {
            throw new NotImplementedException();
        }

        public Taaltest delete(Taaltest t)
        {
            throw new NotImplementedException();
        }
    }
}
