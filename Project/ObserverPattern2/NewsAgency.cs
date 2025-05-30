using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern2
{
    interface IObserver
    {
        public void Update(string news);
    }

    interface ISubject
    {
        public void Subscribe(Person person);
        public void Unsubscribe(Person person);
        public void SetNews(string news);

    }

    public class Person : IObserver
    {
        private string _name;
        public Person(string name) {
            _name = name;
        }

        public void Update(string news)
        {
            Console.WriteLine($"{_name} received: {news}");
        }
    }
    public class NewsAgency : ISubject
    {
        private List<Person> Personlist = new List<Person>();

        public void SetNews(string news)
        {
            NotifyUsers(news);
        }

        public void Subscribe(Person p)
        {
            Personlist.Add(p);
        }

        public void Unsubscribe(Person p)
        {
            Personlist.Remove(p);
        }

        private void NotifyUsers(string news)
        {
            foreach (Person p in Personlist)
            {
                p.Update(news);
            }
        }
    }
}
