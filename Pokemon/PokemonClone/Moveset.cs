using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Moveset
    {
        public Move[] m_moves = new Move[4];
        public int[] m_PPs = new int[4];
        public int m_numMoves = 0;

        public Moveset(Move[] a_moves)
        {
            if (a_moves.Length <= 4)
            {
                for (int i = 0; i < a_moves.Length; i++)
                {
                    m_moves[i] = a_moves[i];
                    m_PPs[i] = a_moves[i].PP;
                    m_numMoves++;
                }
            }
            else
                throw new ArgumentException("ERROR: array must contain FOUR or less moves", nameof(a_moves));
        }

        public Moveset(Move? a_move1, Move? a_move2, Move? a_move3, Move? a_move4)
        {
            if (a_move1 != null)
            {
                m_moves[m_numMoves] = a_move1;
                m_PPs[m_numMoves] = a_move1.PP;
                m_numMoves++;
            }

            if (a_move2 != null)
            {
                m_moves[m_numMoves] = a_move2;
                m_PPs[m_numMoves] = a_move2.PP;
                m_numMoves++;
            }

            if (a_move3 != null)
            {
                m_moves[m_numMoves] = a_move3;
                m_PPs[m_numMoves] = a_move3.PP;
                m_numMoves++;
            }

            if (a_move4 != null)
            {
                m_moves[m_numMoves] = a_move4;
                m_PPs[m_numMoves] = a_move4.PP;
                m_numMoves++;
            }
        }

        /// <param name="a_move">move to be learned</param>
        /// <returns>Returns false if a new move cannot be learned</returns>
        public bool LearnNewMove(Move a_move)
        {// TODO
            if (m_numMoves == 4)
            {
                return false;
            }

            return true;
        }

        public bool CanUseMove(int a_moveIndex)
        {// TODO
            if (m_PPs[a_moveIndex] > 0)
                return true;

            return false;
        }
    }
}
