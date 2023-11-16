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