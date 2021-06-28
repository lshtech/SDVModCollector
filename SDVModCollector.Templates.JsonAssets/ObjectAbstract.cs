
namespace SDVModCollector.Templates.JsonAssets
{
  public abstract class ObjectAbstract : ITemplate
  {
    public string Name { get; set; }

    public string EnableWithMod { get; set; }
    public string DisableWithMod { get; set; }

    internal int id = -1;
  }
}