namespace SmellyExample;

public class Player
{
    public Inventory Inventory = new Inventory();

    public bool HasItem(Item item)
    {
        return Inventory.HasItem(item);
    }
}