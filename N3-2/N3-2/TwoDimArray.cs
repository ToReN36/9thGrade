using System;


namespace N3_2
{
    sealed class TwoDimArray : Parent
    {
        int m;
        int n;
        
        private int[,] _array;

        public TwoDimArray(int n, int m, bool entry = false) : base(entry)
        {
            _array = new int[n, m];
            this.m = m;
            this.n = n;
            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }

        public override void RndEntry()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _array[i, j] = rnd.Next(1, 100);
                }
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public override double AverageValue()
        {
            double sum = 0;
            foreach (int el in _array)
            {
                sum += el;
            }
            return (sum / _array.Length);
        }
        
        public override void Print()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.Write($"{_array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
