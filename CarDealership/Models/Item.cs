using System;
using System.Collections.Generic;
namespace CarDealership.Models {

public class Item
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _description;
  private static List<Item> _instances = new List<Item> {};

  public Item(string makeModel, int price, int miles, string description)
  {
    _makeModel = makeModel;
    _price = price;
    _miles = miles;
    _description = description;
    _instances.Add(this);
  }

    //Setters
    public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }

    public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }

    public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }

    public void SetDescription(string newDescription)
  {
    _description = newDescription;
  }


    //Getters
  public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetDescription()
    {
      return _description;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    // public static GetAttributes()
    // {
    //     for(int x = 0; x <= _instances.Length; x++)
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public bool WorthBuying(int maxPrice, int maxMiles)
    // {
    //   return ((Price < maxPrice) && (Miles < maxMiles));
    // }
  }

}