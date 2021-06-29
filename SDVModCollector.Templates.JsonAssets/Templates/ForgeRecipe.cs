namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class ForgeRecipe : ObjectAbstract
  {
    private string _resultItemName;
    public string BaseItemName { get; set; } 
    public string IngredientContextTag { get; set; }
    public int CinderShardCost { get; set; }

    public string ResultItemName
    {
      get => _resultItemName;
      set
      {
        Name = value;
        _resultItemName = value;
      }
    }

    public string[] AbleToForgeConditions { get; set; }
  }
}