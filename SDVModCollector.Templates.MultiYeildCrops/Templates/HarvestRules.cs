using System.Collections.Generic;

namespace SDVModCollector.Templates.MultiYieldCrops.Templates
{
  public class HarvestRules : ITemplate
  {
    public string Name { get; set; } = "MYC";
    public IEnumerable<Harvest> Harvests { get; set; }
  }
}
