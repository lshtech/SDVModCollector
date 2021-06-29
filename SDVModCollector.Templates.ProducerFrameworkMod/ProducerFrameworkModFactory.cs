using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.ProducerFrameworkMod.Templates;

namespace SDVModCollector.Templates.ProducerFrameworkMod
{
  public class ProducerFrameworkModFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      if (jsonPath.ToLower().EndsWith("producerrules.json"))
        return ("Rule", new ProducerRules(Helper.DeserializeObject<IEnumerable<ProducerRule>>(jsonPath)));
      if (jsonPath.ToLower().EndsWith("producersconfig.json"))
        return ("Machine", new ProducersConfig(Helper.DeserializeObject<IEnumerable<Producer>>(jsonPath)));
      return (string.Empty, null);
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      var files = new List<string>();
      if (File.Exists(Path.Combine(modsPath, "ProducerRules.json")))
        files.Add(Path.Combine(modsPath, "ProducerRules.json"));
      if (File.Exists(Path.Combine(modsPath, "ProducersConfig.json")))
        files.Add(Path.Combine(modsPath, "ProducersConfig.json"));
      return files;
    }
  }
}
