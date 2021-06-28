using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Boots : ObjectAbstract
  {
    public Dictionary<string, string> DescriptionLocalization = new();

    public Dictionary<string, string> NameLocalization = new();
    public string Description { get; set; }

    public int Price { get; set; }

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Marlon";
    public IList<string> PurchaseRequirements { get; set; }
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } 

    public int Defense { get; set; }
    public int Immunity { get; set; }

    public string BootsImage => GetImage("boots");
    public string ColorImage => GetImage("color");
  }
}