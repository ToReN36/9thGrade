using System;
using System.Threading;


namespace N3_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите тип массива:\n1 - одномерный\n2 - двумерный\n3 - ступенчатый");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите способ ввода:\ntrue - рандомно\nfalse - вручную");
            bool entry = bool.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("Введите количество элементов в массиве:");
                    OneDimArray onedim = new OneDimArray(int.Parse(Console.ReadLine()), entry);
                    onedim.Start();
                    break;

                case 2:
                    Console.WriteLine("Введите количество строк в массиве:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество столбцов в массиве:");
                    int m = int.Parse(Console.ReadLine());
                    TwoDimArray twodim = new TwoDimArray(n, m, entry);
                    twodim.Start();
                    break;

                case 3:
                    Console.WriteLine("Введите количество строк в массиве:");
                    JaggedArray jaggeddim = new JaggedArray(int.Parse(Console.ReadLine()), entry);
                    jaggeddim.Start();
                    break;
            }
        }
    }
}
