namespace SDVModCollector.Templates
{
  public interface ITemplateFactory
  {
    ITemplate CreateTemplate(Manifest manifest, string jsonPath);
  }
}
