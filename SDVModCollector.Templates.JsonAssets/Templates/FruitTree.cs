using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class FruitTree : ObjectAbstract
  {
    internal Object sapling;
    public Dictionary<string, string> SaplingDescriptionLocalization = new();

    public Dictionary<string, string> SaplingNameLocalization = new();
    public object Product { get; set; }
    public string SaplingName { get; set; }
    public string SaplingDescription { get; set; }

    public string Season { get; set; }

    public IList<string> SaplingPurchaseRequirements { get; set; } 
    public int SaplingPurchasePrice { get; set; }
    public string SaplingPurchaseFrom { get; set; } = "Pierre";
    public IList<PurchaseData> SaplingAdditionalPurchaseData { get; set; }
  }
}