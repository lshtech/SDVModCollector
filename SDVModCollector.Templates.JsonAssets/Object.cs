using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
namespace SDVModCollector.Templates.JsonAssets
{
  public class Object : ObjectAbstract
  {
    

    public string Description { get; set; }
    public string Category { get; set; }
    public string CategoryTextOverride { get; set; }
    public Color CategoryColorOverride { get; set; } = Color.FromArgb(0, 0, 0, 0);
    public bool IsColored { get; set; } = false;

    public int Price { get; set; }

    public bool CanTrash { get; set; } = true;
    public bool CanSell { get; set; } = true;
    public bool CanBeGifted { get; set; } = true;

    public bool HideFromShippingCollection { get; set; } = false;

    public Recipe Recipe { get; set; }

    public int Edibility { get; set; } = -300;
    public bool EdibleIsDrink { get; set; } = false;
    public FoodBuffs EdibleBuffs = new FoodBuffs();

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Pierre";
    public IList<string> PurchaseRequirements { get; set; } = new List<string>();
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } = new List<PurchaseData>();

    public class GiftTastes_
    {
      public IList<string> Love = new List<string>();
      public IList<string> Like = new List<string>();
      public IList<string> Neutral = new List<string>();
      public IList<string> Dislike = new List<string>();
      public IList<string> Hate = new List<string>();
    }
    public GiftTastes_ GiftTastes;

    public Dictionary<string, string> NameLocalization = new Dictionary<string, string>();
    public Dictionary<string, string> DescriptionLocalization = new Dictionary<string, string>();

    public List<string> ContextTags = new List<string>();

    //public string LocalizedName()
    //{
    //  var currLang = LocalizedContentManager.CurrentLanguageCode;
    //  /*if (currLang == LocalizedContentManager.LanguageCode.en)
    //      return Name;*/
    //  if (NameLocalization == null || !NameLocalization.ContainsKey(currLang.ToString()))
    //    return Name;
    //  return NameLocalization[currLang.ToString()];
    //}

    //public string LocalizedDescription()
    //{
    //  var currLang = LocalizedContentManager.CurrentLanguageCode;
    //  /*if (currLang == LocalizedContentManager.LanguageCode.en)
    //      return Description;*/
    //  if (DescriptionLocalization == null || !DescriptionLocalization.ContainsKey(currLang.ToString()))
    //    return Description;
    //  return DescriptionLocalization[currLang.ToString()];
    //}

    public int GetObjectId() { return id; }

    //internal string GetObjectInformation()
    //{
    //  if (Edibility != SObject.inedible)
    //  {
    //    var itype = (int)Category;
    //    var str = $"{Name}/{Price}/{Edibility}/" + (Category == Category_.Artifact ? "Arch" : $"{Category} {itype}") + $"/{LocalizedName()}/{LocalizedDescription()}/";
    //    str += (EdibleIsDrink ? "drink" : "food") + "/";
    //    if (EdibleBuffs == null)
    //      EdibleBuffs = new FoodBuffs();
    //    str += $"{EdibleBuffs.Farming} {EdibleBuffs.Fishing} {EdibleBuffs.Mining} 0 {EdibleBuffs.Luck} {EdibleBuffs.Foraging} 0 {EdibleBuffs.MaxStamina} {EdibleBuffs.MagnetRadius} {EdibleBuffs.Speed} {EdibleBuffs.Defense} {EdibleBuffs.Attack}/{EdibleBuffs.Duration}";
    //    return str;
    //  }
    //  else
    //  {
    //    var itype = (int)Category;
    //    return $"{Name}/{Price}/{Edibility}/" + (Category == Category_.Artifact ? "Arch" : $"Basic {itype}") + $"/{LocalizedName()}/{LocalizedDescription()}";
    //  }
    //}

  }
}
