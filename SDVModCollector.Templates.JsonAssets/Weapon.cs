﻿using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets
{
  public class Weapon : ObjectAbstract
  {
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
    public IList<string> PurchaseRequirements { get; set; } = new List<string>();
    public IList<PurchaseData> AdditionalPurchaseData { get; set; } = new List<PurchaseData>();

    public bool CanTrash { get; set; } = true;

    public Dictionary<string, string> NameLocalization = new Dictionary<string, string>();
    public Dictionary<string, string> DescriptionLocalization = new Dictionary<string, string>();

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

    public int GetWeaponId() { return id; }

    //internal string GetWeaponInformation()
    //{
    //  return $"{Name}/{LocalizedDescription()}/{MinimumDamage}/{MaximumDamage}/{Knockback}/{Speed}/{Accuracy}/{Defense}/{(int)Type}/{MineDropVar}/{MineDropMinimumLevel}/{ExtraSwingArea}/{CritChance}/{CritMultiplier}/{LocalizedName()}";
    //}
  }
}
