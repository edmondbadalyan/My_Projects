


using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        DynArray<int> array = new DynArray<int>();

        array.Add(1);
        array.Add(2);
        array.Add(3);
        array.Add(4);    
        array.Add(5);
        array.Add(6);
        

        array.ForEach(Console.WriteLine);

        array.Remove(1);
        Console.WriteLine();
        array.ForEach(Console.WriteLine);
        int index = array.indexOf(3);
        Console.WriteLine();
        Console.WriteLine($"Index: {index}");
    }
}

internal class DynArray<T>
{
    private T[] array;
    

    private int count;
    public int Count => count;

    

    public DynArray(params T[] Values)
    {
        array = new T[Values.Length];

    }

    public T this[int index]
    {
        get { return array[index]; } 
        set { array[index] = value; } 
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, array.Length + 1);
        }
        array[count++] = item;
    }


    public bool Remove(T item)
    {
        int index = Array.IndexOf(array, item, 0, count);
        if (index < 0)
            return false;

        Array.Copy(array, index + 1, array, index, count - index - 1);
        count--;
        return true;
    }
    public int indexOf(T value)
    {
        return Array.IndexOf(array, value);
    }


    public void ForEach(Action<T> action)
    {
        for (int i = 0; i < count; i++)
        {
            action(array[i]);
        }
    }

    public override string ToString()
    {
        return string.Join(", ", array.Take(count));
    }

}

