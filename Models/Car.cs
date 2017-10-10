using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _year;
    private int _price;
    private int _miles;

    private static List<Car> _CarLot = new List<Car> {};

    public Car (string makeModel, int year, int price, int miles)
    {
      _makeModel = makeModel;
      _year = year;
      _price = price;
      _miles = miles;
    }
  }


}
