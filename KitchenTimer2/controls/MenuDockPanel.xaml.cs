using KitchenTimer.Windows;
using KitchenTimer2.Resx;
using KitchenTimer2.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KitchenTimer.controls
{
    /// <summary>
    /// Interaction logic for MenuDockPanel.xaml
    /// </summary>
    public partial class MenuDockPanel : UserControl
    {
        public MenuDockPanel()
        {
            InitializeComponent();
        }

        public IParentWindow ParentWindow { get; set; }

        private bool _showSettingsMenuItem = true;
        public bool ShowSettingsMenuItem
        {
            get 
            {
                return _showSettingsMenuItem;
            }
            set
            {
                if (!value)
                {
                    this.mniShowSettings.Visibility = Visibility.Collapsed;
                }
                else
                {
                    this.mniShowSettings.Visibility = Visibility.Visible;
                }
            }
        }
        /// <summary>
        /// Show the settings window, change settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSettingsWindow(object sender, RoutedEventArgs e)
        {
            ParentWindow.ShowSettingsWindow(sender, e);
        }

        /// <summary>
        /// Handle show about window menu call.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowAboutWindow(object sender, RoutedEventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        /// <summary>
        /// Handle exit menu call.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShutdownApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_StopWatchWindow_Click(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            if (app == null)
            {
                MessageBox.Show(Strings2.TroubleGettingApplicationObject);
                return;
            }
            var mainWin = new StopWatchWindow(++app.NewStopWatchWindowCounter);
            mainWin.Show();
        }

        private void MenuItem_RenameTimer_Click(object sender, RoutedEventArgs e)
        {
            var renameWindow = new RenameWindowTitleWindow(ParentWindow.TitleString);
            bool? result = renameWindow.ShowDialog();
            if (result ?? false)
            {
                var newTitle = renameWindow.TimerName;
                if (!string.IsNullOrWhiteSpace(newTitle))
                {
                    ParentWindow.TitleString = newTitle;
                }
            }
        }


        private void RedColorOption_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.TimeTextBlock.Foreground = Brushes.Red;
            e.Handled = true;
        }

        private void GreenColorOption_Click1(object sender, RoutedEventArgs e)
        {
            ParentWindow.TimeTextBlock.Foreground = Brushes.LightGreen;
            e.Handled = true;
        }

        private void BlueColorOption_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.TimeTextBlock.Foreground = Brushes.LightBlue;
            e.Handled = true;
        }

        private void PurpleColorOption_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.TimeTextBlock.Foreground = Brushes.Purple;
            e.Handled = true;
        }

        private void WhiteColorOption_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.TimeTextBlock.Foreground = Brushes.White;
            e.Handled = true;
        }

        /// <summary>
        /// handle the new window menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewTimerWindow_Click(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            if (app == null)
            {
                MessageBox.Show(Strings2.TroubleGettingApplicationObject);
                return;
            }
            var mainWin = new TimerWindow(++app.NewWindowCounter);
            mainWin.Show();
        }

        private void MenuItem_CreateNewLog(object sender, RoutedEventArgs e)
        {
            var createTimerLogWindow = new CreateTimerLogWindow(ParentWindow.TitleString);
            bool? result = createTimerLogWindow.ShowDialog();
            if (result ?? false)
            {
              // todo create new log file and turn on
            }
        }
    }
}
