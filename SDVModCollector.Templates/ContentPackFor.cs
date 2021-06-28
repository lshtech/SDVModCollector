namespace SDVModCollector.Templates
{
  public struct ContentPackFor
  {
    public string LowerUniqueId => UniqueId.ToLower();
    public string UniqueId { get; set; }
    public string MinimumVersion { get; set; }
  }
}