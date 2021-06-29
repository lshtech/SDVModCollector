using System.Windows;
using SDVModCollector.Data;

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
      //var collection = Scraper.Scrape("Y:");
      var collection = new DataViewModel("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Stardew Valley\\Mods");
      var x = collection;
    }
  }
}
