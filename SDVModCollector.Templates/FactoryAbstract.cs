using System.Collections.Generic;

namespace SDVModCollector.Templates
{
  public abstract class FactoryAbstract : ITemplateFactory
  {
    public abstract (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath);

    public abstract IEnumerable<string> GetJsonFiles(string modsPath);
  }
}
