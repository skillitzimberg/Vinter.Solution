using Microsoft.VisualStudio.TestTools.UnitTesting;
// using MySql.Data.MySqlClient;
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
        Bottle.ClearAll();
    }

    public BottleTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=vinter_test;";
    }

    [TestMethod]
    public void BottleConstructor_CreatesInstanceOfBottle_Bottle()
    {
      Bottle newBottle = new Bottle("Zinfandel", "Mexico", "Don Giovanni", 1, 1);
      Assert.AreEqual(typeof(Bottle), newBottle.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      int expectedId = 1;
      Bottle newBottle = new Bottle("Zinfandel", "Mexico", "Don Giovanni", 1, expectedId);

      int actualId = newBottle.GetId();

      Assert.AreEqual(expectedId, actualId);
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string expectedName = "Zinfandel";
      Bottle newBottle = new Bottle(expectedName, "Mexico", "Don Giovanni", 1, 1);

      string actualName = newBottle.GetName();

      Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void GetRegion_ReturnsRegion_String()
    {
      string expectedRegion = "Mexico";
      Bottle newBottle = new Bottle("Zinfandel", expectedRegion, "Don Giovanni", 1, 1);

      string actualRegion = newBottle.GetRegion();

      Assert.AreEqual(expectedRegion, actualRegion);
    }

    [TestMethod]
    public void GetMaker_ReturnsMaker_String()
    {
      string expectedMaker = "Don Giovanni";
      Bottle newBottle = new Bottle("Zinfandel", "Mexico", expectedMaker, 1, 1);

      string actualMaker = newBottle.GetMaker();

      Assert.AreEqual(expectedMaker, actualMaker);
    }

    [TestMethod]
    public void GetVarietalId_ReturnsId_Int()
    {
      int expectedVarietalId = 1;
      Bottle newBottle = new Bottle("Zinfandel", "Mexico", "Don Giovanni", expectedVarietalId, 1);

      int actualVarietalId = newBottle.GetVarietalId();

      Assert.AreEqual(expectedVarietalId, actualVarietalId);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      //Arrange
      List<Bottle> expectedBottleList = new List<Bottle> { };

      //Act
      List<Bottle> actualBottleList = Bottle.GetAll();

      //Assert
      CollectionAssert.AreEqual(expectedBottleList, actualBottleList);
    }

    [TestMethod]
    public void Save_SavesToDatabase_BottleList()
    {
      //Arrange
      Bottle newBottle = new Bottle("Zinfandel", "Mexico", "Don Giovanni", 1, 1);
      List<Bottle> expectedBottleList = new List<Bottle>{newBottle};

      //Act
      newBottle.Save();
      List<Bottle> actualBottleList = Bottle.GetAll();

      Console.WriteLine(expectedBottleList[0].GetName());
      Console.WriteLine(actualBottleList[0].GetName());
      //Assert
      CollectionAssert.AreEqual(expectedBottleList, actualBottleList);
    }

    // [TestMethod]
    // public void GetAll_ReturnsBottles_List()
    // {
    //   //Arrange
    //   Bottle bottleOne = new Bottle("Zinfandel", "Mexico", "Don Giovanni", 1, 1);
    //   Bottle bottleTwo = new Bottle("PortoPort", "California", "Paul's Vineyard", 2, 1);
    //   List<Bottle> expectedBottleList = new List<Bottle> { bottleOne, bottleTwo };
    //
    //   //Act
    //   List<Bottle> actualBottleList = Bottle.GetAll();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(expectedBottleList, actualBottleList);
    // }





  }
}
