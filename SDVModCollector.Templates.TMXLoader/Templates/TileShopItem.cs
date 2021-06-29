namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class TileShopItem
  {
    public int index { get; set; }
    public string type { get; set; } 
    public string name { get; set; }
    public int stock { get; set; } 

    public int stack { get => stock; set => stock = value; }
    public int price { get; set; } 
    public string conditions { get; set; }
  }
}