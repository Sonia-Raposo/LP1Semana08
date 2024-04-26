using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Player
    {
        public string Name { get; }

        public int Score { get; set; }

        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            if (other == null) return 1;

            if(Score > other.Score) return 1;

            if(Score < other.Score) return -1;

            else
            {
                return 0;
            }
        }

    }
}