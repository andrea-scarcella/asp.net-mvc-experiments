using Byob.Domain;
using Byob.Domain.Services;
using Byob.Web.Controllers;
using Byob.Web.Models;
using FizzWare.NBuilder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
//using Telerik.JustMock;

namespace Byob.Web.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Setup()
        {
            generator = new RandomGenerator();
            _prmock = new Mock<IRepository<Post>>();
            _pr = _prmock.Object;
            _psmock = new Mock<PostService>(new object[] { _pr });
            _ps = _psmock.Object;
        }

        private PostVM GetValidPostVM()
        {
            return Builder<PostVM>
                 .CreateNew()
                 .With(x => x.title = "t" + generator.Phrase(10).Replace(" ", "1"))
                 .With(x => x.body = generator.Phrase(100))
                 .With(x => x.tags = Enumerable.Range(0, 10).ToList().Select(el => generator.Phrase(10).Replace(" ", "1")))
                 .Build();
        }

        [Test]
        public void WEB_When_a_user_attempts_to_post_without_a_title_return_an_error_message()
        {
            //Arrange
            var postVM = GetValidPostVM();
            var postSvc = _ps;
            var pc = new PostController(postSvc);
            postVM.title = "";
            pc.ModelState.AddModelError("title", "title is required.");
            ////add call to mocked post service
            ////Mock.Arrange(() => _pr.Save(Arg.Is<Post>(p0))).OccursOnce();
            _prmock.Setup(pr => pr.Save(It.IsAny<Post>()));
            _prmock.Verify(pr => pr.Save(It.IsAny<Post>()), Times.Never());
            //Act
            ViewResult result = pc.NewPost(postVM) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            var error = result.ViewData.ModelState["title"].Errors[0];
            Assert.AreEqual("title is required.", error.ErrorMessage);
        }

        [Test]
        public void WEB_When_a_user_attempts_to_post_without_a_body_return_an_error_message()
        {
            //Arrange
            var postVM = GetValidPostVM();
            var postSvc = _ps;
            var pc = new PostController(postSvc);
            postVM.body = "";
            pc.ModelState.AddModelError("body", "body is required.");
            ////add call to mocked post service
            ////Mock.Arrange(() => _pr.Save(Arg.Is<Post>(p0))).OccursOnce();
            _prmock.Setup(pr => pr.Save(It.IsAny<Post>()));
            _prmock.Verify(pr => pr.Save(It.IsAny<Post>()), Times.Never());
            //Act
            ViewResult result = pc.NewPost(postVM) as ViewResult;
        
            //Assert
            Assert.IsNotNull(result);
            var error = result.ViewData.ModelState["body"].Errors[0];
            Assert.AreEqual("body is required.", error.ErrorMessage);
          
        }
        [Test]
        public void WEB_post_body_is_required() {
            //Arrange
            var postVM = GetValidPostVM();
            postVM.body = "";
            //Act
            var errors = GetValidationErrors(postVM);
            //Assert
            Assert.Greater(errors.Count, 0);
            Assert.That(errors[0].ErrorMessage, Is.EqualTo("The body field is required."));

        }

        private static RandomGenerator generator;
        private IRepository<Post> _pr;
        private IPostService _ps;
        private Mock<IRepository<Post>> _prmock;
        private Mock<PostService> _psmock;
        //generic version of http://russellallen.info/post/2012/02/16/Testing-MVC3-DataAnnotations-And-Controller-Logic.aspx
        private static IList<ValidationResult> GetValidationErrors<T>(T model)
        {
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults);
            return validationResults;
        }

    }
}
