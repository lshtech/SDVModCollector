using System.Collections.Generic;

namespace SDVModCollector.JSONScraper
{
  public class ModCollection
  {
    public ModCollection(string path)
    {
      Path = path;
      ContentPacks = new List<ContentPack>();
    }
    public string Path { get; }
    public IList<ContentPack> ContentPacks { get; set; } 
  }
}
