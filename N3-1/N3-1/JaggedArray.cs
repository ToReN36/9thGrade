using System;


namespace N3_1
{
    class JaggedArray
    {
        public OneDimArray[] _array;
        
        public JaggedArray(int n, bool entry = false)
        {
            _array = new OneDimArray[n];
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
                _array[i] = new OneDimArray(int.Parse(Console.ReadLine()));
            }
        }
    
        private void RndEntry(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                _array[i] = new OneDimArray(rnd.Next(1, 10), true);
            }
        }
        
        public double AverageValue()
        {
            int counter = 0;
            double sum = 0;
            foreach (OneDimArray el in _array)
            {
                for (int j = 0; j < (el.Array).Length; j++)
                {
                    sum += (el.Array)[j];
                    counter++;
                }
            }
            return sum / counter;
        }
        
        public void AverageValueMassives()
        {
            foreach (OneDimArray el in _array)
            {
                Console.WriteLine(el.AverageValue());
            }
        }
        
        public void MultiplyIndex()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] % 2 == 0)
                    {
                        _array[i][j] = i * j;
                    }
                }
            }
        }
        
        public void Print()
        {
            foreach (OneDimArray el in _array)
            {
                el.Print();
            }
        }

        public void Start()
        {
            Console.WriteLine();
            Print();
            Console.WriteLine($"Среднее значение массива: {AverageValue()}");
            Console.WriteLine("Среднее значение массивов:");
            AverageValueMassives();
            Console.WriteLine("Замена всех четных по значению элементов массива на произведения их индексов.");
            MultiplyIndex();
            Print();
        }
    }
}
