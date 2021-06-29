using System.Collections.Generic;

namespace SDVModCollector.Templates.MultiYieldCrops.Templates
{
  public class Harvest
  {
    public string CropName { get; set; }
    public IEnumerable<HarvestRule> HarvestRules { get; set; }
  }
}