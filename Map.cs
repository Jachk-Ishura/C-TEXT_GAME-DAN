using Microsoft.Win32;
using System;

public class Map
{
	static public void Bunker()
	{
		string user = "";

		Console.WriteLine("You spawn in an empty bunker with a famine of supplies on shelves. Some have rotted and some are barely enough for a week.");
		Console.WriteLine("Would like to leave the bunker?");
		user = Console.ReadLine();

		if (user == "Leaves Bunker")
			Console.WriteLine("You find yourself in a desolate forest with nothing but the sound of wind and an unusual humming sound from who knows what.");
		else
			Console.WriteLine("Months have passed and you have used the last of your supplies and have died from starvation.");

	}

	static public void Lake()
	{
		string user = "";

		Console.WriteLine("You wander the forest and find a little girl called Sophie, alone and you allow her to tag along with you and you both keep moving forward and find an extraordinarily huge lake in the middle of the forest");
		Console.WriteLine("Would you like to help Sophie from drowning?");
		user = Console.ReadLine().ToLower();

		if (user == "help")
		{
			Console.WriteLine("You decide to help Sophie and drag her by the foot to save her but it was a mutated shark called a land spitter and u get sprayed with a huge mist of acid and get incinerated leaving Sophie all on her own.");
		}
		else
		{
			Console.WriteLine("You just barely manage to catch her before she actually falls in and you decide to trek the path you guys followed and find a small wooden hut.");
		}
	}

	static public void Hut()
	{
		string key = "";
		Console.WriteLine("You both reach the hut and find a worn mat and you lift it up and find a rustic key");
		Console.WriteLine("Would you like to pick up the key?");
		key = Console.ReadLine();

		if (key == "Picks up key")
			Console.WriteLine("You pick up they key and take Sophie inside. You find nothing other than a lighter and some lighter fuel");
		else
			Console.WriteLine("You decide to keep walking down the path but it's dark and desolate. A man in deep black garments approaches you guys asking if u want to buy some items and u decide to buy a lighter");
	}
}