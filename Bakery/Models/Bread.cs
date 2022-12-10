using System;

namespace Bakery.Models
{

  public class Bread
  {
    public int BreadAmount { get; set; }

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
    }
  Dictionary<string, int> breadDict = new Dictionary<string, int>() {
  {"1", 3},
  {"2", 4},
  {"3", 5}}; 

    public int BreadTotal(int breadAmount)
    {
      int breadCost = 0;
      if (BreadAmount <= 2) {
        breadCost = BreadAmount * breadDict["bChoice"];
      } else {
        breadCost = (((BreadAmount - (BreadAmount % 3)) / 3) * 5) + ((BreadAmount % 3) * 2);
      }
      return breadCost;
    }

    public int Total(int breadCost, int pastryCost)
    {
      int totalPrice = breadCost + pastryCost;
      return totalPrice;
    }
  }
}