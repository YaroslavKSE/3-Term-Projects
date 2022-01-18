namespace FirstTask;

public class Queue
{
    private const int Capacity = 50;

    private string[] _array = new string[Capacity];

    private int _pointer;

    public void Enqueue(string value)
    {
        if (_pointer == _array.Length)
        {
            throw new Exception("Stack overflowed");
        }

        _array[_pointer] = value;
        _pointer++;
    }

    public string Dequeue()
    {
        if (_pointer == 0)
        {
            return null;
        }

        var value = _array[0];
        _pointer--;
        for (var i = 0; i < _pointer; i++)
        {
            _array[i] = _array[i + 1];
        }
        return value;
    }

    public bool IsEmpty()
    {
        return _pointer == 0;
    }
    

    public string ToString()
    {
        return string.Join(' ', _array);
    }
}