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
                int aliveNeighbors = CountAliveNeighbors(i, j);

                if (_board.Tablero[i, j]) // Célula viva
                {
                    nextGeneration[i, j] = aliveNeighbors == 2 || aliveNeighbors == 3;
                }
                else // Célula muerta
                {
                    nextGeneration[i, j] = aliveNeighbors == 3;
                }
            }
        }

        _board.SetMatrix(nextGeneration);
    }

    private int CountAliveNeighbors(int row, int col)
    {
        int aliveNeighbors = 0;
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
                        aliveNeighbors++;
                    }
                }
            }
        }

        return aliveNeighbors;
    }
}