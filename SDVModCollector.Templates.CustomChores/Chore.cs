namespace SDVModCollector.Templates.CustomChores
{
  public class Chore : ITemplate
  {
    public string Name
    {
      get => ChoreType;
      set { }
    }

    public string ChoreType { get; set; }
    public string GiftType { get; set; }
    public bool EnableUniversal { get; set; }
    public double ChanceForLove { get; set; }
    public bool EnableBarns { get; set; }
    public bool EnableCoops { get; set; }
    public bool FillWaterBowl { get; set; }
    public bool EnablePetting { get; set; }
    public bool EnableFarm { get; set; }
    public bool EnableGreenhouse { get; set; }
    public string Image => "\\assets\\image.png";
  }
}
