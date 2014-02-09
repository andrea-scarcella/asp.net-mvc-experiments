using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain.UnitTests
{
    public class FactoryUntTests
    {
        [Test]
        public void FACTORY_Can_create_valid_post()
        {
            //Arrange

            //Act
            var post = PostFactory.factory("Title", "Body", null);
            //Assert
            Assert.IsNotNullOrEmpty(post.title);
            Assert.IsNotNullOrEmpty(post.body);
            Assert.IsNotNullOrEmpty(post.preview);
            Assert.LessOrEqual(post.preview.Length, 50);
        }
    }
}
