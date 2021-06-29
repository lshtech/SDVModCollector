using System.Collections.Generic;

namespace SDVModCollector.Templates.ShopTileFramework.Templates
{
  public class Item
  {
    public int StockPrice { get; set; }
    public string ItemType { get; set; }
    public IEnumerable<string> ItemNames { get; set; }
    public IEnumerable<string> When { get; set; }
    public int Strock { get; set; }
    public int MaxNumItemsSoldInItemStock { get; set; }
    public IEnumerable<int> ItemIDs { get; set; }
    public bool IsRecipe { get; set; }
    public IEnumerable<string> JAPacks { get; set; }
  }
}
