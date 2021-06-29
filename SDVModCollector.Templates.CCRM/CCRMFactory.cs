using System;
using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.CCRM.Templates;

namespace SDVModCollector.Templates.CCRM
{
  public class CCRMFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("CustomCrystalariumMod", new ClonersData(Helper.DeserializeObject<IEnumerable<CloneData>>(jsonPath)));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "ClonersData.json") };
    }
  }
}
