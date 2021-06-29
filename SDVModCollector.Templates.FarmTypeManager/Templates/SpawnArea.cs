namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public abstract class SpawnArea
  {
    public string UniqueAreaID { get; set; } 
    public string MapName { get; set; } 
    public int MinimumSpawnsPerDay { get; set; }
    public int MaximumSpawnsPerDay { get; set; }

    public string[] AutoSpawnTerrainTypes 
    {
      set => IncludeTerrainTypes = value;
    }
    
    public string[] IncludeTerrainTypes { get; set; }
    
    public string[] ExcludeTerrainTypes { get; set; }

    public string[] IncludeAreas 
    {
      set => IncludeCoordinates = value;
    }
    
    public string[] IncludeCoordinates { get; set; }
    public string[] ExcludeAreas 
    {
      set => ExcludeCoordinates = value;
    }
    
    public string[] ExcludeCoordinates { get; set; }

    public string StrictTileChecking { get; set; } 
    
    public SpawnTiming SpawnTiming { get; set; }

    private ExtraConditions extraConditions = new ExtraConditions();
    public ExtraConditions ExtraConditions { get; set; }

    public int? DaysUntilSpawnsExpire { get; set; } 

  }
}