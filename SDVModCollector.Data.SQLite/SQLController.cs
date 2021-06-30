using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Data.Sqlite;

namespace SDVModCollector.Data.SQLite
{
  public static class SqlController
  {
    public static void PrepDatabase()
    {
      if (File.Exists(Constants.DatabaseFile)) return;
      using var connection = new SqliteConnection(Constants.ConnectionString);
      using var command = connection.CreateCommand();
      connection.Open();
      command.PrepTableMods();
      command.PrepTableModVersions();
      command.PrepTableObjects();
      connection.Close();
    }

    public static string SanitizeString(this string command)
    {
      return command.Replace("'", "''");
    }

    private static int ExecuteNonQuery(this IDbCommand command, string commandText)
    {
      command.CommandText = commandText;
      return command.ExecuteNonQuery();
    }

    private static void PrepTableMods(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableMods);
      command.ExecuteNonQuery(VanillaData.CreateVanillaModEntry());
    }

    private static void PrepTableModVersions(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableModVersions);
      command.ExecuteNonQuery(VanillaData.CreateVanillaModVersionEntry());
    }

    private static void PrepTableObjects(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableObjects);
      var jsStream = Assembly.GetAssembly(typeof(VanillaData))
        .GetManifestResourceStream("SDVModCollector.Data.SQLite.Raw_Data.ObjectInformation.json");
      if (jsStream == null)
        throw new InvalidDataException("Unable to load vanilla object data");
      var jsObjectst = new StreamReader(jsStream).ReadToEnd();
      var objectCollection = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, string>>(jsObjectst);

      var objectQuery = string.Empty;
      Debug.Assert(objectCollection != null, nameof(objectCollection) + " != null");
      foreach (var objectItem in objectCollection)
      {
        command.ExecuteNonQuery(VanillaData.CreateVanillaObjectEntry(objectItem));
      }
    }

  }
}
