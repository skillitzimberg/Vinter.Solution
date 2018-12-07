using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using Vinter.Models;

namespace Vinter.Tests
{
  [TestClass]
  public class BottleTest : IDisposable
  {
    public void Dispose()
    {
        Varietal.ClearAll();
        Bottle.ClearAll();
    }

    public CategoryTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=vinter_test;";
    }

    [TestMethod]
    public void BottleConstructor_CreatesInstanceOfBottle_Bottle()
    {
      Bottle newBottle = new Bottle(1, "Zinfandel", "Mexico", "Don Giovanni", 1);
      Assert.AreEqual(typeof(Bottle), newBottle.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      int expectedId = 1;
      Bottle newBottle = new Bottle(expectedId, "Zinfandel", "Mexico", "Don Giovanni", 1);

      int actualId = newBottle.GetId();

      Assert.AreEqual(expectedId, actualId);
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string expectedName = "Zinfandel";
      Bottle newBottle = new Bottle(1, expectedName, "Mexico", "Don Giovanni", 1);

      string actualName = newBottle.GetName();

      Assert.AreEqual(expectedName, actualName);
    }



  }
}
