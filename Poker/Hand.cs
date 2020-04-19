using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand
    {
        private Card[] m_cHand = new Card[5];


        public Hand()
        {

        }

        private static Card[] GetCards (string p_strHand)
        {
            //todo add implementation code
            return null;
        }
        private static Card[] SortSBySuit(Card[] h)
        {
            //just for design purpose use h
            return h;
        }

        private static Card[] SortSByRank(Card[] h)
        {
            //just for design purpose use h
            return h;
        }

        private static Boolean IsFlush(Card[] h)
        {
            //TODO :add implementation code
            return true;
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

        public static string EvaluateHand( Card[] h)
        {
            if (IsFlush(h))
                return "Flush";
            else
                return "";
        }
    }
}
