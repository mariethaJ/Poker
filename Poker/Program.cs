using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the hand in the format [Rank][Suit],[space]. By example AS, 10D, 3H, 4H,5H");
            string strHand = Console.ReadLine();
            bool p_bRankExist=true;
            bool p_bSuitExist=true;
            try
            {
                Hand hand = new Hand();

                string strResult = hand.EvaluateHand(strHand);

                if (!p_bRankExist)
                    Console.WriteLine("Rank doesnt exist, please check your string");

                if (!p_bSuitExist)
                    Console.WriteLine("Suit doesnt exist, please check your string");

                Console.WriteLine(strResult);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

     
    }
}
