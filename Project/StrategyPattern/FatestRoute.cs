using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IRouteStrategy
    {
        void BuildRoute(string source, string destination);
    }
    public class FatestRoute : IRouteStrategy
    {
        public void BuildRoute(string source, string destination) {
            Console.WriteLine($"This is the Fastest Route between {source} and {destination}");
        }

    }

    public class ShortestRoute : IRouteStrategy
    {
        public void BuildRoute(string source, string destination) { 
            Console.WriteLine($"This is the Shortest Route between {source} and {destination}");
        }
    }

    public class TollFreeRoute : IRouteStrategy
    {
        public void BuildRoute(string source, string destination)
        {
            Console.WriteLine($"This is the Tollfree Route between {source} and {destination}");
        }
    }

    public class NavContext
    {
        private IRouteStrategy _strategy;
        public NavContext(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Navigate(string source, string destination)
        {
            _strategy.BuildRoute(source, destination);
        }

    }


}
