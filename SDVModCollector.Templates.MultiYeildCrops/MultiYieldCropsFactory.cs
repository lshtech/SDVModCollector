using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.MultiYieldCrops.Templates;

namespace SDVModCollector.Templates.MultiYieldCrops
{
  public class MultiYieldCropsFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("MYC", Helper.DeserializeObject<HarvestRules>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "HarvestRules.json") };
    }
  }
}
