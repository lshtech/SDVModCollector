using System;
using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;

namespace SDVModCollector.Templates.TrainStation
{
  public class TrainStationFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("TrainStation", Helper.DeserializeObject<Templates.TrainStation>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "TrainStops.json") };
    }
  }
}
