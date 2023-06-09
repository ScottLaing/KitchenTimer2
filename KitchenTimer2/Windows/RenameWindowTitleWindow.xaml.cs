﻿using KitchenTimer.Entities;
using KitchenTimer2.Resx;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Media;
using System.Windows;
using System.Windows.Controls;

namespace KitchenTimer.Windows
{
    /// <summary>
    /// Interaction logic for SetTime.xaml
    /// </summary>
    public partial class RenameWindowTitleWindow : Window
    {
        #region Fields

        // current assembly
        private System.Reflection.Assembly assembly;

        // whether an alarm is playing now
        #endregion
                
        #region Properties

        public string TimerName { get; set; } = "";

        #endregion

        #region Constructors

        /// <summary>
        /// main constructor
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
