﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
        int id;

        public Player(int num)
        {
            id = num;
        }

        public int GetID()
        {
            return id;
        }

    }
}
