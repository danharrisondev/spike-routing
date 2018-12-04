using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

        public void RegisterRoutesFromAssemblyContaining<T>()
        {
            var assemblyTypes = typeof(T).Assembly.GetTypes();

            foreach (var type in assemblyTypes)
            {
                var routeAttribute = type.GetCustomAttribute<RouteAttribute>();

                if (routeAttribute != null)
                {
                    AddRoute(routeAttribute.Path, (IStringView)Activator.CreateInstance(type));
                }
            }
        }

        private void AddRoute(string home, IStringView stringView)
        {
            _routes.Add(home, stringView);
        }
    }
}
