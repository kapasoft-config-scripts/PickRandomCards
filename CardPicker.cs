﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random= new Random();
        public static string[] PickSomeCards(int numberOfCards) {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++){
                pickedCards[i] = RandomValue() + " of " +
                    RandomSuite();
            }

            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1,14);

            if (value == 1) return "ACE";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
           return value.ToString();
        }

        private static string RandomSuite()
        {
            int choice = random.Next(1,5);
            if(choice == 1) return "Spades";
            if (choice == 2) return "Hearts";
            if (choice == 3) return "Clubs";
            return "Dimonds";
        }
    }
}
