﻿using System;
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

        [TestMethod]
        public void SortBySuit()
        {
            Card card1 = new Card("A", "S");
            Card card2 = new Card("10", "C");
            Card card3 = new Card("10", "H");
            Card card4 = new Card("3", "D");
            Card card5 = new Card("3", "S");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };

            Hand hand = new Hand();
            Card[] arrCardActual = hand.SortBySuit(arrCard);

            Card[] arrCardExpected = new Card[] { card2, card4, card3, card1, card5 };

            for (int i = 0; i < 5; i++)
            {
              //  Assert.AreEqual(arrCardExpected[i].Rank, arrCardActual[i].Rank, $"The {i} card RANK is correct");
                Assert.AreEqual(arrCardExpected[i].Suit, arrCardActual[i].Suit, $"The {i} card SUIT is correct");
            }

        }

        [TestMethod]
        public void SortByRank_Deal1()
        {
            Card card1 = new Card("A", "S");
            Card card2 = new Card("9", "C");
            Card card3 = new Card("K", "H");
            Card card4 = new Card("3", "D");
            Card card5 = new Card("Q", "S");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };

            Hand hand = new Hand();
            Card[] arrCardActual = hand.SortByRank(arrCard);

            Card[] arrCardExpected = new Card[] { card1, card3, card5, card2, card4 };

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(arrCardExpected[i].Rank, arrCardActual[i].Rank, $"The {i} card RANK is correct");
              //  Assert.AreEqual(arrCardExpected[i].Suit, arrCardActual[i].Suit, $"The {i} card SUIT is correct");
            }

        }

        [TestMethod]
        public void SortByRank_Deal2()
        {
            Card card1 = new Card("A", "S");
            Card card2 = new Card("9", "C");
            Card card3 = new Card("K", "H");
            Card card4 = new Card("9", "D");
            Card card5 = new Card("Q", "S");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };

            Hand hand = new Hand();
            Card[] arrCardActual = hand.SortByRank(arrCard);

            Card[] arrCardExpected = new Card[] { card1, card3, card5, card2, card4 };

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(arrCardExpected[i].Rank, arrCardActual[i].Rank, $"The {i} card RANK is correct");
                //  Assert.AreEqual(arrCardExpected[i].Suit, arrCardActual[i].Suit, $"The {i} card SUIT is correct");
            }

        }


        [TestMethod]
        public void IsFlush_True()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("10", "D");
            Card card3 = new Card("9", "D");
            Card card4 = new Card("3", "D");
            Card card5 = new Card("4", "D");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsFlush(arrCard);

            Assert.AreEqual(true, bActual, "The hand is FLUSH");
        }

        [TestMethod]
        public void IsFlush_False()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("10", "D");
            Card card3 = new Card("9", "D");
            Card card4 = new Card("3", "D");
            Card card5 = new Card("4", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsFlush(arrCard);

            Assert.AreEqual(false, bActual, "The hand is NOT FLUSH");
        }

        [TestMethod]
        public void IsStraight_True()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("10", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsStraight(arrCard);

            Assert.AreEqual(true, bActual, "The hand is STRAIGHT");
        }

        [TestMethod]
        public void IsStraight_False()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("5", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsStraight(arrCard);

            Assert.AreEqual(false, bActual, "The hand is NOT STRAIGHT");
        }

        [TestMethod]
        public void IsThreeOfKind_True()
        {
            Card card1 = new Card("Q", "S");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("Q", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsThreeOfKind(arrCard);

            Assert.AreEqual(true, bActual, "The hand is THREE OF KIND");
        }

        [TestMethod]
        public void IsThreeOfKind_False()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("5", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsThreeOfKind(arrCard);

            Assert.AreEqual(false, bActual, "The hand is NOT THREE OF KIND");
        }

        [TestMethod]
        public void IsTwoPair_True()
        {
            Card card1 = new Card("Q", "S");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("J", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsTwoPair(arrCard);

            Assert.AreEqual(true, bActual, "The hand is TWO PAIR");
        }

        [TestMethod]
        public void IsTwoPair_False()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("5", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsTwoPair(arrCard);

            Assert.AreEqual(false, bActual, "The hand is NOT TWO PAIR");
        }

        [TestMethod]
        public void IsOnePair_True()
        {
            Card card1 = new Card("Q", "S");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("10", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsOnePair(arrCard);

            Assert.AreEqual(true, bActual, "The hand is ONE PAIR");
        }

        [TestMethod]
        public void IsOnePair_False()
        {
            Card card1 = new Card("A", "D");
            Card card2 = new Card("Q", "D");
            Card card3 = new Card("J", "D");
            Card card4 = new Card("K", "D");
            Card card5 = new Card("5", "H");

            Card[] arrCard = new Card[] { card1, card2, card3, card4, card5 };
            Hand hand = new Hand();
            Boolean bActual = hand.IsOnePair(arrCard);

            Assert.AreEqual(false, bActual, "The hand is NOT ONE PAIR");
        }

        [TestMethod]
        public void Evaluate_IsFlush()
        {
            string strHand = "AD, 10D, 9D, 3D, 4D";
            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("Flush", strActual, "The hand is FLUSH");
        }

        [TestMethod]
        public void Evaluate_IsStraight()
        {
            string strHand = "AD, QD, JD, KD, 10H";
            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("Straight", strActual, "The hand is STRAIGHT");
        }

        [TestMethod]
        public void Evaluate_IsThreeOfKind()
        {
            string strHand = "QS, QD, JD, KD, QH";

            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("Three of Kind", strActual, "The hand is THREE OF KIND");
        }

        [TestMethod]
        public void Evaluate_IsTwoPair()
        {
            string strHand = "QS, QD, JD, KD, JH";

            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("Two Pair", strActual, "The hand is TWO PAIR");
        }

        [TestMethod]
        public void Evaluate_IsOnePair()
        {
            string strHand = "QS, QD, JD, KD, 10H";
            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("One Pair", strActual, "The hand is ONE PAIR");
        }

        [TestMethod]
        public void Evaluate_Couldnot()
        {

            string strHand = "QS, 8C, 7C, KD, 10H";
            Hand hand = new Hand();
            string strActual = hand.EvaluateHand(strHand);

            Assert.AreEqual("Couldn't evaluate hand!!!", strActual, "Couldnt evaluate hand");
            
        }
    }
}
