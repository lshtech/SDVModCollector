using System.Windows;

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
      var collection = new Collection.Collection("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Stardew Valley\\Mods");
    }
  }
}
