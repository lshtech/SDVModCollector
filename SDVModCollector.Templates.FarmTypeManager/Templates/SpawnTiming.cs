namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class SpawnTiming
  {
    public int? StartTime { get; set; }
    public int? EndTime { get; set; }
    public int? MinimumTimeBetweenSpawns { get; set; }
    public int? MaximumSimultaneousSpawns { get; set; }
    public bool OnlySpawnIfAPlayerIsPresent { get; set; }
    public string SpawnSound { get; set; }
  }
}