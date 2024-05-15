using System.Windows;
using System.Windows.Controls;

namespace KitchenTimer2.Windows
{
    public interface IParentWindow
    {
        TextBlock TimeTextBlock { get; }
        string TitleString { get; set; }
        void ShowSettingsWindow(object sender, RoutedEventArgs e);
    }
}
