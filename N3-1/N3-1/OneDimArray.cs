using System;


namespace N3_1
{
    class OneDimArray
    {
        int[] _array;
        
        public int[] Array
        {
            get { return _array; }
        }

        public int Length
        {
            get { return _array.Length; }
        }

        public int this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public OneDimArray(int n, bool entry = false)
        {
            _array = new int[n];
            if (entry)
            {
                RndEntry(n);
            }
            else
            {
                UserEntry(n);
            }
        }

        private void UserEntry(int n)
        {
            for (int i = 0; i < n; i++)
            {
                _array[i] = int.Parse(Console.ReadLine());
            }
        }
        
        private void RndEntry(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                _array[i] = rnd.Next(-200, 200);
            }
        }

        public double AverageValue()
        {
            double sum = 0;
            foreach (int el in _array)
            {
                sum += el;
            }
            return sum / _array.Length;
        }
        
        private void DeleteElementsGreate100()
        {
            int n = _array.Length;
            foreach (int el in _array)
            {
                if (Math.Abs(el) > 100)
                {
                    n--;
                }
            }
            int[] ArrayElementsLess100 = new int[n];
            int counter = 0;
            foreach (int el in _array)
            {
                if (Math.Abs(el) <= 100)
                {
                    ArrayElementsLess100[counter++] = el;
                }
            }
            _array = ArrayElementsLess100;
        }
        
        private void DeleteDublicates()
        {
            int newArrayLength = _array.Length;
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i; j < _array.Length; j++)
                {
                    if (_array[i] == _array[j] && i != j)
                    {
                        newArrayLength--;
                        break;
                    }
                }
            }
            int[] newArray = new int[newArrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.MinValue;
            }
            int counter = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (!Exists(_array[i], newArray))
                {
                    newArray[counter] = _array[i];
                    counter++;
                }
            }
            _array = newArray;
        }
        
        private static bool Exists(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        
        public void Print()
        {
            Console.WriteLine(String.Join(" ", _array));

        }

        public void Start()
        {
            Console.WriteLine();
            Print();
            Console.WriteLine($"Среднее значение массива: {AverageValue()}");
            Console.WriteLine("Не повторяющиеся элементы, <100 по модолю:");
            DeleteElementsGreate100();
            DeleteDublicates();
            Print();
        }
    }
}
