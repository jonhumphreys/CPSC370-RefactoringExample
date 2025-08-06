namespace RefactoredExample;

public class Player
{
    private Inventory inventory = new Inventory();

    public void PickUp(Item item) => inventory.Add(item);

    public bool IsCarrying(Item item) => inventory.Contains(item);

    public IEnumerable<Item> GetInventory() => inventory.AllItems();
}