﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Bishop : Piece
    {
        Bishop(Player p):base(p)
        {

        }

        public override List<Move> getPossibleMoves()
        {
            throw new NotImplementedException();
        }
    }
}
