using ObserverPattern;

NewsAgency agency = new NewsAgency();

var Ramu =  new PersonObserver("Ramu");
var Vishnu = new PersonObserver("Vishnu");


agency.NewsUpdated += Ramu.ReceiveNews;
agency.NewsUpdated += Vishnu.ReceiveNews;

agency.SetNews("Trump has declared trade war against china");

agency.NewsUpdated -= Vishnu.ReceiveNews;

agency.SetNews("India has declared a war against terrorism");

