using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingGame
{
    class BlowingGame
    {
        public int add()
        {
            throw new NotImplementedException();
        }

        public List<Round> parseToRound(string input)
        {
            var stringArray = input.Split(',');
            List<Round> rounds = new List<Round>();
            for (int i = 0; i < stringArray.Length; i+=2)
            {
                var round = new Round();
                round.first = int.Parse(stringArray[i]);
                round.second = int.Parse(stringArray[i+1]);
                rounds.Add(round);
            }         
            return rounds;
        }


        public bool isStrike(Round round)
        {
            if (round.first == 10)
                return true;
            return false;
        }

   
    }

    class Round
    {
        public int first;
        public int second;
    }
}
