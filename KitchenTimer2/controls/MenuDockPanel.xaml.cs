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
        // MenuDockPanel constructor
        public MenuDockPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        // The parent window that this menu is associated with.
        /// </summary>
        public IParentWindow? ParentWindow { get; set; }

        /// <summary>
        // Show the settings window and change settings.
        /// </summary>
        private bool _showSettingsMenuItem = true;

        /// <summary>
        // Show the settings window and change settings.
        /// </summary>
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
        /// Show the settings window and change settings.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowSettingsWindow(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.ShowSettingsWindow(sender, e);
            }
        }

        /// <summary>
        /// Handle the show about window menu call.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        public void ShowAboutWindow(object sender, RoutedEventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        /// <summary>
        /// Handle the exit menu call.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ShutdownApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Handle the stop watch window menu click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Handle the rename timer menu click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuItem_RenameTimer_Click(object sender, RoutedEventArgs e)
        {
            var renameWindow = new RenameWindowTitleWindow(ParentWindow?.TitleString ?? "");
            bool? result = renameWindow.ShowDialog();
            if (result ?? false)
            {
                var newTitle = renameWindow.TimerName;
                if (!string.IsNullOrWhiteSpace(newTitle))
                {
                    if (ParentWindow != null)
                    {
                        ParentWindow.TitleString = newTitle;
                    }
                }
            }
        }

        /// <summary>
        /// Handle the red color option click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void RedColorOption_Click(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.TimeTextBlock.Foreground = Brushes.Red;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handle the green color option click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GreenColorOption_Click1(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.TimeTextBlock.Foreground = Brushes.LightGreen;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handle the blue color option click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BlueColorOption_Click(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.TimeTextBlock.Foreground = Brushes.LightBlue;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handle the purple color option click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PurpleColorOption_Click(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.TimeTextBlock.Foreground = Brushes.Purple;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handle the white color option click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void WhiteColorOption_Click(object sender, RoutedEventArgs e)
        {
            if (ParentWindow != null)
            {
                ParentWindow.TimeTextBlock.Foreground = Brushes.White;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handle the new timer window menu click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Handle the create new log menu click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuItem_CreateNewLog(object sender, RoutedEventArgs e)
        {
            var createTimerLogWindow = new CreateTimerLogWindow(ParentWindow?.TitleString ?? "");
            bool? result = createTimerLogWindow.ShowDialog();
            if (result ?? false)
            {
                // todo create new log file and turn on
            }
        }
    }
}
