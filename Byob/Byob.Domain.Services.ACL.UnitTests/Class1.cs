using Byob.Web.Models;
using FizzWare.NBuilder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Byob.Domain.Services.ACL;

namespace Byob.Domain.Services.ACL.UnitTests
{
    public class PostACLUnitTests
    {
        private RandomGenerator generator;
        [SetUp]
        public void Setup()
        {
            generator = new RandomGenerator();
        }
        private PostVM getValidPost()
        {
            return Builder<PostVM>
                .CreateNew()
                .With(x => x.title = "t" + generator.Phrase(10).Replace(" ", "1"))
                .With(x => x.body = generator.Phrase(100))
                .Build();
        }

        [Test]
        public void ACL_add_post()
        {
            //Arrange
            var newPostVM = getValidPost();
           
            //Act
            IPostServiceACL postSvcACL = new PostServiceACL();
            var postEntity = postSvcACL.AddPost(newPostVM);
            //Assert
            Assert.AreEqual(newPostVM.body, postEntity.body);
            Assert.AreEqual(newPostVM.title, postEntity.title);
            Assert.AreEqual(newPostVM.tags, postEntity.tags);
        }
    }
}
