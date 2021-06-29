using System.Collections.Generic;
using SDVModCollector.Templates;
using SDVModCollector.Templates.BAGI;
using SDVModCollector.Templates.BFAV;
using SDVModCollector.Templates.CCCB;
using SDVModCollector.Templates.CCM;
using SDVModCollector.Templates.CCRM;
using SDVModCollector.Templates.CustomChores;
using SDVModCollector.Templates.CustomMusic;
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
        case Constants.BFAV:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.BFAV, new BFAVFactory());
        case Constants.CCCB:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CCCB, new CCCBFactory());
        case Constants.CCM:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CCM, new CCMFactory());
        case Constants.CCRM:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CCRM, new CCRMFactory());
        case Constants.CustomChores:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomChores, new CustomChoresFactory());
        case Constants.CustomMusic:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomMusic, new CustomMusicFactory());
        case Constants.JsonAssets:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.JsonAssets, new JsonAssetsFactory());
       
        default:
          return null;
      }
    }
  }
}
