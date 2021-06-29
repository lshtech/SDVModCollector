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
    public int ReserveExtraIndexCount { get; set; } = 0;
    public string Description { get; set; }

    public int Price { get; set; }

    public bool ProvidesLight { get; set; } = false;

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Pierre";
    public IList<string> PurchaseRequirements { get; set; } = new List<string>();
    public IList<PurchaseData> AdditionalPurchaseData { get; set; }

    public string BigCraftableImage => GetImage("big-craftable");

    public IEnumerable<string> ExtraImages => System.IO.Directory.EnumerateFiles(Directory, "big-craftable-*.png");

    public string TreeImage => GetImage("tree");
    public string SaplingImage => GetImage("sapling");
  }
}