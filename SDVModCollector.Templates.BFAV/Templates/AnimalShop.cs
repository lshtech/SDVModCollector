using System.Collections.Generic;

namespace SDVModCollector.Templates.BFAV.Templates
{
  public class AnimalShop
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Icon { get; set; }
    public IEnumerable<string> Exclude { get; set; }
  }
}
