namespace Lunch_Buddies;

public class Restaurant
{
    public string Name { get; set; }
    private List<string> _restaurants = new List<string>()
    {
        "Dino's",
        "McDonald's",
        "MacHenry's",
        "Baja Burrito",
        "Hattie B's",
        "Victor's",
        "Oscar's",
        "Panera Bread",
        "Taco Bell"
    };

    public Restaurant()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(_restaurants.Count);
        Name = _restaurants[rndIndex];
    }
}
