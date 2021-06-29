using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.FarmTypeManager.Templates;

namespace SDVModCollector.Templates.FarmTypeManager
{
  public class FarmTypeManagerFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("FTM", Helper.DeserializeObject<Content>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
