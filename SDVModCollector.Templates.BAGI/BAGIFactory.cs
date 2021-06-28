using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// ReSharper disable IdentifierTypo

namespace SDVModCollector.Templates.BAGI
{
  public class BAGIFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("BAGI", JsonConvert.DeserializeObject<Data>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] {Path.Combine(modsPath, "data.json")};
    }
  }
}