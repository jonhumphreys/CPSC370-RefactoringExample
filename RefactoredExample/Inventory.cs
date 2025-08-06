namespace SmellyExample;

public class Inventory
{
    public List<Item> CarriedItems = new List<Item>();

    public bool HasItem(Item item)
    {
        return CarriedItems.Contains(item);
    }
}
