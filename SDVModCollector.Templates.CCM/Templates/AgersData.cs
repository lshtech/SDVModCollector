
using System.Collections.Generic;

namespace SDVModCollector.Templates.CCM.Templates
{
  public class AgersData : ITemplate
  {
    public AgersData(IEnumerable<AgerCask> agerCasks)
    {
      AgerCasks = agerCasks;
    }

    public string Name { get; set; } = "Agers";
    public IEnumerable<AgerCask> AgerCasks { get; set; }
  }
}
