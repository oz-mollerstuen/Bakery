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

  }
}