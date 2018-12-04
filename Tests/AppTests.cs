using System;
using NUnit.Framework;
using RoutingForFun;

namespace Tests
{
    public class AppTests
    {
        private App _app;

        [SetUp]
        public void Set_up_routes()
        {
            _app = new App();
            _app.RegisterRoutesFromAssemblyContaining<HomeView>();
        }

        [Test]
        public void Home_returns_home_page_content()
        {
            var result = _app.Handle("home");
            Assert.That(result, Is.EqualTo("Content for home page"));
        }

        [Test]
        public void About_returns_about_page_content()
        {
            var result = _app.Handle("about");
            Assert.That(result, Is.EqualTo("Content for about page"));
        }

        [Test]
        public void Contact_returns_contact_page_content()
        {
            var result = _app.Handle("contact");
            Assert.That(result, Is.EqualTo("Content for contact page"));
        }

        [Test]
        public void Unmatched_path_throws_argument_exception()
        {
            Assert.Throws<ArgumentException>(() => _app.Handle("Unmatched path"));
        }
    }

    [Route("home")]
    public class HomeView : IStringView
    {
        public string GetContent()
        {
            return "Content for home page";
        }
    }

    [Route("about")]
    public class AboutView : IStringView
    {
        public string GetContent()
        {
            return "Content for about page";
        }
    }

    [Route("contact")]
    public class ContactView : IStringView
    {
        public string GetContent()
        {
            return "Content for contact page";
        }
    }
}