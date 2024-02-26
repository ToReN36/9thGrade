using System;


namespace N3_1
{
    class TwoDimArray
    {
        int[,] _array;
    
        public TwoDimArray(int n, int m, bool entry = false)
        {
            _array = new int[n, m];
            if (entry)
            {
                RndEntry(n, m);
            }
            else
            {
                UserEntry(n, m);
            }
        }
        
        private void UserEntry(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        private void RndEntry(int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _array[i, j] = rnd.Next(-200, 200);
                }
            }
        }

        public void Print()
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
        
        public void Print_R()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = (_array.GetLength(1))-1; j >= 0; j--)
                    {
                        Console.Write($"{_array[i, j]} ");
                    }
                }
                else
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        Console.Write($"{_array[i, j]} ");
                    }
                }
                Console.WriteLine();
    
            }
        }

        public void Start()
        {
            Console.WriteLine();
            Print();
            Console.WriteLine();
            Print_R();
        }
    }
}
