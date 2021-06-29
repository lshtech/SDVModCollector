using System.IO;
using Newtonsoft.Json;

namespace SDVModCollector.JSONHelper
{
  public static class Helper
  {
    public static T DeserializeObject<T>(string filePath) where T : class
    {
      var jsonString = File.ReadAllText(filePath);
      try
      {
        return JsonConvert.DeserializeObject<T>(jsonString);
      }
      catch (JsonReaderException)
      {
        // try replacing curly quotes
        if (jsonString.Contains("“") || jsonString.Contains("”"))
        {
          try
          {
            return JsonConvert.DeserializeObject<T>(jsonString.Replace('“', '"').Replace('”', '"'));
          }
          catch { /* rethrow original error */ }
        }

        throw;
      }
    }
  }
}
