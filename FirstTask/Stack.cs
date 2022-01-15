using System;

namespace FirstTask
{
    public class Stack
    {
        private string[] _array = new string[50];

        private int _pointer = 0;

        public void Push(string element)
        {
            if (_pointer == _array.Length)
                throw new Exception("Stack overflow");
            var ExtendedArray = new string[_array.Length * 2];
            for (var i = 0; i < _array.Length; i++) ExtendedArray[i] = _array[i];

            _array = ExtendedArray;
            _array[_pointer] = element;
            _pointer += 1;
        }

        private string Pop()
        {
            if (_pointer == 0)
            {
                throw new Exception("Stack is already empty");
            }
            var returnValue = _array[_pointer - 1];
            _pointer -= 1;
            _array[_pointer] = null;
            return returnValue;
        }

        private string Seek()
        {
            if (_pointer == 0)
            {
                throw new Exception("Stack is already empty");
            }
            return _array[_pointer - 1];
        }
    }
}