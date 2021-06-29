using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.ShopTileFramework.Templates;

namespace SDVModCollector.Templates.ShopTileFramework
{
  public class ShopTileFrameworkFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("STF", Helper.DeserializeObject<ShopsObject>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "shops.json") };
    }
  }
}
