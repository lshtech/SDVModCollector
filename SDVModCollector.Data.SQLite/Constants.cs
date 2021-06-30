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
      " ObjectIndex TEXT, " +
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
      " ModUniqueId TEXT, " +
      " FishingConditions TEXT, " +
      " FOREIGN KEY(ModUniqueId) REFERENCES Mods(UniqueId))";

    #endregion

  }
}
