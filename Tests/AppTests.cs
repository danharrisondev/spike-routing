using System;
using NUnit.Framework;
using RoutingForFun;

namespace Tests
{
    public class AppTests
    {
        [Test]
        public void Home_returns_home_page_content()
        {
            var app = new App();
            var result = app.Handle("home");
            Assert.That(result, Is.EqualTo("Content for home page"));
        }

        [Test]
        public void About_returns_about_page_content()
        {
            var app = new App();
            var result = app.Handle("about");
            Assert.That(result, Is.EqualTo("Content for about page"));
        }

        [Test]
        public void Contact_returns_contact_page_content()
        {
            var app = new App();
            var result = app.Handle("contact");
            Assert.That(result, Is.EqualTo("Content for contact page"));
        }

        [Test]
        public void Unmatched_path_throws_argument_exception()
        {
            var app = new App();
            Assert.Throws<ArgumentException>(() => app.Handle("alskdj"));
        }
    }
}