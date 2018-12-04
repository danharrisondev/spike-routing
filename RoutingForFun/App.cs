using System;
using System.Collections.Generic;

namespace RoutingForFun
{
    public class App
    {
        private Dictionary<string, string> _routes = new Dictionary<string, string>();

        public string Handle(string path)
        {
            string content;
            if (_routes.TryGetValue(path, out content))
                return content;

            throw new ArgumentException("path", "No route exists for the given path");
        }

        public void AddRoute(string home, string content)
        {
            _routes.Add(home, content);
        }
    }
}
