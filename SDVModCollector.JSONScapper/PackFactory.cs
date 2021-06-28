using System.Collections.Generic;
using SDVModCollector.Templates;
using SDVModCollector.Templates.BAGI;
using SDVModCollector.Templates.JsonAssets;

namespace SDVModCollector.JSONScraper
{
  public static class PackFactory
  {
    public static KeyValuePair<string, FactoryAbstract>? CreateTemplateFactory(this Manifest manifest)
    {
      switch (manifest.ContentPackFor.LowerUniqueId)
      {
        case Constants.BAGI:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.BAGI, new BAGIFactory());
        //case Constants.BFAV:
        //  return new KeyValuePair<string, FactoryAbstract>
        //    (Constants.BFAV, null);
        case Constants.JsonAssets:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.JsonAssets, new JsonAssetsFactory());
       
        default:
          return null;
      }
    }
  }
}
