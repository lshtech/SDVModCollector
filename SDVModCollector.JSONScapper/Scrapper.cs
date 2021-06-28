using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SDVModCollector.Templates;

namespace SDVModCollector.JSONScraper
{
  public static class Scraper
  {
    public static ModCollection Scrape(string modsPath)
    {
      var collection = new ModCollection(modsPath);
      var manifestCollection = GetManifests(modsPath);

      IDictionary<string, FactoryAbstract> factories = new Dictionary<string, FactoryAbstract>();
      foreach (var (modId, manifest) in manifestCollection)
      {
        if (manifest.ContentPackFor.UniqueId == null) continue;
        if (!factories.ContainsKey(manifest.ContentPackFor.LowerUniqueId))
        {
          var factory = manifest.CreateTemplateFactory();
          if (factory == null)
            continue;
          factories.Add((KeyValuePair<string, FactoryAbstract>) factory);
        }

        var files = factories[manifest.ContentPackFor.LowerUniqueId].GetJsonFiles(manifest.BaseDirectory);
        var contentPack = new ContentPack(manifest);
        foreach (var file in files)
        {
          try
          {
            contentPack.Add(factories[manifest.ContentPackFor.LowerUniqueId].CreateTemplate(manifest, file));
          }
          catch (Exception ex)
          {
            Debug.WriteLine($"Error parsing {file}");
          }
        }
        collection.ContentPacks.Add(contentPack);
      }

      return collection;
    }

    private static Dictionary<string, Manifest> GetManifests(string modsPath)
    {
      var manifests = Directory
        .EnumerateFiles(modsPath, "manifest.json", SearchOption.AllDirectories)
        .Where(f => !f.Contains($"{modsPath}\\."));
      var manifestCollection = new Dictionary<string, Manifest>();
      foreach (var manifest in manifests)
      {
        try
        {
          var manifestObject = JsonConvert
            .DeserializeObject<Manifest>(File.ReadAllText(manifest)
              .Replace('“', '"').Replace('”', '"'))
            .AddPath(manifest);
          manifestCollection.Add(manifestObject.UniqueId, manifestObject);
        }
        catch (Exception ex)
        {
          Debug.WriteLine(manifest);
          Debug.WriteLine(ex.InnerException?.Message);
        }
      }

      return manifestCollection;
    }

    private static Manifest AddPath(this Manifest item, string filePath)
    {
      item.FilePath = filePath;
      return item;
    }
  }

}
