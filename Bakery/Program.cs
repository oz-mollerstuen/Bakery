using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("\n" + "Who needs Yule Tidings when you have Carbs?");
      Console.WriteLine("\n" + "Welcome to 'Bread and More(Bread)'" + "\n");
      Console.WriteLine("Our Bakery is 'proof' that you 'knead' our deals!" + "\n");

      bool leave = false;

      while(!leave)
      {
        Console.WriteLine("Step on up! Prices are on the board, and you won't be bored of our prices!" + "\n" + "*-----------------------------*");
        Console.WriteLine("\n" + "Bread: $3" + "\n" + "Pastries: $2" + "\n");
        Console.WriteLine("-------------------------------------------------" + "\n" + "Today's Specials: " + "\n");
        Console.WriteLine("Bread ---> Buy Two, get one FREE" + "\n" "Pastries: ---> THREE for FIVE" + "\n");
        Console.WriteLine("How many loaves of bread today?");
        string stringBreadAmount = Console.ReadLine();
        int breadAmount = int.Parse(stringBreadAmount);
        Console.WriteLine("And how many pastries would you like?")
        string stringPastryAmount = Console.ReadLine();
        int pastryAmount = int.Parse(stringPastryAmount);
        if (pastryAmount > 0 || breadAmount > 0) {
            Bread newBread = new Bread(breadAmount);
            Pastry newPastry = new Pastry(pastryAmount);
            int breadPrice = newBread.BreadTotal(breadAmount);
            int pastryPrice = newPastry.PastryTotal(pastryAmount);

            Console.WriteLine("Sounds like a deal! Lets take a look here..." + "\n");
            Console.WriteLine(pastryAmount + " dollars for the pastries..." + "\n" + "and..." + "\n" + breadAmount + " dollars for bread!" + "\n")
            Console.WriteLine("Your total today will be: $" + newPastry.Total(breadPrice, pastryPrice));
            
        }

        
      }

    }
  }
}