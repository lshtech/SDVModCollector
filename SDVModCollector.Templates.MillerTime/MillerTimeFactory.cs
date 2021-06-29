using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.MillerTime.Templates;

namespace SDVModCollector.Templates.MillerTime
{
  public class MillerTimeFactory: FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("MillerTime", new Content(
        Helper.DeserializeObject<IEnumerable<Recipe>>(jsonPath)));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
