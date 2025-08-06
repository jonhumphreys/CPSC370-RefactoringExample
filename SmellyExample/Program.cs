namespace SmellyExample;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        Item sword = new Item("Sword");
        Item shield = new Item("Shield");
        Item potion = new Item("Potion");

        player.Inv.L.Add(sword);
        player.Inv.L.Add(potion);
        
        if (player.Inv.L.Contains(sword))
        {
            Console.WriteLine("Player is carrying a sword.");
        }
        else
        {
            Console.WriteLine("Player has no sword.");
        }

        if (player.Inv.L.Contains(shield))
        {
            Console.WriteLine("Player is carrying a shield.");
        }
        else
        {
            Console.WriteLine("Player has no shield.");
        }

        if (player.Inv.L.Contains(potion))
        {
            Console.WriteLine("Player is carrying a potion.");
        }
        else
        {
            Console.WriteLine("Player has no potion.");
        }

        Console.WriteLine("Summary:");
        foreach (Item item in player.Inv.L)
        {
            Console.WriteLine("- " + item.N);
        }
        
        if (player.Inv.L.Count > 2 &&
            player.Inv.L.Contains(potion))
        {
            Console.WriteLine("Player is ready for battle.");
        }
        else
        {
            Console.WriteLine("Player is NOT ready for battle.");
        }
    }
}