using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets.Templates.Shared;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Weapon : ObjectAbstract
  {
    public Dictionary<string, string> DescriptionLocalization { get; set; }

    public Dictionary<string, string> NameLocalization { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }

    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }
    public double Knockback { get; set; }
    public int Speed { get; set; }
    public int Accuracy { get; set; }
    public int Defense { get; set; }
    public int MineDropVar { get; set; }
    public int MineDropMinimumLevel { get; set; }
    public int ExtraSwingArea { get; set; }
    public double CritChance { get; set; }
    public double CritMultiplier { get; set; }

    public bool CanPurchase { get; set; } = false;
    public int PurchasePrice { get; set; }
    public string PurchaseFrom { get; set; } = "Pierre";
    public IList<string> PurchaseRequirements { get; set; }
    public IList<PurchaseData> AdditionalPurchaseData { get; set; }

    public bool CanTrash { get; set; } = true;

    public string WeaponImage => GetImage("weapon");
  }
}