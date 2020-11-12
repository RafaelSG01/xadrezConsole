using System;
using XadrezConsole.Chessboard;
using XadrezConsole.Chess;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.putPiece(new Tower(Color.Preta, board), new Position(0, 0));
                board.putPiece(new Tower(Color.Preta, board), new Position(1, 3));
                board.putPiece(new King(Color.Preta, board), new Position(2, 4));

                Screen.PrintScreen(board);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
