using SDVModCollector.Templates;
using SDVModCollector.Templates.JsonAssets;

namespace SDVModCollector.JSONScraper
{
  public static class PackFactory
  {
    public static ITemplateFactory CreateTemplateFactory(this Templates.Manifest manifest)
    {
      switch (manifest.ContentPackFor.UniqueId)
      {
        case Constants.JsonAssets:
          return new JsonAssetsFactory();
        default:
          return null;
      }
    }
  }
}
