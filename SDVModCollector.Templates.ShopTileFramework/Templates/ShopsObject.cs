using System.Collections.Generic;

namespace SDVModCollector.Templates.ShopTileFramework.Templates
{
  public class ShopsObject : ITemplate
  {
    public string Name { get; set; } = "ShopTileFramework";
    public IEnumerable<string> RemovePackRecipesFromVanilla { get; set; }
    public IEnumerable<Shop> VanillaShops { get; set; }
    public IEnumerable<Shop> Shops { get; set; }
  }
}