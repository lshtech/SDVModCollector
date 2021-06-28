﻿using System.Collections.Generic;
using System.Drawing;

namespace SDVModCollector.Templates.JsonAssets
{
  public class Pants : ObjectAbstract
  {
    public string Description { get; set; }

    public int Price { get; set; }

    public Color DefaultColor { get; set; } = Color.FromArgb(255, 235, 203);
    public bool Dyeable { get; set; } = false;

    public string Metadata { get; set; } = "";

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

    public int GetClothingId() { return id; }
    //public int GetTextureIndex() { return textureIndex; }

    //internal string GetClothingInformation()
    //{
    //  return $"{Name}/{LocalizedName()}/{LocalizedDescription()}/{GetTextureIndex()}/-1/{Price}/{DefaultColor.R} {DefaultColor.G} {DefaultColor.B}/{Dyeable}/Pants/{Metadata}";
    //}
  }
}
