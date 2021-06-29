using System.Collections.Generic;

namespace SDVModCollector.Templates.TrainStation.Templates
{
  public class Stop
  {
    public string TargetMapName { get; set; }
    public IDictionary<string, string> LocalizedDisplayName { get; set; }

    public int TargetX { get; set; }
    public int TargetY { get; set; }
    public int Cost { get; set; } = 0;
    public int FacingDirectionAfterWarp { get; set; } = 2;
    public IEnumerable<string> Conditions { get; set; }
  }
}