using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class UTHand
    {
        [TestMethod]
        public void GetCards()
        {
            string strHand = "AS, 10C, 10H, 3D, 3S";
            Card card1 = new Card("A", "S");
            Card card2 = new Card("10", "C");
            Card card3 = new Card("10", "H");
            Card card4 = new Card("3", "D");
            Card card5 = new Card("3", "S");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };

            Hand hand = new Hand();

            Card[] arrCardActual = hand.GetCards(strHand);

            for (int i=0; i< 5; i++)
            {
                Assert.AreEqual(arrCard[i].Rank, arrCardActual[i].Rank, $"The {i} card RANK is correct");
                Assert.AreEqual(arrCard[i].Suit, arrCardActual[i].Suit, $"The {i} card SUIT is correct");
            }
           
        }


    }
}
