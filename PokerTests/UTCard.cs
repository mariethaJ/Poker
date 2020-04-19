using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class UTCard
    {
        [TestMethod]
        public void GetIndexOfRank_Valid()
        {
            Card c = new Card("A", "D");
            int nIndex = c.GetIndexOfRank(c.Rank);

            Assert.AreEqual(nIndex, 0, $"The index is 0");
        }

        [TestMethod]
        public void GetIndexOfRank_InValid()
        {
            Card c = new Card("R", "D");
            int nIndex = c.GetIndexOfRank(c.Rank);

            Assert.AreEqual(nIndex, -1, $"The index is -1");
        }

        [TestMethod]
        public void IsValidRank_True()
        {
            Card c = new Card("A", "D");
            bool bValid = c.IsValidRank(c.Rank);

            Assert.AreEqual(bValid, true, $"The rank is valid");
        }

        [TestMethod]
        public void IsValidRank_False()
        {
            Card c = new Card("R", "D");
            bool bValid = c.IsValidRank(c.Rank);

            Assert.AreEqual(bValid, false, $"The rank is invalid");
        }

        [TestMethod]
        public void IsValidSuit_True()
        {
            Card c = new Card("A", "D");
            bool bValid = c.IsValidSuit(c.Suit);

            Assert.AreEqual(bValid, true, $"The SUIT is valid");
        }

        [TestMethod]
        public void IsValidSuit_False()
        {
            Card c = new Card("R", "P");
            bool bValid = c.IsValidSuit(c.Suit);

            Assert.AreEqual(bValid, false, $"The SUIT is invalid");
        }

    }
}
