using System.Collections.Generic;
using System.Drawing;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class TailoringRecipe : ObjectAbstract
  {
    public IList<string> FirstItemTags { get; set; }
    public IList<string> SecondItemTags { get; set; }

    public bool ConsumeSecondItem { get; set; } = true;

    public IList<object> CraftedItems { get; set; }
    public Color CraftedItemColor { get; set; } = Color.White;
  }
}