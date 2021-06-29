using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Hat : ObjectAbstract
  {
    public Dictionary<string, string> DescriptionLocalization { get; set; }

    public Dictionary<string, string> NameLocalization { get; set; }
    public string Description { get; set; }
    public int PurchasePrice { get; set; }
    public bool ShowHair { get; set; }
    public bool IgnoreHairstyleOffset { get; set; }

    public bool CanPurchase { get; set; }

    public string Metadata { get; set; }

    public string HatImage => GetImage("hat");
  }
}