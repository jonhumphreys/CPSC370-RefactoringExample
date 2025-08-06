namespace RefactoredExample;

public class Inventory
{
    private List<Item> items = new List<Item>();

    public void Add(Item item) => items.Add(item);

    public bool Contains(Item item) => items.Contains(item);

    public IEnumerable<Item> AllItems() => items;
}