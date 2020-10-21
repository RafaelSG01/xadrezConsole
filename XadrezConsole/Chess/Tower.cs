using System;
using System.Collections.Generic;
using System.Text;
using XadrezConsole.Chessboard;

namespace XadrezConsole.Chess
{
    class Tower : Piece
    {
        public Tower(Color color, Board board) : base(color, board)
        {

        }
        public override string ToString()
        {
            return " T ";
        }
    }
}
