using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets
{
  public class BigCraftable : ObjectAbstract
  {
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
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } = new List<PurchaseData>();

    public Dictionary<string, string> NameLocalization = new Dictionary<string, string>();
    public Dictionary<string, string> DescriptionLocalization = new Dictionary<string, string>();

    public string LocalizedName()
    {
      //var currLang = LocalizedContentManager.CurrentLanguageCode;
      ///*if (currLang == LocalizedContentManager.LanguageCode.en)
      //    return Name;*/
      //if (NameLocalization == null || !NameLocalization.ContainsKey(currLang.ToString()))
      //  return Name;
      return NameLocalization["en"];
    }

    public string LocalizedDescription()
    {
      //var currLang = LocalizedContentManager.CurrentLanguageCode;
      ///*if (currLang == LocalizedContentManager.LanguageCode.en)
      //    return Description;*/
      //if (DescriptionLocalization == null || !DescriptionLocalization.ContainsKey(currLang.ToString()))
      //  return Description;
      return DescriptionLocalization["en"];
    }

    public int GetCraftableId() { return id; }

    internal string GetCraftableInformation()
    {
      string str = $"{Name}/{Price}/-300/Crafting -9/{LocalizedDescription()}/true/true/0";
      if (ProvidesLight)
        str += "/true";
      str += $"/{LocalizedName()}";
      return str;
    }
  }
}
