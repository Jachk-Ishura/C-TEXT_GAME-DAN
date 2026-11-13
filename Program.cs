using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TEXT_GAME_DAN
{
    internal class Program
    {
        static void Wasteland(string[] args)
        {
            Console.WriteLine("Goto the Lake, Bunker or Hut?");
            string userDest = Console.ReadLine();

            if (userDest == "Lake")
                Map.Lake();
            else if (userDest == "Bunker")
                Map.Bunker();

            Map.Hut(); 
        }
    }
}