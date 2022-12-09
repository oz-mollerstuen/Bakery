﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class ItemTests
    {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread (1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    
    public void GetPastryAndBreadAmount_ReturnsTotalAmount_Int()
    {
      
      int pastryAmount = 4;
      int breadAmount = 4;
      Bread newBread = new Bread (breadAmount);
      Pastry newPastry = new Pastry (breadAmount);
     
      int resultPastry = newPastry.PastryAmount;
      int resultBread = newBread.BreadAmount;
      int result = pastryAmount + breadAmount;
     
      Assert.AreEqual(pastryAmount + breadAmount, result);
    }
  }
}