using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
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
      command.PrepTableBigCraftables();
      command.PrepTableCrops();
      command.PrepTableFurniture();
      connection.Close();
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
      var objectCollection = GetResourceData("SDVModCollector.Data.SQLite.Raw_Data.ObjectInformation.json");
      Debug.Assert(objectCollection != null, nameof(objectCollection) + " != null");
      foreach (var objectItem in objectCollection)
      {
        command.ExecuteNonQuery(VanillaData.CreateVanillaObjectEntry(objectItem));
      }
    }

    private static void PrepTableBigCraftables(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableBigCraftables);
      var objectCollection = GetResourceData("SDVModCollector.Data.SQLite.Raw_Data.BigCraftablesInformation.json");
      Debug.Assert(objectCollection != null, nameof(objectCollection) + " != null");
      foreach (var objectItem in objectCollection)
      {
        command.ExecuteNonQuery(VanillaData.CreateVanillaBigCraftableEntry(objectItem));
      }
    }

    private static void PrepTableCrops(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableCrops);
      var objectCollection = GetResourceData("SDVModCollector.Data.SQLite.Raw_Data.Crops.json");
      Debug.Assert(objectCollection != null, nameof(objectCollection) + " != null");
      foreach (var objectItem in objectCollection)
      {
        command.ExecuteNonQuery(VanillaData.CreateVanillaCropEntry(objectItem));
      }
    }

    private static void PrepTableFurniture(this IDbCommand command)
    {
      command.ExecuteNonQuery(Constants.CreateTableFurniture);
      var objectCollection = GetResourceData("SDVModCollector.Data.SQLite.Raw_Data.Furniture.json");
      Debug.Assert(objectCollection != null, nameof(objectCollection) + " != null");
      foreach (var objectItem in objectCollection)
      {
        command.ExecuteNonQuery(VanillaData.CreateVanillaFurnitureEntry(objectItem));
      }
    }

    private static IDictionary<int, string> GetResourceData(string path)
    {
      var jsStream = Assembly.GetAssembly(typeof(VanillaData))?.GetManifestResourceStream(path);
      if (jsStream == null)
        throw new InvalidDataException($"Unable to load vanilla data from {path}");
      var jsObjectst = new StreamReader(jsStream).ReadToEnd();
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, string>>(jsObjectst);
    }
  }
}
