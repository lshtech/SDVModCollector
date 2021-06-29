using System.Collections.Generic;

namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class BuildableEdit
  {
    public string id { get; set; }
    public string indoorsFile { get; set; }
    public IEnumerable<TileShopItem> buildItems { get; set; }
    public string iconFile { get; set; }
    public IEnumerable<int> exitTile { get; set; }
    public string set { get; set; } 
    public int price { get; set; }
    
    public IEnumerable<string> tags { get; set; } 

    public IDictionary<string, BuildableTranslation> translations { get; set; } 
  }
}