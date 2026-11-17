using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game

{

    internal class Program
    {

        static void Main(string[] args)

     using System;

Console.WriteLine("=================================");
Console.WriteLine("     THE KINGDOM ASSIGNMENT");
Console.WriteLine("=================================");
Console.WriteLine();

Console.Write("What is your name? ");
string name = Console.ReadLine();

    Random random = new Random();

    // Kingdoms
    string[] kingdoms =
    {
    "The Kingdom of Beef",
    "The Moist Empire",
    "The Waffle Kingdom",
    "The Kingdom of Bonk",
    "The Stinkpants Realm",
    "The Great Ball Castle"
};

    // Random titles
    string[] titles =
    {
    "Sir",
    "Lord",
    "Baron",
    "Knight",
    "Duke",
    "Champion"
};

    // Pick a random kingdom
    string kingdom = kingdoms[random.Next(kingdoms.Length)];

    // Pick a random title
    string title = titles[random.Next(titles.Length)];

    Console.WriteLine();
Console.WriteLine("The royal council has made its decision...");
Console.WriteLine();

Console.WriteLine($"Welcome, {title} {name}!");
Console.WriteLine($"You have been assigned to:");
Console.WriteLine();
Console.WriteLine($"*** {kingdom} ***");
Console.WriteLine();

if (kingdom == "The Kingdom of Beef")
{
    Console.WriteLine("Your people are strong, proud, and suspiciously obsessed with steak.");
}
else if (kingdom == "The Moist Empire")
{
    Console.WriteLine("Your empire is mysterious, damp, and slightly uncomfortable.");
}
else if (kingdom == "The Waffle Kingdom")
{
    Console.WriteLine("Your kingdom is powered by waffles and questionable amounts of syrup.");
}
else if (kingdom == "The Kingdom of Bonk")
{
    Console.WriteLine("Your warriors are fearless. Their main weapon is BONK.");
}
else if (kingdom == "The Stinkpants Realm")
{
    Console.WriteLine("A powerful kingdom... although nobody knows where that smell is coming from.");
}
else
{
    Console.WriteLine("The Great Ball Castle welcomes you. Nobody knows why it is called that.");
}

Console.WriteLine();
Console.WriteLine("Your adventure begins now!");
Console.WriteLine();
Console.WriteLine("Press ENTER to exit...");
Console.ReadLine();


{




}

    }

    }










