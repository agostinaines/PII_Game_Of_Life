using System;

public class BoardPrinter
{
    public void PrintBoard(Board board)
    {
        int largo = board.Largo;
        int ancho = board.Ancho;
        bool[,] tablero = board.GetTablero();

        for (int i = 0; i < largo; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write(tablero[i, j] ? "O " : "_ ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', ancho * 2));
    }
}