using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class NPCOpponents
    {
        // init npc objs and list
        List<Player> npcPlayers = new List<Player>(5);
        Player depressed = new Player("Depressed");
        Player weary = new Player("Weary");
        Player cruel = new Player("Cruel");
        Player conceited = new Player("Conceited");
        Player determined = new Player("Determined");
        Player loving = new Player("Loving");
        Player dishonest = new Player("Dishonest");
        Player proud = new Player("Proud");
        Player rational = new Player("Rational");
        Random rand = new Random();

        public List<Player> loadNPCs()
        {
            gatherFunds();
            selectOpponents();
            return npcPlayers;
        }

        private void gatherFunds() // randomly generate the amount of money each character will bring to the table; unique to each
        {
            // rand * 50
            depressed.setBankroll((rand.Next(7, 15) * 50)); // medium sized bankroll
            cruel.setBankroll((rand.Next(7, 15) * 50)); // medium sized bankroll
            weary.setBankroll((rand.Next(1, 8) * 50)); // low sized bankroll
            conceited.setBankroll((rand.Next(14, 21) * 50)); // high sized bankroll
            determined.setBankroll((rand.Next(7, 15) * 50)); // medium sized bankroll
            loving.setBankroll((rand.Next(1, 8) * 50)); // low sized bankroll
            dishonest.setBankroll((rand.Next(7, 15) * 50)); // medium sized bankroll
            proud.setBankroll((rand.Next(14, 21) * 50)); // high sized bankroll
            rational.setBankroll((rand.Next(1, 8) * 50)); // low sized bankroll
        }

        public void initNPCs() // unot sure if needed yet, may delete
        {

        }

        private void selectOpponents() // Selects players based on probability
        {
            
            while (npcPlayers.Count < 5) // no dupes
            {
                int number = rand.Next(1, 101);
                if (number >= 1 && number <= 18 && npcPlayers.Count < 4 && !npcPlayers.Contains(depressed)) // make sure table has room for both
                {
                    npcPlayers.Add(depressed);
                    npcPlayers.Add(cruel);
                }
                else if (number >= 19 && number <= 23 && !npcPlayers.Contains(weary))
                {
                    npcPlayers.Add(weary);
                }
                else if (number >= 14 && number <= 28 && !npcPlayers.Contains(conceited))
                {
                    npcPlayers.Add(conceited);
                }
                else if (number >= 29 && number <= 45 && !npcPlayers.Contains(determined))
                {
                    npcPlayers.Add(determined);
                }
                else if (number >= 46 && number <= 59 && !npcPlayers.Contains(loving))
                {
                    npcPlayers.Add(loving);
                }
                else if (number >= 60 && number <= 75 && !npcPlayers.Contains(dishonest))
                {
                    npcPlayers.Add(dishonest);
                }
                else if (number >= 76 && number <= 91 && !npcPlayers.Contains(proud))
                {
                    npcPlayers.Add(proud);
                }
                else if (number >= 92 && number <= 100 && !npcPlayers.Contains(rational))
                {
                    npcPlayers.Add(rational);
                }

            }




        }





    }
}
