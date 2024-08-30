public class Logic
{
    private Board _board;

    public Logic(Board board)
    {
        _board = board;
    }

    public void UpdateBoard()
    {
        int largo = _board.Largo;
        int ancho = _board.Ancho;
        bool[,] nextGeneration = new bool[largo, ancho];

        for (int i = 0; i < largo; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                int vecinosVivos = ContarVecinos(i, j);

                if (_board.Tablero[i, j])
                {
                    nextGeneration[i, j] = vecinosVivos == 2 || vecinosVivos == 3;
                }
                else
                {
                    nextGeneration[i, j] = vecinosVivos == 3;
                }
            }
        }

        _board.SetTablero(nextGeneration);
    }

    private int ContarVecinos(int row, int col)
    {
        int vecinosVivos = 0;
        int largo = _board.Largo;
        int ancho = _board.Ancho;

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == 0 && j == 0) continue;

                int newRow = row + i;
                int newCol = col + j;

                if (newRow >= 0 && newRow < largo && newCol >= 0 && newCol < ancho)
                {
                    if (_board.Tablero[newRow, newCol])
                    {
                        vecinosVivos++;
                    }
                }
            }
        }

        return vecinosVivos;
    }
}