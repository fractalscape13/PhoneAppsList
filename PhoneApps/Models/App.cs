using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PhoneApps.Models
{
  public class App
  {
    public string Name { get; set; }
    public string Developer { get; set; }
    public string Category { get; set; }
    public string ReleaseDate { get; set; }
    public int Id { get; set; }

    public App (string name, string developer, string category, string releaseDate)
    {
      Name = name;
      Developer = developer;
      Category = category;
      ReleaseDate = releaseDate;
      Id;
    }
  }
}