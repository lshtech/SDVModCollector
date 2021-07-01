using System.Collections.Generic;

namespace SDVModCollector.Data.SQLite
{
  internal static class QueryBuilder
  {
    public static string SanitizeString(this string command)
    {
      return command == null ? null : command.Replace("'", "''");
    }

    internal static string Insert(string tableName, IEnumerable<(string column, string value)> values, bool orReplace = false)
    {
      var columnString = string.Empty;
      var valueString = string.Empty;
      foreach (var (column, value) in values)
      {
        columnString += column + ", ";
        valueString += $"'{value.SanitizeString()}', ";
      }

      return $"INSERT {(orReplace ? "OR REPLACE" : string.Empty)} INTO {tableName} ({columnString.Trim().TrimEnd(',')}) VALUES ({valueString.Trim().TrimEnd(',')})"; ;
    }
  }
}
