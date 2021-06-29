using System.Collections.Generic;

namespace SDVModCollector.Templates.MillerTime.Templates
{
  public class Content :ITemplate
  {
    public Content(IEnumerable<Recipe> recipes)
    {
      Recipes = recipes;
    }

    public string Name { get; set; } = "MillerTime";
    public IEnumerable<Recipe> Recipes { get; set; }
  }
}
