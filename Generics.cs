// Box.cs
public class Box<T>
{
    private T item;

    public void StoreItem(T newItem)
    {
        item = newItem;
    }

    public T RetrieveItem()
    {
        return item;
    }
}

public static class Utilities
{
    public static void PrintItem<T>(T item)
    {
        Console.WriteLine("Printing item: " + item);
    }
}
