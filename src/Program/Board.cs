using System;
using System.Threading;

public class Board
{
    public int Largo { get; set; }
    public int Ancho { get; set; }
    public bool[,] Tablero { get; set; }

    public Board(int largo, int ancho)
    {
        this.Largo = largo;
        this.Ancho = ancho;
        this.Tablero = new bool[largo, ancho];
    }

    public void SetTablero(bool[,] table)
    {
        this.Tablero = table;
    }

    public bool[,] GetTablero()
    {
        return this.Tablero;
    }

    public void Start()
    {
        Logic logic = new Logic(this);
        BoardPrinter printer = new BoardPrinter();

        while (true)
        {
            printer.PrintBoard(this);
            logic.UpdateBoard();
            Thread.Sleep(300);
            Console.Clear();
        }
    }
}