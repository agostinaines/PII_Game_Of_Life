using System;

class Program
{
    static void Main()
    {
        FileReader fileReader = new FileReader();
        Board board = fileReader.LeerTablero("board.txt");
        board.Start();
    }
}