public class Program
{
    static async Task Main(string[] args)
    {
        Racer racer1 = new ("Joey", 5, 109);
        Racer racer2 = new ("Goggen", 5, 89);
        Racer racer3 = new ("vanja", 5, 143);

        racer1.StartRace();
        racer2.StartRace();
        racer3.StartRace();   
    }
}