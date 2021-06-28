using System.Collections.Generic;

namespace SDVModCollector.JSONScraper
{
  public class ContentPack
  {
    public string Name;
    public Enums.Templates PackType;
    public IDictionary<string, IEnumerable<TemplateType>> Types =>
      new Dictionary<string, IEnumerable<TemplateType>>();
  }
}