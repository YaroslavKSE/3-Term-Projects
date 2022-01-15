namespace Term_3
{
    public class Array
    {
        private int[] _array = new int[10];

        private int _tailPointer;

        public int GetCount()
        {
            return _tailPointer;
        }

        private void Insert(int index, int element)
        {
            if (_tailPointer >= _array.Length)
            {
                var extendedArray = new int[_array.Length * 2];
                for (var i = 0; i < _array.Length; i++) extendedArray[i] = _array[i];

                _array = extendedArray;
            }

            for (var i = _tailPointer; i != index; i--) _array[i] = _array[i - 1];

            _array[index] = element;
            _tailPointer += 1;
        }

        public void Remove(int element)
        {
            var index = -1;
            for (var i = 0; i < _array.Length; i++)
                if (element == _array[i])
                {
                    index = i;
                    break;
                }

            if (index == -1) return;

            _array[index] = 0;
            for (var i = index; i < _array.Length - 1; i++) _array[i] = _array[i + 1];

            _tailPointer -= 1;
        }

        public int GetAt(int index)
        {
            return _array[index];
        }

        public int Pop(int element)
        {
            var lastElement = _array[_tailPointer - 1];
            _array[_tailPointer - 1] = 0;
            _tailPointer -= 1;
            return lastElement;
        }

        public void Push(int element)
        {
            Insert(_tailPointer, element);
        }

        public int IndexOf(int element)
        {
            for (var i = 0; i < _array.Length; i++)
                if (_array[i] == element)
                    return i;

            return -1;
        }
    }
}        