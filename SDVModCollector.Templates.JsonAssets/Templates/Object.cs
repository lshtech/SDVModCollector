using System.Collections.Generic;
using System.Drawing;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Object : ObjectAbstract
  {
    public List<string> ContextTags { get; set; }
    public Dictionary<string, string> DescriptionLocalization { get; set; }
    public FoodBuffs EdibleBuffs { get; set; }


    public GiftTastes GiftTastes;

    public Dictionary<string, string> NameLocalization { get; set; }


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

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Pierre";
    public IList<string> PurchaseRequirements { get; set; } 
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } 

    public string ObjectImage => GetImage("object");
    public string ColorImage => GetImage("color");
  }
}