using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private string _year;
    private string _price;
    private string _mileage;

    private static List<Car> _CarLot = new List<Car> {};

    public Car (string makeModel, string year, string price, string mileage)
    {
      _makeModel = makeModel;
      _year = year;
      _price = price;
      _mileage = mileage;
    }

    public void Save()
    {
      _CarLot.Add(this);
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetYear()
    {
      return _year;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetMileage()
    {
      return _mileage;
    }
    public void SetMileage(string newMileage)
    {
      _mileage = newMileage;
    }
    public static List<Car> GetAll()
    {
      return _CarLot;
    }
    public static void ClearAll()
    {
      _CarLot.Clear();
    }
  }


}
