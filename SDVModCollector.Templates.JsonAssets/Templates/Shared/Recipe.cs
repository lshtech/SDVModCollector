using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets.Templates.Shared
{
  public class Recipe
  {
    public string SkillUnlockName { get; set; } = null;
    public int SkillUnlockLevel { get; set; } = -1;
    public int ResultCount { get; set; } = 1;
    public IList<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public bool IsDefault { get; set; } = false;
    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Gus";
    public IList<string> PurchaseRequirements { get; set; } = new List<string>();
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } = new List<PurchaseData>();
  }
}