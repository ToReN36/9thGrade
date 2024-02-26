using System;


namespace N3_2
{
    sealed class JaggedArray : Parent
    {
        private OneDimArray[] array;

        public JaggedArray(int n, bool entry = false) : base(entry)
        {
            array = new OneDimArray[n];
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
            OneDimArray massive;
            for (int i = 0; i < array.Length; i++)
            {
                massive = new OneDimArray(rnd.Next(1, 10));
                array[i] = massive;
            }
        }
        
        public override void UserEntry()
        {
            OneDimArray massive;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите m для массива {i + 1}");
                massive = new OneDimArray(int.Parse(Console.ReadLine()), true);
                array[i] = massive;
            }
        }

        public override void Print()
        {
            foreach (OneDimArray massive in array)
            {
                massive.Print();
            }
        }

        public override double AverageValue()
        {
            int counter = 0;
            double sum = 0;
            foreach (OneDimArray el in array)
            {
                for (int j = 0; j < el.Length; j++)
                {
                    sum += el[j];
                    counter++;
                }
            }

            return (sum / counter);
        }
    }
}
