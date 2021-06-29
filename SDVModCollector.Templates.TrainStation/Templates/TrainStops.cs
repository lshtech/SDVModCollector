using System.Collections.Generic;

namespace SDVModCollector.Templates.TrainStation.Templates
{
  public class TrainStation : ITemplate
  {
    public string Name { get; set; } = "TS";
    public IEnumerable<Stop> BoatStops { get; set; }
    public IEnumerable<Stop> TrainStops { get; set; }
  }
}
