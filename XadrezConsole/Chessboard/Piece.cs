﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.Chessboard
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int quantityMovements { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Color color, Board board)
        {
            this.position = null;
            this.color = color;
            this.board = board;
            this.quantityMovements = 0;
        }
    }
}
