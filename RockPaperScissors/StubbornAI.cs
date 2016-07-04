using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer


    {
        int Favoritemove2;
        public StubbornAI(int favoritemove)
        {
            Favoritemove2 = favoritemove;
        }

        public int NextMove()
        {
            return Favoritemove2;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            
        }
    }
}
