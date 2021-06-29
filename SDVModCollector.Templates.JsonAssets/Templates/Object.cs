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
    public bool IsColored { get; set; }

    public int Price { get; set; }

    public bool CanTrash { get; set; } 
    public bool CanSell { get; set; }
    public bool CanBeGifted { get; set; } 

    public bool HideFromShippingCollection { get; set; }

    public Recipe Recipe { get; set; }

 
    public int Edibility { get; set; } = -300;
    public bool EdibleIsDrink { get; set; } 
    public bool CanPurchase { get; set; } 
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } 
    public IList<string> PurchaseRequirements { get; set; } 
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } 

    public string ObjectImage => GetImage("object");
    public string ColorImage => GetImage("color");
  }
}