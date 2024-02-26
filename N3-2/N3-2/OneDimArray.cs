using System;


namespace N3_2
{
    sealed class OneDimArray : Parent
    {
        private int[] _array;

        public int Length
        {
            get { return _array.Length; }
        }

        public int this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public OneDimArray(int n, bool entry = false) : base(entry)
        {
            _array = new int[n];

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
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rnd.Next(1, 100);
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную:");
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = int.Parse(Console.ReadLine());
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
            return sum / _array.Length;
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", _array));
        }
    }
}
