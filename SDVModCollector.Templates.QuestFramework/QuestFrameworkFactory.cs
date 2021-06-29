using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.QuestFramework.Templates;

namespace SDVModCollector.Templates.QuestFramework
{
  public class QuestFrameworkFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("QuestFramework", Helper.DeserializeObject<QuestsConfig>(jsonPath));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "quests.json") };
    }
  }
}
