using Byob.Dal;
using Byob.Domain.Services;
using FizzWare.NBuilder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telerik.JustMock;

namespace Byob.Domain.UnitTests
{
    public class Class1
    {
        private IPostService ps;
        private IRepository<Post> _pr;
        private static RandomGenerator generator;

        [SetUp]
        public void Setup()
        {
            generator = new RandomGenerator();
            _pr = Mock.Create<IRepository<Post>>();
            ps = new PostService(_pr);


        }

        private static Post getValidPost()
        {
            return Builder<Post>
                .CreateNew()
                .With(x => x.title = "t" + generator.Phrase(10).Replace(" ", "1"))
                .With(x => x.body = generator.Phrase(100))
                .Build();
        }
        [Test]
        public void When_a_user_attempts_to_post_a_valid_post_it_should_be_added()
        {
            //Arrange
            Post p = getValidPost();

            Mock.Arrange(() => _pr.Save(Arg.IsAny<Post>())).OccursOnce();
            //Act
            ps.AddPost(p);
            //Assert
            Mock.Assert(_pr);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void When_a_user_attempts_to_post_without_a_title_throw_ArgumentException()
        {
            //Arrange
            Post p = getValidPost();
            p.title = "";
            //Act
            ps.AddPost(p);
            //Assert - see exception
        }
        [Test]
        public void When_a_valid_post_is_added_a_50_line_preview_is_generated()
        {
            //Arrange
            Post p = getValidPost();
            //Act
            ps.AddPost(p);
            //Assert
            Assert.AreEqual(p.preview, p.body.Substring(0, 50));
        }

        [Test]
        public void When_a_valid_post_is_added_a_preview_is_generated_that_is_at_most_50_chars()
        {
            //Arrange
            Post p = getValidPost();
            p.body = p.body.Substring(0, 17);
            //Act
            ps.AddPost(p);
            //Assert
            Assert.AreEqual(p.preview, p.body);
        }
        [Test]
        public void CanReturnAllPosts()
        {
            //Arrange
            var p0 = getValidPost();
            var p1 = getValidPost();
            IEnumerable<Post> pp = new[] { p0, p1 };
            //Code smell 
            //repo implementation details do not belong here
            Mock.Arrange(() => _pr.Save(Arg.Is<Post>(p0))).OccursOnce();
            Mock.Arrange(() => _pr.Save(Arg.Is<Post>(p1))).OccursOnce();
            Mock.Arrange(() => _pr.Find(
                Arg.Matches<Expression<Func<Post, bool>>>(p=>true)
                )
                ).Returns(pp)
                .OccursOnce();
            //Find
            ps.AddPost(p0);
            ps.AddPost(p1);
            //Act
            IEnumerable<Post> posts = ps.getPosts().Take(2);
            //Assert
            Mock.Assert(_pr);
            Assert.AreEqual(2, posts.Count());
        }

    }
}
