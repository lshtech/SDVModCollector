// ReSharper disable IdentifierTypo

using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.BFAV.Templates;

namespace SDVModCollector.Templates.BFAV
{
  public class BFAVFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("BAFV", Helper.DeserializeObject<Content>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
