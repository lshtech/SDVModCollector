using SDVModCollector.Data.SQLite;
using SDVModCollector.JSONScraper;

namespace SDVModCollector.Data
{
  public static class DataLoader
  {
    public static ModCollection LoadDataFromJson(string modDirectory)
    {
      SqlController.PrepDatabase();
      return null;
      //return Scraper.Scrape(modDirectory);
    }
  }
}
