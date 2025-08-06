namespace RefactoredExample;

public class Item
{
    public string Name { get; }

    public Item(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;

    // Equality override to allow item comparison
    public override bool Equals(object obj)
    {
        if (obj is Item other)
        {
            return Name == other.Name;
        }
        return false;
    }

    public override int GetHashCode() => Name.GetHashCode();
}