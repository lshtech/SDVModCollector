using System.Collections.Generic;

namespace SDVModCollector.Templates.CCRM.Templates
{
  public class ClonersData : ITemplate
  {
    public ClonersData(IEnumerable<CloneData> cloneData)
    {
      CloneData = cloneData;
    }

    public string Name { get; set; } = "CCRM";
    public IEnumerable<CloneData> CloneData { get; set; }
  }
}
