using System.Collections.Generic;
using System.Drawing;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Crop : ObjectAbstract
  {
    public enum CropTypes
    {
      Normal,
      IndoorsOnly,
      Paddy
    }

    public Dictionary<string, string> SeedDescriptionLocalization { get; set; }

    public Dictionary<string, string> SeedNameLocalization { get; set; }
    public object Product { get; set; }
    public string SeedName { get; set; }
    public string SeedDescription { get; set; }
    public CropTypes CropType { get; set; } 

    public IList<string> Seasons { get; set; } 
    public IList<int> Phases { get; set; } 
    public int RegrowthPhase { get; set; } = -1;
    public bool HarvestWithScythe { get; set; }
    public bool TrellisCrop { get; set; }
    public IList<Color> Colors { get; set; } 
    public Bonus Bonus { get; set; }

    public IList<string> SeedPurchaseRequirements { get; set; }
    public int SeedPurchasePrice { get; set; }
    public int SeedSellPrice { get; set; } = -1;
    public string SeedPurchaseFrom { get; set; } 
    public IList<PurchaseData> SeedAdditionalPurchaseData { get; set; } 

    public string CropImage => GetImage("crop");
    public string GiantImage => GetImage("giant");
    public string SeedsImage => GetImage("seeds");

    
  }
}