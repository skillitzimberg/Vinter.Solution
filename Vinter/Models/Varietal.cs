using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace Vinter.Models
{
  public class Varietal
  {
    private string _name;
    private int _id;
    private List<Varietal> _allVarietals;

    public Varietal(string name, int id = 0)
    {
      _id = id;
      _name = name;
    }

    public string GetName()
   {
     return _name;
     //to fail return "test";
   }

   public int GetId()
   {
     return _id;
   }

   // [TestMethod]
   // public void GetAllBottles_ReturnsListOfAllBottles_List()
   // {
   //   Bottle bottleOne = new Bottle(1, "Zinfandel", "Mexico", "Don Giovanni", 1);
   //   Bottle bottleTwo = new Bottle(1, 'PortoPort', "California", "Paul's Vineyard", 2);
   //
   //   Assert.AreEqual(typeof(Bottle), newBottle.GetType());
   // }

   // public void Add()
   // {
   //
   // }

  }
}
