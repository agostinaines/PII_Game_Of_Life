using System;
using System.IO;

public class FileReader
{
    public Board LeerTablero(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        int largo = lines.Length;
        int ancho = lines[0].Length;

        Board board = new Board(largo, ancho);

        bool[,] table = new bool[largo, ancho];

        for (int i = 0; i < largo; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                table[i, j] = lines[i][j] == '1';
            }
        }

        board.SetTablero(table);

        return board;
    }
}