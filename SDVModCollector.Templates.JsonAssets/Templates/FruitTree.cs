using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class FruitTree : ObjectAbstract
  {
    public Dictionary<string, string> SaplingDescriptionLocalization { get; set; }

    public Dictionary<string, string> SaplingNameLocalization { get; set; }
    public object Product { get; set; }
    public string SaplingName { get; set; }
    public string SaplingDescription { get; set; }

    public string Season { get; set; }

    public IList<string> SaplingPurchaseRequirements { get; set; } 
    public int SaplingPurchasePrice { get; set; }
    public string SaplingPurchaseFrom { get; set; }
    public IList<PurchaseData> SaplingAdditionalPurchaseData { get; set; }
  }
}