using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using Vinter.Models;

namespace Vinter.Tests
{
  [TestClass]
  public class VinterTest : IDisposable
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
    public void VarietalConstructor_CreatesInstanceOfVarietal_Varietal()
    {
      Varietal newVarietal = new Varietal("test varietal", 2);
      Assert.AreEqual(typeof(Varietal), newVarietal.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Varietal";
      Varietal newVarietal = new Varietal(name, 3);

      //Act
      string result = newVarietal.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVarietalId_Int()
    {
      //Arrange
      string name = "Test Varietal";
      int expectedId = 2;
      Varietal newVarietal = new Varietal(name, expectedId);

      //Act
      int actualId = newVarietal.GetId();

      //Assert
      Assert.AreEqual(expectedId, actualId);
    }
    //
    // [TestMethod]
    // public void GetAll_ReturnsListOfAllVarieties_List()
    // {
    //   Varietal varietalOne = new Varietal("one", 1);
    //   Varietal varietalTwo = new Varietal("two", 2);
    //
    //   CollectionAssert.AreEqual();
    // }

  }
}
