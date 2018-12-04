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
    }
}