using Lunch_Buddies;

LunchBuddy buddy1 = new LunchBuddy("Abe", "Lincoln");
buddy1.eat();
buddy1.eat("beans");
List<LunchBuddy> otherBuddies = new List<LunchBuddy>()
{
    new LunchBuddy("Joe", "Smith"),
    new LunchBuddy("Steve", "Smith"),
    new LunchBuddy("Jay", "Smith"),
    new LunchBuddy("Marge", "Smith")
};
buddy1.eat(otherBuddies);
buddy1.eat("beans", otherBuddies);