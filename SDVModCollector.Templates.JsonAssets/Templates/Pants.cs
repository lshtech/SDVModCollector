using System.Collections.Generic;
using System.Drawing;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Pants : ObjectAbstract
  {
    public Dictionary<string, string> DescriptionLocalization { get; set; }

    public Dictionary<string, string> NameLocalization { get; set; }
    public string Description { get; set; }

    public int Price { get; set; }

    public Color DefaultColor { get; set; } = Color.FromArgb(255, 235, 203);
    public bool Dyeable { get; set; }
    public string Metadata { get; set; }

    public string PantsImage => GetImage("pants");
  }
}