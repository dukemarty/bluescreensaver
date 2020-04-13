using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlueScreenSaver
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            m_vm = new MainWindowViewModel();
            DataContext = m_vm;

            m_isPreview = App.TheApp.Mode == App.RunMode.Preview;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (m_isPreview) { return; }

            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_isPreview) { return; }

            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (m_isPreview) { return; }

            this.Close();
        }

        #region Attributes

        private MainWindowViewModel m_vm;

        private bool m_isPreview = false;

        #endregion Attributes
    }
}
