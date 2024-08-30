using System;
//No estoy segura si es necesario otro "using"

public class BoardPrinter{
    private Board board;

    public BoardPrinter(Board board)
    {
        this.board = board;
    }

    public void Printer()
    {
        int width = board.Ancho;
        int height = board.Largo;
        bool[,] b = board.Tablero;

        while (true)
        {
            Console.Clear();
            StringBuilder boardRepresentation = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
                    {
                        boardRepresentation.Append("|X|");
                    }
                    else
                    {
                        boardRepresentation.Append("___");
                    }
                }
                boardRepresentation.Append("\n");
            }
            Console.WriteLine(boardRepresentation.ToString());
        }
    }
}