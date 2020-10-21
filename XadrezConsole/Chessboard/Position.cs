using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.Chessboard
{
    class Position
    {
        public int line { get; set; }
        public int col { get; set; }

        public Position(int line, int col)
        {
            this.line = line;
            this.col = col;
        }

        public override string ToString()
        {
            return line + ", " + col;
        }
    }
}
