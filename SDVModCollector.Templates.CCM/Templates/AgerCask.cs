using System.Collections.Generic;

namespace SDVModCollector.Templates.CCM.Templates
{
  public class AgerCask
  {
    public string Name { get; set; }
    public bool EnableAgingAnywhere { get; set; }
    public bool EnableMoreThanOneQualityIncrementPerDay { get; set; }
    public IDictionary<string, double> AgingData { get; set; }
  }
}
