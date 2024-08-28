public class Board
{
    public int Largo { get; set; }
    
    public int Ancho { get; set; }
    
    public bool[,] Tablero { get; set; }

    public Board(bool[,] tablero)
    {
        this.Largo = tablero.GetLength(1);
        this.Ancho = tablero.GetLength(0);
        this.Tablero = tablero;
    }
}