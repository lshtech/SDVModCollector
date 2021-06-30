using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace SDVModCollector.Data.SQLite
{
  internal static class VanillaData
  {
    internal static string CreateVanillaModEntry() =>
      QueryBuilder.Insert("Mods", new[]
      {
        ("UniqueId", "StardewValley"),
        ("Name", "Stardew Valley"),
        ("Author", "ConcernedApe"),
        ("Description", "Stardew Valley"),
        ("RelativePath", ".")
      }, true);

    internal static string CreateVanillaModVersionEntry() =>
      QueryBuilder.Insert("ModVersions", new[]
      {
        ("ModUniqueId", "StardewValley"),
        ("Version", "1.5"),
        ("Manifest", string.Empty)
      }, true);

    internal static string CreateVanillaObjectEntry(KeyValuePair<int, string> objectItem)
    {
      var (key, value) = objectItem;
      var objectData = ConvertObject(value.SanitizeString());
      var objectQuery = QueryBuilder.Insert("Objects", new[]
       {
          ("Id", key.ToString()),
          ("ObjectIndex", key.ToString()),
          ("Name", objectData.Name),
          ("Price", objectData.Price),
          ("Edibility", objectData.Edibility),
          ("Type", objectData.Type),
          ("Category", objectData.Category),
          ("DisplayName", objectData.DisplayName),
          ("Description", objectData.Description),
          ("FoodType", objectData.FoodType),
          ("Buffs", objectData.Buffs),
          ("BuffLength", objectData.BuffLength),
          ("GeodeLoot", objectData.GeodeLoot),
          ("ArtifactChances", objectData.ArtifactChances),
          ("ArtifactOther", objectData.ArtifactOther),
          ("FishingConditions", objectData.FishingConditions),
          ("ModUniqueId","StardewValley")
        }, true);
      
      return objectQuery;
    }

    private static SdvObject ConvertObject(string objectString)
    {
      var objProps = objectString.Split('/');
      if (objProps.Length < 6)
        throw new InvalidDataException("Object data not valid");

      var sdvObj = new SdvObject
      {
        Name = objProps[0],
        Price = objProps[1],
        Edibility = objProps[2]
      };
      var typeDict = ParseTypeField(objProps[3]);
      if (typeDict.ContainsKey("type"))
        sdvObj.Type = typeDict["type"];
      if (typeDict.ContainsKey("cat"))
        sdvObj.Category = typeDict["cat"];
      sdvObj.DisplayName = objProps[4];
      sdvObj.Description = objProps[5];
      if (objProps.Length <= 6) return sdvObj;
      if (objProps[6] == "food" || objProps[6] == "drink")
      {
        sdvObj.FoodType = objProps[6];
        if (sdvObj.Name == "Vinegar") return sdvObj;
        sdvObj.Buffs = objProps[7];
        sdvObj.BuffLength = objProps[8];
      }
      else if (sdvObj.Name.Contains("Geode") || sdvObj.Name == "Artifact Trove")
        sdvObj.GeodeLoot = objProps[6];
      else if (sdvObj.Type == "Fish" || sdvObj.Name == "Treasure Chest")
        sdvObj.FishingConditions = objProps[6];
      else
      {
        sdvObj.ArtifactChances = objProps[6];
        if (objProps.Length > 7)
          sdvObj.ArtifactOther = objProps[7];
      }

      return sdvObj;
    }

    private static IDictionary<string, string> ParseTypeField(string field)
    {
      var types = field.Split(' ');
      var dict = new Dictionary<string, string>();
      switch (types.Length)
      {
        case (1):
          {
            dict.Add(int.TryParse(types[0], out _) ? "cat" : "type", types[0]);
            break;
          }
        case (2):
          {
            dict.Add("type", types[0]);
            dict.Add("cat", types[1]);
            break;
          }
        default:
          throw new InvalidDataException($"Values should be 1 or 2, received {types.Length}");
      }
      return dict;
    }

    private struct SdvObject
    {
      internal string Name;
      internal string Price;
      internal string Edibility;
      internal string Type;
      internal string Category;
      internal string DisplayName;
      internal string Description;
      internal string FoodType;
      internal string Buffs;
      internal string BuffLength;
      internal string GeodeLoot;
      internal string ArtifactChances;
      internal string ArtifactOther;
      internal string FishingConditions;
    }

  }
}
