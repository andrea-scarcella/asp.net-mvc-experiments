using Byob.Web.Controllers;
using Byob.Web.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Byob.Web.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Setup()
        {
            validPostVM = new PostVM();
            validPostVM.title = "";
            validPostVM.body = "";
            validPostVM.tags = new List<string>() { "p", "q" };
        }

        [Test]
        public void Can_post_a_valid_post()
        {
            //Arrange
            var postVM = validPostVM;
            var pc = new PostController();

            //Act
            ViewResult result = pc.NewPost(postVM) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }

        private PostVM validPostVM { get; set; }
    }
}
