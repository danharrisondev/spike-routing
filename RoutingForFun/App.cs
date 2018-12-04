using System;

namespace RoutingForFun
{
    public class App
    {
        public string Handle(string path)
        {
            if (path == "home")
                return "Content for home page";

            throw new ArgumentException("path", "No route exists for the given path");
        }
    }
}
