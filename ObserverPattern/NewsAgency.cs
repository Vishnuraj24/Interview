using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class NewsAgency
    {
        public delegate void NewsUpdateHandler(string msg);
                    
        public event NewsUpdateHandler NewsUpdated;

        public void SetNews(string news)
        {
            Console.WriteLine($"\nNewsAgency: Publishing new - {news}");
            NewsUpdated?.Invoke(news);
        }
    }
        
    public class PersonObserver {
        private string _name;
        public PersonObserver(string name)
        {
            _name = name;
        }

        public void ReceiveNews(string news)    
        {
            Console.WriteLine($"{_name} received news: {news}");
        }

    }
}
