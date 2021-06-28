namespace SDVModCollector.Templates
{
  public interface ITemplateFactory
  {
    (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath);
  }
}
