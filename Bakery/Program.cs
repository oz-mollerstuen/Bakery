using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("\n" + "Who needs Yule Tidings when you can have Carbs?");
      Console.WriteLine("\n" + "Welcome to 'Bread and More(Bread)'" + "\n");
      Console.WriteLine("Our Bakery is 'proof' that you 'knead' our deals!" + "\n");

      bool leave = false;

      while(!leave)
      {
        Console.WriteLine("Step on up! Prices are on the board, and you won't be bored of our prices!" + "\n" + "-------------------------------------------------");
        Console.WriteLine("\n" + "Bread: $3" + "\n" + "Pastries: $2" + "\n");
        Console.WriteLine("-------------------------------------------------" + "\n" + "Today's Specials: " + "\n");
        Console.WriteLine("Bread ---> Buy Two, get one FREE" + "\n" + "Pastries: ---> THREE for FIVE" + "\n");
        Console.WriteLine("How many loaves of bread today?");
        string stringBreadAmount = Console.ReadLine();
        int breadAmount = int.Parse(stringBreadAmount);
        Console.WriteLine("And would you like:" + "\n" + "[1] White Bread" + "\n" + "[2] Pumpernickle" + "\n" + "Or" + "\n" + "[3] Sourdough?")
        string bChoice = Console.ReadLine();
        Console.WriteLine("And how many pastries would you like?");
        string stringPastryAmount = Console.ReadLine();
        int pastryAmount = int.Parse(stringPastryAmount);
        if (pastryAmount > 0 || breadAmount > 0) {
            Bread newBread = new Bread(breadAmount);
            Pastry newPastry = new Pastry(pastryAmount);
            int breadPrice = newBread.BreadTotal(breadAmount);
            int pastryPrice = newPastry.PastryTotal(pastryAmount);

            Console.WriteLine("Sounds like a deal! Lets take a look here..." + "\n");
            Console.WriteLine(pastryPrice + " dollars for the pastries..." + "\n" + "and..." + "\n" + breadPrice + " dollars for bread!" + "\n");
            Console.WriteLine("Your total today will be: $" + newPastry.Total(breadPrice, pastryPrice));
        }
        else 
        {
            Console.WriteLine("Either I'm losing it, or you forgot to get anything.");
        }
        Console.WriteLine("Is there anything else I can do for you today? [Y or N]" + "\n");
        string userInp = Console.ReadLine().ToLower();
        if (userInp == "y") {
            leave = false;
            Console.WriteLine("You got it!");
        }
        else 
        {
            Console.WriteLine("\n" + "Thank you for stopping by! We'll see you next time you 'roll' through!");
            leave = true;
        }
      }
    }
  }
}
