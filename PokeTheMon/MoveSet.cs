using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheMon
{
    class MoveSet
    {
        Move move1, move2, move3, move4;
        public MoveSet(Move move1, Move move2, Move move3, Move move4)
        {
            this.move1 = move1;
            this.move2 = move2;
            this.move3 = move3;
            this.move4 = move4;
        }

        public Move Move1 { get { return move1; } }
        public Move Move2 { get { return move2; } }
        public Move Move3 { get { return move3; } }
        public Move Move4 { get { return move4; } }

        public void toString()
        {
            move1.toString();
            move2.toString();
            move3.toString();
            move4.toString();
        }
    }
}
