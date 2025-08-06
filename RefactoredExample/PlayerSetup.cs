namespace SmellyExample;

public class PlayerSetup
{
    public PlayerSetup()
    {
        // create player
        Player player = new Player();

        // add items
        Item sword = new Item("Sword");
        Item shield = new Item("Shield");
        Item potion = new Item("Potion");

        player.Inventory.CarriedItems.Add(sword);
        player.Inventory.CarriedItems.Add(potion);
        
        // PrintInventoryStatus
        if (player.Inventory.CarriedItems.Contains(sword))
        {
            Console.WriteLine("Player is carrying a sword.");
        }
        else
        {
            Console.WriteLine("Player has no sword.");
        }

        if (player.Inventory.CarriedItems.Contains(shield))
        {
            Console.WriteLine("Player is carrying a shield.");
        }
        else
        {
            Console.WriteLine("Player has no shield.");
        }

        if (player.Inventory.CarriedItems.Contains(potion))
        {
            Console.WriteLine("Player is carrying a potion.");
        }
        else
        {
            Console.WriteLine("Player has no potion.");
        }

        // PrintInventory summary
        Console.WriteLine("Summary:");
        foreach (var item in player.Inventory.CarriedItems)
        {
            Console.WriteLine("- " + item.Name);
        }
        
        // Print battle readiness
        if (player.Inventory.CarriedItems.Count >= 2 &&
            player.Inventory.CarriedItems.Contains(new Item("Potion")))
        {
            Console.WriteLine("Player is ready for battle.");
        }
        else
        {
            Console.WriteLine("Player is NOT ready for battle.");
        }
    }
}