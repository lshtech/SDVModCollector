using System.Collections.Generic;
using System.IO;
using SDVModCollector.JSONHelper;
using SDVModCollector.Templates.MailFrameworkMod.Templates;

namespace SDVModCollector.Templates.MailFrameworkMod
{
  public class MailFrameworkMod : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      return ("MailFrameworkMod", new Mail(
        Helper.DeserializeObject<IEnumerable<MailItem>>(jsonPath)));
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return new[] { Path.Combine(modsPath, "mail.json") };
    }
  }
}
