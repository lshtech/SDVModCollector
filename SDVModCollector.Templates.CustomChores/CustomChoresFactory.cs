using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;

namespace SDVModCollector.Templates.CustomChores
{
  public class CustomChoresFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("CustomChores", Helper.DeserializeObject<Chore>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "chore.json") };
    }
  }
}
