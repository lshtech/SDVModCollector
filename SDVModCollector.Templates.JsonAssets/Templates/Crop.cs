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

    public Dictionary<string, string> SeedDescriptionLocalization = new();

    public Dictionary<string, string> SeedNameLocalization = new();
    public object Product { get; set; }
    public string SeedName { get; set; }
    public string SeedDescription { get; set; }
    public CropTypes CropType { get; set; } = CropTypes.Normal;

    public IList<string> Seasons { get; set; } = new List<string>();
    public IList<int> Phases { get; set; } = new List<int>();
    public int RegrowthPhase { get; set; } = -1;
    public bool HarvestWithScythe { get; set; } = false;
    public bool TrellisCrop { get; set; } = false;
    public IList<Color> Colors { get; set; } = new List<Color>();
    public Bonus_ Bonus { get; set; } = null;

    public IList<string> SeedPurchaseRequirements { get; set; }
    public int SeedPurchasePrice { get; set; }
    public int SeedSellPrice { get; set; } = -1;
    public string SeedPurchaseFrom { get; set; } = "Pierre";
    public IList<PurchaseData> SeedAdditionalPurchaseData { get; set; } 

    public string CropImage => GetImage("crop");
    public string GiantImage => GetImage("giant");
    public string SeedsImage => GetImage("seeds");

    public class Bonus_
    {
      public int MinimumPerHarvest { get; set; }
      public int MaximumPerHarvest { get; set; }
      public int MaxIncreasePerFarmLevel { get; set; }
      public double ExtraChance { get; set; }
    }
  }
}