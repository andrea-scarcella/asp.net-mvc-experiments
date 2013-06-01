using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BeterVervoegen.DAL;

namespace BeterVervoegen.Test
{
    [TestFixture]
    public class DummyTestDeelRepositoryTest : TestBase
    {
        public DummyTestDeelRepositoryTest()
        {
            this.Describes("DummyTestDeelRepository Test");
        }
        [SetUp]
        public void Init()
        {
            _rep = new DummyTestDeelRepository();
        }
        [Test]
        public void repository_assigns_id_on_insertion_of_new_object()
        {
            var td1 = _rep.create();
            td1.tekst = "Deel 1";
            var td2 = _rep.save(td1);
            Assert.IsNotNull(td2.ID);
        }
        [Test]
        public void repository_never_recycles_ids()
        {
            var td1 = _rep.create();
            var td2 = _rep.create();
            td1 = _rep.save(td1);
            _rep.delete(td1);
            td2 = _rep.save(td2);
            Assert.AreNotEqual(td1.ID, td2.ID);
        }
        public DummyTestDeelRepository _rep { get; set; }
    }
}
