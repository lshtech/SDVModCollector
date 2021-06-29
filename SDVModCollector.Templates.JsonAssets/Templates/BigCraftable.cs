using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class BigCraftable : ObjectAbstract
  {
    public Dictionary<string, string> DescriptionLocalization { get; set; }

    public Dictionary<string, string> NameLocalization { get; set; }
    public Recipe Recipe { get; set; }
    public bool ReserveNextIndex { get; set; } = false; // Deprecated
    public int ReserveExtraIndexCount { get; set; }
    public string Description { get; set; }

    public int Price { get; set; }

    public bool ProvidesLight { get; set; } 

    public bool CanPurchase { get; set; } 
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; }
    public IList<string> PurchaseRequirements { get; set; } 
    public IList<PurchaseData> AdditionalPurchaseData { get; set; }

    public string BigCraftableImage => GetImage("big-craftable");

    public IEnumerable<string> ExtraImages => System.IO.Directory.EnumerateFiles(Directory, "big-craftable-*.png");

    public string TreeImage => GetImage("tree");
    public string SaplingImage => GetImage("sapling");
  }
}