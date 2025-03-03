using KitchenTimer2.Resx;
using System;
using System.ComponentModel;
using System.Windows;

namespace KitchenTimer.Windows
{
    /// <summary>
    /// Interaction logic for RenameWindowTitleWindow.xaml
    /// </summary>
    public partial class RenameWindowTitleWindow : Window
    {
        #region Fields

        // whether an alarm is playing now
        #endregion
                
        #region Properties

        public string TimerName { get; set; } = "";

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameWindowTitleWindow"/> class.
        /// </summary>
        public RenameWindowTitleWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// overloaded constructor passing in current alarm and current counter time value
        /// </summary>
        /// <param name="currentAlarm"></param>
        /// <param name="countDown"></param>
        public RenameWindowTitleWindow(string timerName) : this()
        {
            this.txtTimerName.Text = timerName?.Trim() ?? "";
        }

        #endregion

        #region Methods

 
        /// <summary>
        /// save the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TimerName = this.txtTimerName.Text.Trim();
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                var error = string.Format(Strings2.SavingError, ex.Message);
                MessageBox.Show(error);
            }
        }

   
        /// <summary>
        /// handle window closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, CancelEventArgs e)
        {
          
        }

   
        #endregion

        #region Utility Methods

   
        #endregion
    }
}
