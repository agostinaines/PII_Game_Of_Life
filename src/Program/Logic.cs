using System;

namespace Ucu.Poo.GameOfLife;

public class Logic
{
    public Board Tablero { get; set; }

    public Logic(Board tablero)
    {
        this.Tablero = tablero;
    }

    public void Generation()
    {
        bool[,] tableroActual = Board.Tablero;
        int boardAncho = tableroActual.GetLength(0);
        int boardLargo = tableroActual.GetLength(1);

        bool[,] tableroNuevo = new bool[boardAncho, boardLargo];

        for (int x = 0; x < boardAncho; x++)
        {
            for (int y = 0; y < boardLargo; y++)
            {
                int vecinosVivos = 0;

                for (int i = x - 1; i <= x; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardAncho && j >= 0 && j < boardLargo && tableroActual[i, j]);
                        vecinosVivos++;
                    }
                }

                if (tableroActual[x, y])
                {
                    vecinosVivos--;
                }

                if ((tableroActual[x, y] && vecinosVivos < 2) || (tableroActual[x, y] && vecinosVivos > 3))
                {
                    tableroNuevo[x, y] = false; // célula muere por soledad o muere por sobrepoblación
                }
                else if (!tableroActual[x, y] && vecinosVivos == 3)
                {
                    tableroNuevo[x, y] = true; // célula revive
                }
                else
                {
                    tableroNuevo[x, y] = true; // se mantiene el valor
                }

                tableroActual = tableroNuevo;
            }
        }
    }
}