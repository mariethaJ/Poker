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
            var result = h.OrderBy(x => x.Rank).ToArray();
            return result;
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

        private static Boolean IsStraight(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        private static Boolean IsThreeOfKind(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        private static Boolean IsTwoPair(Card[] h)
        {
            //TODO :add implementation code
            return true;
        }

        private static Boolean IsOnePair(Card[] h)
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
