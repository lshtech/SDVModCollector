using System.Collections.Generic;

namespace SDVModCollector.Templates.BFAV
{
  public class CategoryObject
  {
    public string Action { get; set; }
    public string Category { get; set; }
    public IEnumerable<TypeObject> Types { get; set; }
    public IEnumerable<string> Buildings { get; set; }
    public AnimalShop AnimalShop { get; set; }
    public bool ForceRemoveFromShop { get; set; }
    public bool ForceOverrideTypes { get; set; }
    public bool ForceOverrideBuildings { get; set; }
    public bool ForceOverrideExclude { get; set; }
  }
}
