using System.Collections.Generic;

namespace SDVModCollector.Templates.CCRM.Templates
{
  public class CloneData
  {
    public string Name { get; set; }
    public bool GetObjectBackOnChange { get; set; }
    public bool GetObjectBackImmediately { get; set; }
    public bool UsePfmForInput { get; set; }
    public IDictionary<string, int> CloningData { get; set; }
  }
}
