using System;
using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.MoreGrass.Templates;

namespace SDVModCollector.Templates.MoreGrass
{
  public class MoreGrassFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("MoreGrass", Helper.DeserializeObject<Config>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "config.json") };
    }
  }
}
