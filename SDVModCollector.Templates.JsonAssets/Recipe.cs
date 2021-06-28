using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets
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

    internal string GetRecipeString(BigCraftable parent)
    {
      var str = "";
      //foreach (var ingredient in Ingredients)
      //  str += Mod.instance.ResolveObjectId(ingredient.Object) + " " + ingredient.Count + " ";
      //str = str.Substring(0, str.Length - 1);
      //str += $"/what is this for?/{parent.id} {ResultCount}/true/";
      //if (SkillUnlockName?.Length > 0 && SkillUnlockLevel > 0)
      //  str += SkillUnlockName + " " + SkillUnlockLevel;
      //else
      //  str += "null";
      //if (LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en)
      //  str += "/" + parent.LocalizedName();
      return str;
    }
  }
}