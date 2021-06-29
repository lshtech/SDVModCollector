using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.ContentPatcher.Templates;

namespace SDVModCollector.Templates.ContentPatcher
{
  public class ContentPatcherFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("ContentPatcher", Helper.DeserializeObject<Content>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
