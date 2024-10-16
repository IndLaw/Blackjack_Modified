## Blackjack Modified

An attempt to add 5 npc players with different behaviors to this blackjack project. Learning experience for C#. May attempt to add features listed at the bottom.


# Blackjack (C# .NET Core Console App)
Inspired by: https://codereview.stackexchange.com/questions/214390/my-blackjack-game-in-c-console  
Thanks Steve!

## Features
+ Multi-player (local machine, not networked)
+ Multi-deck shoe
+ Player can double
+ Player can split 
+ Player can double after split
+ Test mode (stack the shoe to test different scenarios)
+ Dealer burns first card of shoe

## To Play
1. Run the program.
2. Enter your name and a bankroll.
3. Enter any additional players and their bankroll.
4. Enter your bet (whole dollar amounts only, within the table limits).
5. Play your hand. 
    * Answer dealer prompts with the first letter of the word (e.g. h for hit, s for stand).
	* If you have less than your original bet, you will automatically double or split "for less".
	* If you have already bet all your chips on active hands, you can't double or split.
	* Provided you have the funds, you can split multiple times, up to the table limit of split hands.
6. Play continues until you run out of chips or you bet $0 to stand up from the table.

## Misc  
+ Table rules are set as static properties on the Table class.
+ Dealer speed can be controled via the Dealer class's delay field.
+ Object-oriented design - Objects only change other objects via methods (i.e. no public setters).

## Features that would be nice to add
+ Insurance
+ Surrender
+ Deal only a single card after splitting aces
