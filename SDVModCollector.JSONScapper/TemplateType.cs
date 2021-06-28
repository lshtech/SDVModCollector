using System.Collections.Generic;
using SDVModCollector.Templates.JsonAssets;

namespace SDVModCollector.JSONScraper
{
  public class TemplateType
  {
    public string Name { get; set; }

    public IDictionary<string, IEnumerable<ITemplate>> Templates =>
      new SortedDictionary<string, IEnumerable<ITemplate>>();
  }
}