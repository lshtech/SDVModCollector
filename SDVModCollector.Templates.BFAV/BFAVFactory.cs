// ReSharper disable IdentifierTypo

using System.Collections.Generic;
using System.IO;

namespace SDVModCollector.Templates.BFAV
{
  public class BFAVFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      throw new System.NotImplementedException();
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "content.json") };
    }
  }
}
