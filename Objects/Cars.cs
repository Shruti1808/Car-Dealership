using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _make;
    private string _price;
    private string _color;
    private string _mileage;
    private string _year;
    private static List<Car> _carDetails = new List<Car> {};

    public Car (string make, string price, string color, string mileage, string year)
    {
      _make = make;
      _price = price;
      _color = color;
      _mileage = mileage;
      _year = year;
    }
    public string Getmake()
  {
    return _make;
  }
  public void Setmake(string newmake)
  {
    _make = newmake;
  }
  public string Getprice()
  {
    return _price;
  }
  public void Setprice(string newprice)
  {
    _price = newprice;
  }
  public string Getcolor()
  {
    return _color;
  }
  public void Setcolor(string newcolor)
  {
    _color = newcolor;
  }
  public string Getmileage()
{
  return _mileage;
}
public void Setmileage(string newmileage)
{
  _mileage = newmileage;
}
public string Getyear()
{
  return _year;
}
public void Setyear(string newyear)
{
  _year = newyear;
}
  public static List<Car> GetAll()
  {
    return _carDetails;
  }
  public void Save()
  {
    _carDetails.Add(this);
  }
  public static void ClearAll()
{
_carDetails.Clear();
}
  }
}
