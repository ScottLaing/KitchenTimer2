using System.Windows;
using System.Windows.Threading;

namespace KitchenTimer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        // backer variable for NewStopWatchWindowCounter
        internal int NewStopWatchWindowCounter = 0;

        /// <summary>
        /// Keep track of latest new window counter.
        /// </summary>
        public int NewWindowCounter { get; set; } = 1;

        /// <summary>
        /// Sets up exception handling for the application.
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SetupExceptionHandling();
        }

        /// <summary>
        /// Sets up exception handling for the application.
        /// </summary>
        private void SetupExceptionHandling()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        /// <summary>
        /// Handles the DispatcherUnhandledException event.
        /// Displays a message box with the exception details and attempts to continue the application.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(string.Format(Constants.UnexpectedExceptionMessage, e?.Exception.Message), Constants.AppTitle);
            MessageBox.Show(Constants.ApplicationRestartMessage, Constants.AppTitle);
            if (e != null)
            {
                e.Handled = true;
            }
        }
    }
}
