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

            try
            {

                foreach (string strCard in p_strHand.Split(arrSeparatedString, StringSplitOptions.RemoveEmptyEntries))
                {
                    arrCards[i] = new Card(strCard.Substring(0, strCard.Length - 1), strCard.Substring(strCard.Length - 1, 1));
                    i++;
                }
                return arrCards;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                throw;
            }
        }

        public Boolean IsThreeOfKind(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        public Boolean IsTwoPair(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        public Boolean IsOnePair(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        public string EvaluateHand( Card[] h)
        {
            if (IsFlush(h))
                return "Flush";
            else
                return "";
        }
    }
}
