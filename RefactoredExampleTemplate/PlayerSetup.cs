namespace RefactoredExample;

public class PlayerSetup
{
    public PlayerSetup()
    {
        Player player = CreatePlayerWithItems();
        List<Item> itemsToCheck = CreateItemsToCheck();

        PrintInventoryStatus(player, itemsToCheck);
        PrintInventorySummary(player);
        PrintBattleReadiness(player);
    }
    
    private Player CreatePlayerWithItems()
    {
        Player player = new Player();
        player.PickUp(new Item("Sword"));
        player.PickUp(new Item("Potion"));
        
        return player;
    }

    private List<Item> CreateItemsToCheck()
    {
        return new List<Item>
        {
            new Item("Sword"),
            new Item("Shield"),
            new Item("Potion")
        };
    }

    private void PrintInventoryStatus(Player player, List<Item> items)
    {
        foreach (Item item in items)
        {
            if (player.IsCarrying(item))
            {
                Console.WriteLine($"Player is carrying a {item.Name.ToLower()}.");
            }
            else
            {
                Console.WriteLine($"Player has no {item.Name.ToLower()}.");
            }
        }
    }

    private void PrintInventorySummary(Player player)
    {
        Console.WriteLine("Summary:");
        foreach (Item item in player.GetInventory())
        {
            Console.WriteLine("- " + item.Name);
        }
    }
    
    private void PrintBattleReadiness(Player player)
    {
        if (PlayerIsReadyForBattle(player))
        {
            Console.WriteLine("Player is ready for battle.");
        }
        else
        {
            Console.WriteLine("Player is NOT ready for battle.");
        }
    }

    private bool PlayerIsReadyForBattle(Player player)
    {
        return player.GetInventory().Count() >= 2 && player.IsCarrying(new Item("Potion"));
    }
}