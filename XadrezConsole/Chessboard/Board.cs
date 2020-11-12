using System;
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

        public Piece piece (Position pos)
        {
            return pieces[pos.line, pos.col];
        }

        public bool ExistsPiece(Position pos)
        {
            ValidatePosition(pos);
            return piece(pos) != null;
        }

        public void putPiece(Piece p, Position pos)
        {
            if (ExistsPiece(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição!");
            }
            pieces[pos.line, pos.col] = p;
            p.position = pos;
        }

        public bool ValidPosition(Position pos)
        {
            if(pos.line < 0 || pos.line >= lines || pos.col < 0 || pos.col >= columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Posição inválida!");
            }
        }
    }
}
