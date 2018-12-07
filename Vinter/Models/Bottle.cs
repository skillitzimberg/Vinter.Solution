using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

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

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM bottles;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public override bool Equals(System.Object otherBottle)
    {
      if (!(otherBottle is Bottle))
      {
        return false;
      }
      else
      {
        Bottle newBottle = (Bottle) otherBottle;
        bool idEquality = (this.GetId() == newBottle.GetId());
        bool nameEquality = (this.GetName() == newBottle.GetName());
        bool varietalEquality = this.GetVarietalId() == newBottle.GetVarietalId();
        return (idEquality && nameEquality && varietalEquality);
        //fail the Equals test by not adding the Equals method
      }
    }

    public static List<Bottle> GetAll()
    {
      // Bottle newBottle = new Bottle("anystring", "bottleRegion", "bottleMaker", 2, 4);
      // List<Bottle> allBottles = new List<Bottle> {newBottle};  **How to fail**

      List<Bottle> allBottles = new List<Bottle> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM bottles;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int bottleId = rdr.GetInt32(0);
        string bottleName = rdr.GetString(1);
        string bottleRegion = rdr.GetString(2);
        string bottleMaker = rdr.GetString(3);
        int bottleVarietalId = rdr.GetInt32(4);
        Bottle newBottle = new Bottle(bottleName, bottleRegion, bottleMaker, bottleVarietalId, bottleId);
        allBottles.Add(newBottle);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allBottles;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO bottles (name, region, maker, varietal_id) VALUES (@BottleName, @BottleRegion, @BottleMaker, @VarietalId);";

      MySqlParameter bottleName = new MySqlParameter();
      bottleName.ParameterName = "@BottleName";
      bottleName.Value = this._name;
      cmd.Parameters.Add(bottleName);

      MySqlParameter bottleRegion = new MySqlParameter();
      bottleRegion.ParameterName = "@BottleRegion";
      bottleRegion.Value = this._region;
      cmd.Parameters.Add(bottleRegion);

      MySqlParameter bottleMaker = new MySqlParameter();
      bottleMaker.ParameterName = "@BottleMaker";
      bottleMaker.Value = this._maker;
      cmd.Parameters.Add(bottleMaker);

      MySqlParameter varietalId = new MySqlParameter();
      varietalId.ParameterName = "@VarietalId";
      varietalId.Value = this._varietalId;
      cmd.Parameters.Add(varietalId);

      //Add this command for above 3 lines of code
      cmd.Parameters.AddWithValue("@BottleName", this._name);
      cmd.Parameters.AddWithValue("@BottleRegion", this._region);
      cmd.Parameters.AddWithValue("@BottleMaker", this._maker);
      cmd.Parameters.AddWithValue("@VarietalId", this._varietalId);
      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      //To fail Saves to database method - declare method and keep it empty
      //To fail Save AssignsId test -
      //do not add the "_id = (int) cmd.LastInsertedId;" line
    }

  }
}
