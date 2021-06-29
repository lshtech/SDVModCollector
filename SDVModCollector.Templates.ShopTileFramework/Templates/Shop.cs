using System.Collections.Generic;

namespace SDVModCollector.Templates.ShopTileFramework.Templates
{
  public class Shop
  {
    public string ShopName { get; set; }
    public bool AddStockAboveVanilla { get; set; }
    public IEnumerable<Item> ItemStock { get; set; }
    public IDictionary<string, string> PriceMultiplicationWhen { get; set; }
    public IEnumerable<int> CategoriesToSellHere { get; set; }
    public string StoreCurrency { get; set; }
    public string PortraitPath { get; set; }
    public string Quote { get; set; }
    public IDictionary<string, string> LocalizedQuote { get; set; }
    public int MaxNumItemsSoldInStore { get; set; }
    public IEnumerable<string> When { get; set; }
    public string ClosedMessage { get; set; }
    public IDictionary<string, string> LocalizedClosedMessage { get; set; }
  }
}