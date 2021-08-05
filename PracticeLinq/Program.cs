using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> videoGames = new List<string>();
            
            //storeing list of Games
                videoGames.Add("Candy Crush.");
                videoGames.Add("Mario Brothers.");
                videoGames.Add("Sonic.");
                videoGames.Add("Dinner Dash.");

           //======================================
            //Order List im asending order by length.
          //=======================================

            var orderList = videoGames.OrderBy(x => x.Count());

            //iterataring through list and loging order list to the console.

            foreach (var item in orderList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
