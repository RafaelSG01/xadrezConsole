using System;
using XadrezConsole.Chessboard;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.PrintScreen(board);

            Console.ReadLine();
        }
    }
}
