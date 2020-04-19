using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        private string[] arrRanks = new string[] { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        private string[] arrSuits = new string[] { "S", "D", "H", "C" };

        private string m_strRank;
        private string m_strSuit;

        public string Rank
        {
            get { return m_strRank; }
        }

        public string Suit
        {
            get { return m_strSuit; }
        }

        public Card(string p_strRank, string p_strSuit)
        {
            m_strRank = p_strRank;
            m_strSuit = p_strSuit;
        }

    }
}
