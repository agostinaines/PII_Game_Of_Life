using System;
using System.IO;

public class FileReader
{
    public int[,] ReadMatrixFromFile(string filePath)
    {
        // Leer todas las líneas del archivo
        string[] lines = File.ReadAllLines(filePath);

        // Determinar el tamaño de la matriz
        int rows = lines.Length;
        int cols = lines[0].Length;

        // Crear la matriz
        int[,] matrix = new int[rows, cols];

        // Llenar la matriz con los valores del archivo
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Convertir el carácter en entero (1 o 0)
                matrix[i, j] = lines[i][j] - '0';
            }
        }

        return matrix;
    }
}