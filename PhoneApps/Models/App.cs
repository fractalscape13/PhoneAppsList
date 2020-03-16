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

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO apps (name, developer, category, releaseDate) VALUES (@AppName, @AppDeveloper, @AppCategory, @AppReleaseDate);";
      MySqlParameter name = new MySqlParameter();
      MySqlParameter developer = new MySqlParameter();
      MySqlParameter category = new MySqlParameter();
      MySqlParameter releaseDate = new MySqlParameter();
      name.ParameterName = "@AppName";
      developer.ParameterName = "@AppDeveloper";
      category.ParameterName = "@AppCategory";
      releaseDate.ParameterName = "@AppReleaseDate";
      name.Value = this.Name;
      developer.Value = this.Developer;
      category.Value = this.Category;
      releaseDate.Value = this.ReleaseDate;
      cmd.Parameters.Add(name);
      cmd.Parameters.Add(developer);
      cmd.Parameters.Add(category);
      cmd.Parameters.Add(releaseDate);

      cmd.ExecuteNonQuery();
      Id = (int)cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}