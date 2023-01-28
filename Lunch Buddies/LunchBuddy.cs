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

    public void Eat()
    {

    }
}