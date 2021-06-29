using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.CCM.Templates;

namespace SDVModCollector.Templates.CCM
{
  public class CCMFactory: FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      if (jsonPath.ToLower().EndsWith("caskdata.json"))
        return ("Cask", new CaskData(Helper.DeserializeObject<IDictionary<string, double>>(jsonPath)));
      if (jsonPath.ToLower().EndsWith("agersdata.json"))
        return ("Agers", new AgersData(Helper.DeserializeObject<IEnumerable<AgerCask>>(jsonPath)));
      return (string.Empty, null);
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      var files = new List<string>();
      if (File.Exists(Path.Combine(modsPath, "CaskData.json")))
        files.Add(Path.Combine(modsPath, "CaskData.json"));
      if (File.Exists(Path.Combine(modsPath, "AgersData.json")))
        files.Add(Path.Combine(modsPath, "AgersData.json"));
      return files;
    }
  }
}
