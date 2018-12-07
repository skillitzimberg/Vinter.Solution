using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace Vinter.Models
{
  public class Bottle
  {
    private int _id;
    private string _name;
    private string _region;
    private string _maker;
    private int _varietalId;

    public Bottle(string name, string region, string maker, int varietalId, int id = 0)
    {
      _id = id;
      _name = name;
      _region = region;
      _maker = maker;
      _varietalId = varietalId;
    }

    public int GetId()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetRegion()
    {
      return _region;
    }

    public string GetMaker()
    {
      return _maker;
    }

    public int GetVarietalId()
    {
      return _varietalId;
    }

    public static List<Bottle> GetAll()
    {Bottle newBottle = new Bottle("anystring", "bottleRegion", "bottleMaker", 2, 4);
      List<Bottle> allBottles = new List<Bottle> {newBottle};
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // var cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"SELECT * FROM items;";
      // var rdr = cmd.ExecuteReader() as MySqlDataReader;
      // while(rdr.Read())
      // {
      //   int bottleId = rdr.GetInt32(0);
      //   string bottleName = rdr.GetString(1);
      //   string bottleRegion = rdr.GetString(2);
      //   string bottleMaker = rdr.GetString(3);
      //   int bottleVarietalId = rdr.GetInt32(4);
      //   Bottle newBottle = new Bottle(bottleName, bottleRegion, bottleMaker, varietalId, bottleId);
      //   allBottles.Add(newBottle);
      // }
      // conn.Close();
      // if (conn != null)
      // {
      //   conn.Dispose();
      // }
      return allBottles;
    }


  }
}
