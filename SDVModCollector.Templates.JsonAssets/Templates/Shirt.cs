namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public class Shirt : Clothing
  {
    public string MaleImage => GetImage("male");
    public string MaleColorImage => GetImage("male-color");
    public string FemaleImage => GetImage("female");
    public string FemaleColorImage => GetImage("female-color");
  }
}