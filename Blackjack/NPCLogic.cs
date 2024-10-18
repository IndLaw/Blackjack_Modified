using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class NPCLogic
    {
        private Random rand = new Random();
        public int BettingLogic(Player NPC, int maxBet)
        {
            String name = NPC.Name;
            decimal initialChipCount = NPC.initialChipCount; 
            decimal chips = NPC.Chips;

            int bet;

            if (chips == 0) // not enough to bet
            {
                return 0;
            }

            if (name.Equals("Depressed"))
            {
                if (chips < (initialChipCount * (decimal)0.3)) // quits at < 30% of inital bankroll
                {
                    return 0;
                }
                bet = BetGen(1, 16, chips); // bets 1-15% of current chips
                return bet;
            }
            else if (name.Equals("Cruel"))
            {

                bet = BetGen(10, 36, chips); // bets 10-35% of current chips

                if (bet > chips) // if bet is more than current chips, bet all remaining chips
                {
                    return (int)chips;
                }
                return bet;
            }
            else if (name.Equals("Weary"))
            {
                if (chips < (initialChipCount * (decimal)0.5)) // quits at < 50% of inital bankroll
                {
                    return 0;
                }

                bet = BetGen(1, 6, chips); // bets 1-5% of current chips
                return bet;
            }
            else if (name.Equals("Conceited"))
            {
                bet = BetGen(30, 50, chips); // bets 30-50% of current chips

                if (bet > chips) // if bet is more than current chips, bet all remaining chips
                {
                    return (int)chips;
                }
                if (bet > maxBet) // if bet is more than maximum allowed bet, bet max
                {
                    return maxBet;
                }
                return bet;
            }
            else if (name.Equals("Determined"))
            {
                bet = BetGen(20, 35, chips); // bets 20-35% of current chips

                if (bet > chips) // if bet is more than current chips, bet all remaining chips
                {
                    return (int)chips;
                }
                return bet;
            }
            else if (name.Equals("Loving"))
            {
                if (chips < (initialChipCount * (decimal)0.4)) // quits at < 40% of inital bankroll
                {
                    return 0;
                }

                bet = BetGen(1, 10, chips); // bets 1-10% of current chips
                return bet;
            }
            else if (name.Equals("Dishonest"))
            {
                bet = BetGen(15, 35, chips); // bets 15-35% of current chips

                if (bet > chips) // if bet is more than current chips, bet all remaining chips
                {
                    return (int)chips;
                }
                return bet;
            }
            else if (name.Equals("Proud"))
            {
                bet = BetGen(20, 40, chips); // bets 20-40% of current chips

                if (bet > chips) // if bet is more than current chips, bet all remaining chips
                {
                    return (int)chips;
                }
                if (bet > maxBet) // if bet is more than maximum allowed bet, bet max
                {
                    return maxBet;
                }
                return bet;
            }
            else if (name.Equals("Rational"))
            {
                if (chips < (initialChipCount * (decimal)0.75)) // quits at < 75% of inital bankroll
                {
                    return 0;
                }

                bet = BetGen(15, 30, chips); // bets 15-30% of current chips
                return bet;
            }
            return 0;
        }

        private int BetGen(int min, int max, decimal chips)
        {
            int bettingPercentage = rand.Next(min, max);

            return (int)(chips * (decimal)(bettingPercentage / 100.0));
        }
    }
}
