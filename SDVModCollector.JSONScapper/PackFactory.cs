using System.Collections.Generic;
using SDVModCollector.Templates;
using SDVModCollector.Templates.BAGI;
using SDVModCollector.Templates.BFAV;
using SDVModCollector.Templates.CCCB;
using SDVModCollector.Templates.CCM;
using SDVModCollector.Templates.CCRM;
using SDVModCollector.Templates.ContentPatcher;
using SDVModCollector.Templates.CustomChores;
using SDVModCollector.Templates.CustomMusic;
using SDVModCollector.Templates.FarmTypeManager;
using SDVModCollector.Templates.JsonAssets;
using SDVModCollector.Templates.MailFrameworkMod;
using SDVModCollector.Templates.MillerTime;
using SDVModCollector.Templates.MoreGrass;
using SDVModCollector.Templates.MultiYieldCrops;
using SDVModCollector.Templates.ProducerFrameworkMod;
using SDVModCollector.Templates.QuestFramework;
using SDVModCollector.Templates.ShopTileFramework;
using SDVModCollector.Templates.TMXLoader;
using SDVModCollector.Templates.TrainStation;

namespace SDVModCollector.JSONScraper
{
  public static class PackFactory
  {
    public static KeyValuePair<string, FactoryAbstract>? CreateTemplateFactory(this Manifest manifest)
    {
      switch (manifest.ContentPackFor.LowerUniqueId)
      {
        case Constants.BetterArtisanGoodIcons:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.BetterArtisanGoodIcons, new BAGIFactory());
        case Constants.BetterFarmAnimalVariety:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.BetterFarmAnimalVariety, new BFAVFactory());
        case Constants.ChallengingCommunityCenterBundles:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.ChallengingCommunityCenterBundles, new CCCBFactory());
        case Constants.CustomCaskMod:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomCaskMod, new CCMFactory());
        case Constants.CustomCrystalariumMod:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomCrystalariumMod, new CCRMFactory());
        case Constants.ContentPatcher:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.ContentPatcher, new ContentPatcherFactory());
        case Constants.CustomChores:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomChores, new CustomChoresFactory());
        case Constants.CustomMusic:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.CustomMusic, new CustomMusicFactory());
        case Constants.FarmTypeManager:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.FarmTypeManager, new FarmTypeManagerFactory());
        case Constants.JsonAssets:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.JsonAssets, new JsonAssetsFactory());
        case Constants.MailFrameworkMod:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.MailFrameworkMod, new MailFrameworkMod());
        case Constants.MillerTime:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.MillerTime, new MillerTimeFactory());
        case Constants.MoreGrass:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.MoreGrass, new MoreGrassFactory());
        case Constants.MultiYieldCrops:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.MultiYieldCrops, new MultiYieldCropsFactory());
        case Constants.ProducerFrameworkMod:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.ProducerFrameworkMod, new ProducerFrameworkModFactory());
        case Constants.QuestFramework:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.QuestFramework, new QuestFrameworkFactory());
        case Constants.ShopTileFramework:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.ShopTileFramework, new ShopTileFrameworkFactory());
        case Constants.TMXLoader:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.TMXLoader, new TMXLoaderFactory());
        case Constants.TrainStation:
          return new KeyValuePair<string, FactoryAbstract>
            (Constants.TrainStation, new TrainStationFactory());
        default:
          return null;
      }
    }
  }
}
