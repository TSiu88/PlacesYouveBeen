using System;
using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int StayLength { get; set; }
    public string JournalEntry { get; set; }
    private static List<Place> _instances = new List<Place>() {};
    public int Id { get; }

    public Place(string cityName, int stayLength, string journalEntry)
    {
      CityName = cityName;
      StayLength = Convert.ToInt32(stayLength);
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}