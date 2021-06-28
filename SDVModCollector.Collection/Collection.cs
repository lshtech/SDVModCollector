using System.Collections.Generic;
using SDVModCollector.JSONScraper;

namespace SDVModCollector.Collection
{
  public class Collection
  {
    public string ModPacks { get; }
    public Collection(string path)
    {
      ModPacks = path;
      Scraper.Scrape(ModPacks);
      ;
    }

    public IDictionary<string, IEnumerable<ContentPack>> Packs =>
      new Dictionary<string, IEnumerable<ContentPack>>();
  }


}
