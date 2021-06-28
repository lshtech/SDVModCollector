using System.Windows;
using SDVModCollector.JSONScraper;

namespace SDVModCollector
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      var collection = Scraper.Scrape(("y:\\"));
      var x = collection;
    }
  }
}
