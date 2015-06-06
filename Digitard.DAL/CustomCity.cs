using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitard.DAL
{
  [DataContract(]
  public partial class City
    {
      private readonly DigitardEntities1 ctx;

      [DataMember]
      public City(String name)
      {
        this.name = name;
      }

      [DataMember]
      public City(int id, String name) : this(name)
      {
        this.idCity = id;
      }

      [DataMember]
      public bool Add()
      {
        var isInserted = false;
        ctx = new DigitardEntities1();
        ctx.City.Add();
        var res = ctx.SaveChanges();
        if (res > 0)
          isInserted = true;
        return isInserted;

      }
      [DataMember]
      public List<City> GetCities()
      {
        var res = ctx.City;
        var cities = new List<City>;
        if (res != null)
        {
          foreach(var city in res)
          {
            cities.Add(new City(city.idCity, city.name))
          }
        }
        return cities;
      }
    }
}
