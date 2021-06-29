using System.Collections.Generic;

namespace SDVModCollector.Templates.MoreGrass.Templates
{
  public class Config : ITemplate
  {
    public string Name { get; set; } = "MG";
    public bool EnableDefaultGrass { get; set; } = true;
    public IDictionary<string, IEnumerable<string>> WhiteListedGrass { get; set; } 
    public IDictionary<string, IEnumerable<string>> BlackListedGrass { get; set; } 
    public IEnumerable<string> WhiteListedLocations { get; set; } 
    public IEnumerable<string> BlackListedLocations { get; set; } 
  }
}
