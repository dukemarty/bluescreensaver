using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BlueScreenSaver
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Properties

        public int Completeness { get; set; }

        #endregion Properties

        #region Public interface

        public MainWindowViewModel()
        {
            m_stepTimer = new DispatcherTimer();
            m_stepTimer.Tick += StepTimer_Tick;                ;
            m_stepTimer.Interval = TimeSpan.FromMilliseconds(Properties.Settings.Default.UpdateIntervalMs);

            m_stepTimer.Start();
        }

        #endregion Public interface

        #region Private methods

        private void StepTimer_Tick(object sender, EventArgs e)
        {
            if (Completeness == Properties.Settings.Default.ResetHardBoundary)
            {
                Completeness = Properties.Settings.Default.ResetStartValue;
            }
            else
            {
                Completeness += Properties.Settings.Default.AverageStepSize;
            }

            NotifyPropertyChanged(nameof(Completeness));
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion Private methods

        #region Attributes
        public event PropertyChangedEventHandler PropertyChanged;

        private Random m_random = new Random();
        private DispatcherTimer m_stepTimer;
        #endregion Attributes
    }
}
