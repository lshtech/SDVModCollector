using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.CCCB.Templates;

namespace SDVModCollector.Templates.CCCB
{
  public class CCCBFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("CCCB", new Content(
        Helper.DeserializeObject<IDictionary<string, IDictionary<string, string>>>(jsonPath)));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
