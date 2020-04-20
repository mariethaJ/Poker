using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand
    {
        //private static Card[] m_cHand = new Card[5];


        public Hand()
        {

        }

        public  Card[] GetCards (string p_strHand)
        {
            Card[] arrCards = new Card[5];
            int i = 0;
            string[] arrSeparatedString = new string[] { ", " };
            string strRank;
            string strSuit;
            try
            {
                Card c1 = new Card(null, null);

                foreach (string strCard in p_strHand.Split(arrSeparatedString, StringSplitOptions.RemoveEmptyEntries))
                {
                    strRank = strCard.Substring(0, strCard.Length - 1);
                    strSuit = strCard.Substring(strCard.Length - 1, 1);
                    if ((c1.IsValidRank(strRank)) && (c1.IsValidSuit(strSuit)))
                        arrCards[i] = new Card(strRank, strSuit);
                    else
                    {
                        if (!(c1.IsValidRank(strRank)))
                        {                           
                            return null;
                        }
                        if (!(c1.IsValidSuit(strSuit)))
                        {                          
                            return null;
                        }
                    }
                    i++;
                   
                }
                return arrCards;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch 
            {
                throw;
            }
        }
        public Card[] SortBySuit(Card[] h)
        {
            var result = h.OrderBy(x => x.Suit).ToArray();
            return result;
        }

        public Card[] SortByRank(Card[] h)
        {
            //var result = h.OrderBy(x => x.Rank).ToArray();
            //return result;
            Card[] arrCIndex = new Card[5];
            int[] arrIndexes = new int[5];
            Card c1 = new Card(null,null);
            string[] arrRanks = c1.Ranks;
            int i = 0;

            try
            {
                foreach (Card c in h)
                {                    
                    arrCIndex[i] = new Card(c1.GetIndexOfRank(c.Rank).ToString(), c.Suit);
                    i++;
                }

                i = 0;
                var vIndexCard = arrCIndex.OrderBy(x => Convert.ToInt32(x.Rank)).ToArray();
                Card[] resultCardSet = new Card[5];

                foreach (Card c in vIndexCard)
                {
                    resultCardSet[i] = new Card(arrRanks[Convert.ToInt32(c.Rank)], c.Suit);
                    i++;
                }
                return resultCardSet;
            }
            catch 
            {
                throw;
            }
        }

        public Boolean IsFlush(Card[] h)
        {                     
            var qry = from h1 in h
                      group h1 by h1.Suit into grp
                      where grp.Count() == 5
                      select grp;

            if (qry.Count() == 1)
                return true;
            else
                return false;
        }

        public Boolean IsStraight(Card[] h)
        {
            
            Card[] arrCards = new Card[5];
            int counter = 0;

            try
            {
                arrCards = SortByRank(h);

                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                        counter++;
                    else if (arrCards[i].GetIndexOfRank(arrCards[i].Rank) - arrCards[i - 1].GetIndexOfRank(arrCards[i - 1].Rank) == 1)
                        counter++;
                    else
                        return false;
                }
                if (counter == 5)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public Boolean IsThreeOfKind(Card[] h)
        {
            var qry = from h1 in h
                      group h1 by h1.Rank into grp
                      where grp.Count() == 3
                      select grp;

            if (qry.Count() > 0)
                return true;
            else
                return false;
        }

        public Boolean IsTwoPair(Card[] h)
        {
            var qry = from h1 in h
                      group h1 by h1.Rank into grp
                      where grp.Count() == 2
                      select grp;

            if (qry.Count() == 2)
                return true;
            else
                return false;
        }

        public Boolean IsOnePair(Card[] h)
        {
            var qry = from h1 in h
                      group h1 by h1.Rank into grp
                      where grp.Count() == 2
                      select grp;

            if (qry.Count() == 1)
                return true;
            else
                return false;

            
        }

        public string EvaluateHand(string p_strHand)
        {
            try
            {
                Card[] h = GetCards(p_strHand);

                if (h != null)
                {
                    if (IsFlush(h))
                        return "Flush";
                    else if (IsStraight(h))
                        return "Straight";
                    else if (IsThreeOfKind(h))
                        return "Three of Kind";
                    else if (IsTwoPair(h))
                        return "Two Pair";
                    else if (IsOnePair(h))
                        return "One Pair";
                    else
                        return "Couldn't evaluate hand!!!";
                }
                else
                    return "Invalid Input";
            }
            catch
            {
                throw;
            }

        }
    }
}
