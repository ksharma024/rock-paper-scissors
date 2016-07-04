using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        int Othermove2;

        public int NextMove()
        {
            if (Othermove2 == 0)
            {
                return (1);
            }
            else if (Othermove2 == 1)
            {
                return (2);
            }
            else if (Othermove2 == 2)
            {
                return (0);
            }
            else
            {
                return (-1);
            }

               

        } 

        public void SaveResult(int myMove, int otherMove)
        {
            Othermove2 = otherMove;
        }
    }
}
