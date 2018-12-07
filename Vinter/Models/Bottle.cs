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

    public Bottle(int id, string name, string region, string maker, int varietalId)
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

  }
}
