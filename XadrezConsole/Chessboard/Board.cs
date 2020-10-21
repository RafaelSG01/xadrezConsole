﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.Chessboard
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }

        public void putPiece(Piece p, Position pos)
        {
            pieces[pos.line, pos.col] = p;
            p.position = pos;
        }
    }
}
