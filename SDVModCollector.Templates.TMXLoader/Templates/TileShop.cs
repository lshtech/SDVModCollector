using System.Collections.Generic;

namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class TileShop
  {
    public string id { get; set; } 
    public IEnumerable<TileShopItem> inventory { get; set; } 
    public string inventoryId { get; set; }
    public IEnumerable<string> portraits { get; set; } 
  }
}