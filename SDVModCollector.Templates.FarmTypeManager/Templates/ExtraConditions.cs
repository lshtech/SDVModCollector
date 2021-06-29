using System.Collections.Generic;
using System.Net;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class ExtraConditions
  {
    public IEnumerable<string> Years { get; set; }
    public IEnumerable<string> Seasons { get; set; }
    public IEnumerable<string> Days { get; set; }
    public IEnumerable<string> WeatherYesterday { get; set; }
    public IEnumerable<string> WeatherToday { get; set; }
    public IEnumerable<string> WeatherTomorrow { get; set; }
    public IEnumerable<string> EPUPreconditions { get; set; }
    public int? LimitedNumberOfSpawns { get; set; }
  }
}