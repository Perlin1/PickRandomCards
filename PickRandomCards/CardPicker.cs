using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i =0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RamdomSuit();
            }
            return pickedCards;
        }

        private static string RamdomSuit()
        {
            int value = random.Next(1, 5);
            //if value = 1 return string to spades
            if (value == 1) return "spades ♠️";
            //if value = 2 return string to hearts
            if (value == 2) return "hearts ♥";
            //if value = 3 return string to clubs
            if (value == 3) return "clubs ♣";
            //if haven't return yet, return the string diamonds
            return "diamonds♦";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "ace 🂡";
            if (value == 11) return "jack 🂫";
            if (value == 12) return "Queen 🂭";
            if (value == 13) return "king 🂮";
            return value.ToString();
        }
    }
}
