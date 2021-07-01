namespace SDVModCollector.Data.SQLite
{
  static class Constants
  {
    internal const string DatabaseFile = ".\\Collection.db;";
    internal static readonly string ConnectionString = $"DATA Source=.\\{DatabaseFile};";

    #region Create Tables

    internal const string CreateTableMods =
      "CREATE TABLE IF NOT EXISTS Mods " +
      "(UniqueId TEXT PRIMARY KEY, " +
      " Name TEXT, " +
      " Author TEXT, " +
      " Description TEXT, " +
      " RelativePath TEXT)";

    internal const string CreateTableModVersions =
      "CREATE TABLE IF NOT EXISTS ModVersions " +
      "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
      " ModUniqueId TEXT, " +
      " Version TEXT, " +
      " Manifest TEXT," +
      " FOREIGN KEY(ModUniqueId) REFERENCES Mods(UniqueId))";

    internal const string CreateTableObjects =
      "CREATE TABLE IF NOT EXISTS Objects " +
      "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
      " ObjectIndex TEXT NOT NULL UNIQUE, " +
      " Name TEXT, " +
      " Price INTEGER, " +
      " Edibility INTEGER, " +
      " Type TEXT, " +
      " Category INTEGER, " +
      " DisplayName TEXT, " +
      " Description TEXT, " +
      " FoodType TEXT, " +
      " Buffs TEXT, " +
      " BuffLength INTEGER, " +
      " GeodeLoot TEXT, " +
      " ArtifactChances TEXT, " +
      " ArtifactOther TEXT, " +
      " FishingConditions TEXT, " +
      " ModUniqueId TEXT, " +
      " FOREIGN KEY(ModUniqueId) REFERENCES Mods(UniqueId))";

    internal const string CreateTableBigCraftables =
      "CREATE TABLE IF NOT EXISTS BigCraftables " +
      "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
      " BigCraftableIndex TEXT NOT NULL, " +
      " Name TEXT, " +
      " Price INTEGER, " +
      " Edibility INTEGER, " +
      " Type TEXT, " +
      " Category INTEGER, " +
      " Description TEXT, " +
      " Outdoors TEXT, " +
      " Indoors TEXT, " +
      " Fragility INTEGER, " +
      " Lamp TEXT, " +
      " DisplayName TEXT, " +
      " ModUniqueId TEXT, " +
      " FOREIGN KEY (ModUniqueId) REFERENCES Mods(UniqueId))";

    internal const string CreateTableCrops =
      "CREATE TABLE IF NOT EXISTS Crops " +
      "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
      " SeedIndex TEXT NOT NULL, " +
      " Stages TEXT, " +
      " Seasons TEXT, " +
      " SpriteIndex TEXT, " +
      " HarvestIndex TEXT, " +
      " Regrow INTEGER, " +
      " Scythe INTEGER, " +
      " Bonus TEXT, " +
      " Trellis TEXT, " +
      " Tint TEXT, " +
      " ModUniqueId TEXT, " +
      " FOREIGN KEY (SeedIndex) REFERENCES Objects(ObjectIndex), " +
      " FOREIGN KEY (HarvestIndex) REFERENCES Objects(ObjectIndex), " +
      " FOREIGN KEY (ModUniqueId) REFERENCES Mods(UniqueId))";

    internal const string CreateTableFurniture =
      "CREATE TABLE IF NOT EXISTS Furniture " +
      "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
      " FurnitureIndex TEXT NOT NULL, " +
      " Name TEXT, " +
      " Type TEXT, " +
      " Source TEXT, " +
      " Bounding TEXT, " +
      " Rotations INTEGER, " +
      " Price INTEGER, " +
      " ModUniqueId TEXT, " +
      " FOREIGN KEY (ModUniqueId) REFERENCES Mods(UniqueId))";

    #endregion

  }
}
