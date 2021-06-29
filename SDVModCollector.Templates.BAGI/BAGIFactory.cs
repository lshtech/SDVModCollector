using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.BAGI.Templates;

// ReSharper disable IdentifierTypo

namespace SDVModCollector.Templates.BAGI
{
  public class BAGIFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("BetterArtisanGoodIcons", Helper.DeserializeObject<Data>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] {Path.Combine(modsPath, "data.json")};
    }
  }
}