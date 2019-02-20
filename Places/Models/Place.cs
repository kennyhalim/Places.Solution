using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private string _countryName;
    private int _yearVisited;
    private static List<Place> _placesIveBeen = new List<Place> {};
    private int _id;

    public Place (string cityName, string countryName, int yearVisited)
    {
      _cityName = cityName;
      _countryName = countryName;
      _yearVisited = yearVisited;
      _placesIveBeen.Add(this);
      _id = _placesIveBeen.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public string GetCountryName()
    {
      return _countryName;
    }

    public int GetYear()
    {
      return _yearVisited;
    }

    public static List<Place> GetAll()
    {
      return _placesIveBeen;
    }

    public static void ClearAll()
    {
      _placesIveBeen.Clear();
    }

    public static Place Find(int searchId)
    {
      return _placesIveBeen[searchId-1];
    }

    public int GetId()
   {
     return _id;
   }
  }
}
