using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module5Lab
{
    internal class Player // marked as internal - this means it can be used anywhere in Module5Lab assembly (sweeeeet)
    {
        private string name;
        private int score;
        private int livesLeft;
        public Player()
        {
            
        }
        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public int GetScore()
        {
            return score;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void Kill()
        {
            // basically logic check
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }

            public int GetLivesLeft()
            {
                return livesLeft;
            }
    }
}
