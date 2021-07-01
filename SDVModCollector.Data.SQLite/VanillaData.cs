using System;
using System.Collections.Generic;
using System.IO;

namespace SDVModCollector.Data.SQLite
{
  internal static class VanillaData
  {
    internal static string CreateVanillaModEntry()
    {
      return QueryBuilder.Insert("Mods", new[]
      {
        ("UniqueId", "StardewValley"),
        ("Name", "Stardew Valley"),
        ("Author", "ConcernedApe"),
        ("Description", "Stardew Valley"),
        ("RelativePath", ".")
      }, true);
    }

    internal static string CreateVanillaModVersionEntry()
    {
      return QueryBuilder.Insert("ModVersions", new[]
      {
        ("ModUniqueId", "StardewValley"),
        ("Version", "1.5"),
        ("Manifest", string.Empty)
      }, true);
    }

    internal static string CreateVanillaObjectEntry(KeyValuePair<int, string> objectItem)
    {
      var (key, value) = objectItem;
      var objectData = ConvertObject(value);
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
        ("ModUniqueId", "StardewValley")
      }, true);

      return objectQuery;
    }

    internal static string CreateVanillaBigCraftableEntry(KeyValuePair<int, string> objectItem)
    {
      var (key, value) = objectItem;
      var objectData = ConvertBigCraftable(value);
      var objectQuery = QueryBuilder.Insert("BigCraftables", new[]
      {
        ("Id", key.ToString()),
        ("BigCraftableIndex", key.ToString()),
        ("Name", objectData.Name),
        ("Price", objectData.Price),
        ("Edibility", objectData.Edibility),
        ("Type", objectData.Type),
        ("Category", objectData.Category),
        ("Description", objectData.Description),
        ("Outdoors", objectData.Outdoors),
        ("Indoors", objectData.Indoors),
        ("Fragility", objectData.Fragility),
        ("Lamp", objectData.Lamp),
        ("DisplayName", objectData.DisplayName),
        ("ModUniqueId", "StardewValley")
      }, true);

      return objectQuery;
    }

    internal static string CreateVanillaCropEntry(KeyValuePair<int, string> objectItem)
    {
      var (key, value) = objectItem;
      var objectData = ConvertCrop(value);
      var objectQuery = QueryBuilder.Insert("Crops", new[]
      {
        ("Id", key.ToString()),
        ("SeedIndex", key.ToString()),
        ("Stages", objectData.Stages),
        ("Seasons", objectData.Seasons),
        ("SpriteIndex", objectData.SpriteIndex),
        ("HarvestIndex", objectData.HarvestObject),
        ("Regrow", objectData.Regrow),
        ("Scythe", objectData.Scythe),
        ("Bonus", objectData.Bonus),
        ("Trellis", objectData.Trellis),
        ("Tint", objectData.Tint),
        ("ModUniqueId", "StardewValley")
      }, true);

      return objectQuery;
    }

    internal static string CreateVanillaFurnitureEntry(KeyValuePair<int, string> objectItem)
    {
      var (key, value) = objectItem;
      var objectData = ConvertFurniture(value);
      var objectQuery = QueryBuilder.Insert("Furniture", new[]
      {
        ("Id", key.ToString()),
        ("FurnitureIndex", key.ToString()),
        ("Name", objectData.Name),
        ("Type", objectData.Type),
        ("Source", objectData.Source),
        ("Bounding", objectData.Bounding),
        ("Rotations", objectData.Rotations),
        ("Price", objectData.Price),
        ("ModUniqueId", "StardewValley")
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
      {
        sdvObj.GeodeLoot = objProps[6];
      }
      else if (sdvObj.Type == "Fish" || sdvObj.Name == "Treasure Chest")
      {
        sdvObj.FishingConditions = objProps[6];
      }
      else
      {
        sdvObj.ArtifactChances = objProps[6];
        if (objProps.Length > 7)
          sdvObj.ArtifactOther = objProps[7];
      }

      return sdvObj;
    }

    private static SdvBigCraftable ConvertBigCraftable(string bcString)
    {
      var bcProps = bcString.Split('/');
      if (bcProps.Length < 9)
        throw new InvalidDataException("Big craftable data not valid");

      var sdvBc = new SdvBigCraftable
      {
        Name = bcProps[0],
        Price = bcProps[1],
        Edibility = bcProps[2]
      };
      var typeDict = ParseTypeField(bcProps[3]);
      if (typeDict.ContainsKey("type"))
        sdvBc.Type = typeDict["type"];
      if (typeDict.ContainsKey("cat"))
        sdvBc.Category = typeDict["cat"];
      sdvBc.Description = bcProps[4];
      sdvBc.Outdoors = bcProps[5];
      sdvBc.Indoors = bcProps[6];
      sdvBc.Fragility = bcProps[7];
      if (bcProps[8] == "true")
      {
        sdvBc.Lamp = bcProps[8];
        sdvBc.DisplayName = bcProps[9];
      }
      else
      {
        sdvBc.DisplayName = bcProps[8];
      }


      return sdvBc;
    }

    private static SdvCrop ConvertCrop(string cropString)
    {
      var cropProps = cropString.Split('/');
      if (cropProps.Length < 9)
        throw new InvalidDataException("Crop data not valid");

      return new SdvCrop
      {
        Stages = cropProps[0],
        Seasons = cropProps[1],
        SpriteIndex = cropProps[2],
        HarvestObject = cropProps[3],
        Regrow = cropProps[4],
        Scythe = cropProps[5],
        Bonus = cropProps[6],
        Trellis = cropProps[7],
        Tint = cropProps[8]
      };
    }

    private static SdvFurniture ConvertFurniture(string furnString)
    {
      var furnProps = furnString.Split('/');
      if (furnProps.Length < 6)
        throw new InvalidDataException("Furniture data not valid");

      return new SdvFurniture
      {
        Name = furnProps[0],
        Type = furnProps[1],
        Source = furnProps[2],
        Bounding = furnProps[3],
        Rotations = furnProps[4],
        Price = furnProps[5]
      };
    }

    private static IDictionary<string, string> ParseTypeField(string field)
    {
      var types = field.Split(' ');
      var dict = new Dictionary<string, string>();
      switch (types.Length)
      {
        case 1:
        {
          dict.Add(int.TryParse(types[0], out _) ? "cat" : "type", types[0]);
          break;
        }
        case 2:
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

    private struct SdvBigCraftable
    {
      internal string Name;
      internal string Price;
      internal string Edibility;
      internal string Type;
      internal string Category;
      internal string DisplayName;
      internal string Description;
      internal string Outdoors;
      internal string Indoors;
      internal string Fragility;
      internal string Lamp;
    }

    private struct SdvCrop
    {
      internal string Stages;
      internal string Seasons;
      internal string SpriteIndex;
      internal string HarvestObject;
      internal string Regrow;
      internal string Scythe;
      internal string Bonus;
      internal string Trellis;
      internal string Tint;
    }

    private struct SdvFurniture
    {
      internal string Name;
      internal string Type;
      internal string Source;
      internal string Bounding;
      internal string Rotations;
      internal string Price;
    }
  }
}