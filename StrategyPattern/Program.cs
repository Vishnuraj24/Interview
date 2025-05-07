
using StrategyPattern;

NavContext navContext = new NavContext(new FatestRoute());
NavContext navContext1 = new NavContext(new ShortestRoute());
NavContext navContext2 = new NavContext(new TollFreeRoute());

string source = "Hyderabad";
string destination = "Bangalore";

navContext.Navigate(source,destination);
navContext1.Navigate(source,destination);
navContext2.Navigate(source,destination);

