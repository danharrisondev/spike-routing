using System;
using System.Collections.Generic;

namespace RoutingForFun
{
    public class App
    {
        private Dictionary<string, IStringView> _routes = new Dictionary<string, IStringView>();

        public string Handle(string path)
        {
            IStringView view;
            if (_routes.TryGetValue(path, out view))
                return view.GetContent();

            throw new ArgumentException("path", "No route exists for the given path");
        }

        public void AddRoute(string home, IStringView stringView)
        {
            _routes.Add(home, stringView);
        }
    }
}
