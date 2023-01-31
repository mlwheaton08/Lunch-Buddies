namespace Lunch_Buddies;

public class LunchBuddy
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public LunchBuddy(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void eat()
    {
        Restaurant restaurant = new Restaurant();
        Console.WriteLine($"{FirstName} is at {restaurant.Name}.");
    }

    public void eat(string food)
    {
        Console.WriteLine($"{FirstName} had {food} at the office.");
    }

    public void eat(List<LunchBuddy> companions)
    {
        Restaurant restaurant = new Restaurant();
        Console.WriteLine($"{FirstName} is at {restaurant.Name}.");

        Console.WriteLine("Lunch Buddies:");
        companions.ForEach(companion => Console.WriteLine(companion.FirstName));
    }

    public void eat(string food, List<LunchBuddy> companions)
    {
        Restaurant restaurant = new Restaurant();
        Console.WriteLine($"{FirstName} is at {restaurant.Name}. They ordered {food}.");

        Console.WriteLine("Lunch Buddies:");
        companions.ForEach(companion => Console.WriteLine(companion.FirstName));
    }
}