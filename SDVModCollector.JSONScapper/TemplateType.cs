using System.Collections.Generic;
using SDVModCollector.Templates;

namespace SDVModCollector.JSONScraper
{
  public class TemplateType
  {
    public TemplateType(string name)
    {
      Name = name;
      Templates = new Dictionary<string, ITemplate>();
    }
    public string Name { get; }

    public IDictionary<string, ITemplate> Templates { get; set; }
  }
}