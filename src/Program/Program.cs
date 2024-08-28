using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            FileReader fileReader = new FileReader();
            int[,] matrix = fileReader.ReadMatrixFromFile("board.txt");

            // Mostrar la matriz en consola
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
