using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SDVModCollector.JSONScraper
{
  public static class Scraper
  {
    public static void Scrape(string modsPath)
    {
      var manifestCollection = GetManifests(modsPath);

      var contentPackTypes = manifestCollection
        .Where(m => !string.IsNullOrEmpty(m.Value.ContentPackFor.UniqueId))
        .Select(m => m.Value.ContentPackFor.UniqueId)
        .Distinct(StringComparer.CurrentCultureIgnoreCase)
        .OrderBy(c => c);

      foreach (var manifest in manifestCollection)
      {
        if (manifest.Value.ContentPackFor.UniqueId.ToLower() == "spacechase0.jsonassets")
        {

        }
      }      
    }

    private static Dictionary<string, Manifest> GetManifests(string modsPath)
    {
      var manifests = Directory.EnumerateFiles(modsPath, "manifest.json", SearchOption.AllDirectories);
      var manifestCollection = new Dictionary<string, Manifest>();
      foreach (var manifest in manifests)
      {
        try
        {
          manifestCollection.Add(manifest, JsonConvert.DeserializeObject<Manifest>(File.ReadAllText(manifest)));
        }
        catch (Exception ex)
        {
          Console.WriteLine(manifest);
          Console.WriteLine(ex.InnerException?.Message);
        }
      }

      return manifestCollection;
    }
  }

}
