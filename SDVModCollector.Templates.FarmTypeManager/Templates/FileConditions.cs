using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class FileConditions
  {
    public IEnumerable<object> FarmTypes { get; set; }
    public IEnumerable<string> FarmerNames { get; set; }
    public IEnumerable<string> SaveFileNames { get; set; }
    public IDictionary<string, bool> OtherMods { get; set; }
  }
}