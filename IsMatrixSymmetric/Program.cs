//1 ЗАДАНИЕ
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы (количество строк и столбцов): ");
        int a = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[a, a];
        Random random = new Random();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                array[i, j] = random.Next(1, 11);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        bool isSymmetric = CheckSymmetry(array);

        if (isSymmetric)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    private static bool CheckSymmetry(int[,] array)
    {
        int length = array.GetLength(0);
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (array[i, j] != array[j, i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}



//2 ЗАДАНИЕ
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите длину массива: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        if (n < 0 || n > 100)
//        {
//            Console.WriteLine("Размерность массива должно быть не больше 100 и не меньше 0");
//            Environment.Exit(0);
//        }
//        int[] numbers = new int[n];

//        int Num = 0;
//        for (int i = 0; i < n; i++)
//        {
//            Num = Convert.ToInt32(Console.ReadLine());
//            if (Num < -100 || Num > 100)
//            {
//                Console.WriteLine("Число должно быть не меньше -100 и не больше 100");
//                Environment.Exit(0);
//            }
//            numbers[i] = Num;
//        }

//        Console.WriteLine("");

//        bool result = false;
//        for (int i = 0; i < (n - 1); i++)
//        {
//            if (result == false)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    if (i != j && numbers[i] == numbers[j] * -1)
//                    {
//                        result = true;
//                        if (i < j)
//                            Console.Write($"{i} {j}");
//                        else
//                            Console.Write($"{j} {i}");
//                        break;
//                    }
//                }
//            }
//            else
//                break;
//        }
//    }
//}



//3 ЗАДАНИЕ
//using System;

//class Program
//{
//    static void Main()
//    {
//        int days = Convert.ToInt32(Console.ReadLine());

//        int[] temperatures = new int[days];
//        for (int i = 0; i < days; i++)
//        {
//            temperatures[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        for (int i = 1; i < days - 1; i++)
//        {
//            if (temperatures[i] > temperatures[i - 1] && temperatures[i] > temperatures[i + 1])
//            {
//                Console.WriteLine($"day {i + 1}: {temperatures[i]} (max)");
//            }
//            else if (temperatures[i] < temperatures[i - 1] && temperatures[i] < temperatures[i + 1])
//            {
//                Console.WriteLine($"day {i + 1}: {temperatures[i]} (min)");
//            }
//        }
//    }
//}
