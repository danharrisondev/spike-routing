using System;

namespace RoutingForFun
{
    public class App
    {
        public string Handle(string path)
        {
            if (path == "home")
                return "Content for home page";

            if (path == "about")
                return "Content for about page";

            throw new ArgumentException("path", "No route exists for the given path");
        }
    }
}
