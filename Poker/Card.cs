﻿using System;
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

        public string[] Ranks
        {
            get { return arrRanks; } 
        }

        public string[] Suits
        {
            get { return arrSuits; }
        }

        public Card(string p_strRank, string p_strSuit)
        {
            m_strRank = p_strRank;
            m_strSuit = p_strSuit;
        }

        public int GetIndexOfRank(string p_strRank)
        {
            int ind = Array.IndexOf(arrRanks, p_strRank);
            return ind;
        }

        public bool IsValidRank (string p_strRank)
        {
            int ind = GetIndexOfRank(p_strRank);
            if (ind >= 0)
                return true;
            else
                return false;

        }

        public bool IsValidSuit(string p_strSuit)
        {
            int ind = Array.IndexOf(arrSuits, p_strSuit);
            if (ind >= 0)
                return true;
            else
                return false;

        }

    }
}
