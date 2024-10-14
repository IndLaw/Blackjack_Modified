using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class NPCOpponents
    {
        List<Player> npcPlayers = new List<Player>(5);
        Player depressed = new Player("Depressed", 350);
        Player weary = new Player("Weary", 50);
        Player cruel = new Player("Cruel", 450);
        Player conceited = new Player("Conceited", 1350);
        Player determined = new Player("Determined", 250);
        Player loving = new Player("Loving", 150);
        Player dishonest = new Player("Dishonest",500);
        Player proud = new Player("Proud", 600);
        Player rational = new Player("Rational", 100);
        

        public List<Player> loadNPCs()
        {
            selectOpponents();
            return npcPlayers;
        }

        public void gatherFunds() // randomly generate the amount of money each character will bring to the table; unique to each
        {

        }

        public void initNPCs() // use gatherFunds() and initalize the npc
        {

        }

        public void selectOpponents() // 
        {
            Random rand = new Random();
            

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
