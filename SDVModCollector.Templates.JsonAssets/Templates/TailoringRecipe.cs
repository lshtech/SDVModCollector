using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class TailoringRecipe : ObjectAbstract
  {
    private IList<object> _craftedItems;
    public IList<string> FirstItemTags { get; set; }
    public IList<string> SecondItemTags { get; set; }

    public bool ConsumeSecondItem { get; set; } 

    public IList<object> CraftedItems
    {
      get => _craftedItems;
      set
      {
        Name = value.FirstOrDefault()?.ToString();
        _craftedItems = value;
      }
    }

    public Color CraftedItemColor { get; set; } = Color.White;
  }
}