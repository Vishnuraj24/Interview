using ObserverPattern2;

NewsAgency agency = new NewsAgency();

Person Vishnu = new Person("Vishnu");
Person Ramu = new Person("Ramu");

agency.Subscribe(Vishnu);
agency.Subscribe(Ramu);

agency.SetNews("Trump is ready to sign a deal");

agency.Unsubscribe(Vishnu);

agency.SetNews("Modi is in Japan");

