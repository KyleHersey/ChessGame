﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Rook : Piece
    {
        private Player p1;

        public Rook(Player p):base(p)
        {
          
        }

        public override List<Point> getPossibleEndSpaces(Board b)
        {
            List<Point> endSpaces = new List<Point>();

            bool hitSomething = false;
            Point currentPosition = new Point(position.X, position.Y);

            //up
            while(b.pointExists(new Point(position.X - 1, position.Y)) && hitSomething == false){
                currentPosition.X -= 1;
                if (b.GetPieceAt(currentPosition).player.GetID() == 0)
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                }
                else if (b.GetPieceAt(currentPosition).player.GetID() != player.GetID())
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                    hitSomething = true;
                }
                else
                {
                    hitSomething = true;
                }
            }

            //right
            while (b.pointExists(new Point(position.X, position.Y + 1)) && hitSomething == false)
            {
                currentPosition.Y += 1;
                if (b.GetPieceAt(currentPosition).player.GetID() == 0)
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                }
                else if (b.GetPieceAt(currentPosition).player.GetID() != player.GetID())
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                    hitSomething = true;
                }
                else
                {
                    hitSomething = true;
                }
            }

            //down
            while (b.pointExists(new Point(position.X + 1, position.Y)) && hitSomething == false)
            {
                currentPosition.X += 1;
                if (b.GetPieceAt(currentPosition).player.GetID() == 0)
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                }
                else if (b.GetPieceAt(currentPosition).player.GetID() != player.GetID())
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                    hitSomething = true;
                }
                else
                {
                    hitSomething = true;
                }
            }

            //left
            while (b.pointExists(new Point(position.X, position.Y - 1)) && hitSomething == false)
            {
                currentPosition.Y -= 1;
                if (b.GetPieceAt(currentPosition).player.GetID() == 0)
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                }
                else if (b.GetPieceAt(currentPosition).player.GetID() != player.GetID())
                {
                    endSpaces.Add(new Point(currentPosition.X, currentPosition.Y));
                    hitSomething = true;
                }
                else
                {
                    hitSomething = true;
                }
            }

            return endSpaces;
        }

        public override string ToString(){
            return "R" + player.GetID();
        }
    }
}
