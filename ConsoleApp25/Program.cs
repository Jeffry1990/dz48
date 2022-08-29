using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = 10;
            int numberOfColumns = 10;
            int matrixElementMax = 0;
            int[,] array = new int[numberOfLines, numberOfColumns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random random = new Random();
                    int minValueArray = 1;
                    int maxValueArray = 9;
                    array[i, j] = random.Next(minValueArray, maxValueArray);
                    Console.Write(array[i, j] + " ");

                    if (matrixElementMax < array[i, j])
                    {
                        matrixElementMax = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент матрицы: {matrixElementMax}\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] == matrixElementMax)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
            
   

        
    