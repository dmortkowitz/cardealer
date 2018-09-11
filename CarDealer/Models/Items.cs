using System.Collections.Generic;
using System;

namespace CarDealer.Models
{
  public class Car
  {
    private string _description;
    private static List<Car> _instances = new List<Car> {};
    

    public Car (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public string[] ResultsList()
    {
      string[] descriptionString = _description.Split(',');
      return descriptionString;
      
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this); 
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
