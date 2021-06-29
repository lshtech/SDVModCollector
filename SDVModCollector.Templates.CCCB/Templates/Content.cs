using System.Collections.Generic;

namespace SDVModCollector.Templates.CCCB.Templates
{
  public class Content : ITemplate
  {
    public Content(IDictionary<string, IDictionary<string, string>> contents)
    {
      Contents = contents;
    }
    public string Name { get; set; } = "ChallengingCommunityCenterBundles";
    public IDictionary<string, IDictionary<string, string>> Contents { get; set; }
  }
}
