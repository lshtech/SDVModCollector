using SDVModCollector.JSONScraper;

namespace SDVModCollector.Data
{
  public static class DataLoader
  {
    public static ModCollection LoadDataFromJson(string modDirectory)
    {
      return Scraper.Scrape(modDirectory);
    }
  }
}
