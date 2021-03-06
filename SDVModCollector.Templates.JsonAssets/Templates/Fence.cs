using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Fence : ObjectAbstract
  {
    public enum ToolTypes
    {
      Axe,
      Pickaxe
    }

    public Dictionary<string, string> DescriptionLocalization { get; set; }

    public Dictionary<string, string> NameLocalization { get; set; }

    public string Description { get; set; }

    public int MaxHealth { get; set; } = 1;
    public object RepairMaterial { get; set; }
    public ToolTypes BreakTool { get; set; }
    public string PlacementSound { get; set; }
    public string RepairSound { get; set; }

    public int Price { get; set; }
    public Recipe Recipe { get; set; }

    public bool CanPurchase { get; set; } 
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } 
    public IList<string> PurchaseRequirements { get; set; } 
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } 

    public string FenceImage => GetImage("fence");
    public string ObjectImage => GetImage("object");
  }
}