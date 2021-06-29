using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.TMXLoader.Templates;

namespace SDVModCollector.Templates.TMXLoader
{
  public class TMXLoaderFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("TMX", Helper.DeserializeObject<Content>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
