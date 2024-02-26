using System;


namespace N3_2
{
    internal class Program
    {
        static void Main()
        {
            Parent[] arr = new Parent[3];

            Console.WriteLine("Выберите способ ввода для всех массивов\nfalse - случайно\ntrue - вручную");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите количество элементов для одномерного массива:");
            int n1 = int.Parse(Console.ReadLine());
            OneDimArray onedim = new OneDimArray(n1, entry);

            Console.WriteLine();

            Console.WriteLine("Введите количество строк для двумерного массива:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов для двумерного массива:");
            int m = int.Parse(Console.ReadLine());
            TwoDimArray twodim = new TwoDimArray(n2, m, entry);

            Console.WriteLine();

            Console.WriteLine("Введите количество строк для ступенчатого массива:");
            int n3 = int.Parse(Console.ReadLine());
            JaggedArray jaggeddim = new JaggedArray(n3, entry);
            
            Console.WriteLine();

            arr[0] = onedim;
            arr[1] = twodim;
            arr[2] = jaggeddim;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Массив {arr[i].GetType()}:");
                arr[i].Print();
                Console.WriteLine($"Его среднее значение: {arr[i].AverageValue()}");
                Console.WriteLine();
            }
        }
    }
}
