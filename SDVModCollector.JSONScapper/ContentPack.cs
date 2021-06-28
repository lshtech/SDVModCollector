using System.Collections.Generic;
using SDVModCollector.Templates;

namespace SDVModCollector.JSONScraper
{
  public class ContentPack
  {
    public ContentPack(Manifest manifest)
    {
      Manifest = manifest;
      Types = new Dictionary<string, TemplateType>();
    }
    public Manifest Manifest { get; }
    public string Name => Manifest.Name;
    public string ModId => Manifest.UniqueId;
    public string PackType => Manifest.ContentPackFor.UniqueId;
    public IDictionary<string, TemplateType> Types { get; set; }

    public void Add((string type, ITemplate deserializedObject) item)
    {
      var (type, deserializedObject) = item;
      if (!Types.ContainsKey(type))
      {
        var newType = new TemplateType(type);
        Types.Add(type, newType);
      }
      Types[type].Templates.Add(deserializedObject.Name, deserializedObject);
    }
  }
}