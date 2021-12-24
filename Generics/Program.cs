// See https://aka.ms/new-console-template for more information

List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
Console.WriteLine(sehirler2.Count);


//Generic Class
class MyList<T>
{
    T[] _array;
    T[] _tampArray;


    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tampArray = _array;
        _array = new T[_array.Length+1];
        for (int i = 0; i < _tampArray.Length; i++)
        {
            _array[i] = _tampArray[i];
        }
        _array[_array.Length - 1] = item;
    }

    private int _count;

    public int Count
    {
        get { return _array.Length; }
    }

}

