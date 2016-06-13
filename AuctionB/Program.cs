using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionB
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double bid;
            int intbid;
            Console.WriteLine("Enter your bid");
            string x = Console.ReadLine();

            if(int.TryParse(x,out intbid))
            {
                DisplayMethod(intbid);
            }
            else if(double.TryParse(x,out bid))
            {
                 DisplayMethod(bid);
            }
            else{
                DisplayMethod(x);
            }



        }

        private static void DisplayMethod(int bid)
        {
            if(bid>10)
            {
                Console.WriteLine("Your bid is {0}",bid.ToString("C"));
            }
            else
            {
                Console.WriteLine("Your bid is less than $10");
            }

        }
        private static void DisplayMethod(double bid)
        {
            if (bid > 10)
            {
                Console.WriteLine("Your bid is {0}", bid.ToString("C"));
            }
            else
            {
                Console.WriteLine("Your bid is less than $10");
            }


        }
        private static void DisplayMethod(string bid)
        {
            if(bid.Substring(0,1)=="$")
            {
                double checkbid;
                double.TryParse(bid.Substring(1), out checkbid);
                if(checkbid>=10.00)
                {
                    Console.WriteLine("Your bid is {0}", checkbid);
                    Console.WriteLine("bid include $ sign");
                }
                else
                {
                    Console.WriteLine("bid should be more than or equal to $10");
                }
               
            }
            else if (bid.Substring(bid.Length - 7, 7) == "dollars")
            {
                double checkbid;
                int index = bid.IndexOf("dollars");

                double.TryParse(bid.Substring(0, index), out checkbid);
                Console.WriteLine("Your bid is {0} dollars", checkbid);
                if (checkbid >= 10)
                {
                    Console.WriteLine(checkbid);
                    Console.WriteLine("bid include dollars");
                }
                else
                {
                    Console.WriteLine("bid should be more than or equal to $10");

                }
            }
            else
            {
                Console.WriteLine("The format was incorrect!");
            }
        }

    }
}
