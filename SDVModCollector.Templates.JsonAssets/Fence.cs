using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets
{
  public class Fence : ObjectAbstract
  {
    public enum ToolTypes
    {
      Axe,
      Pickaxe,
    }

    public string Description { get; set; }

    public int MaxHealth { get; set; } = 1;
    public object RepairMaterial { get; set; }
    public ToolTypes BreakTool { get; set; }
    public string PlacementSound { get; set; }
    public string RepairSound { get; set; }

    public int Price { get; set; }
    public Recipe Recipe { get; set; }

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Robin";
    public IList<string> PurchaseRequirements { get; set; } = new List<string>();
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } = new List<PurchaseData>();

    public Dictionary<string, string> NameLocalization = new Dictionary<string, string>();
    public Dictionary<string, string> DescriptionLocalization = new Dictionary<string, string>();

    public int GetObjectId() { return id; }
  }
}
