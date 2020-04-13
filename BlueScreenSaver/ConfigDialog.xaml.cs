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
using System.Windows.Shapes;

namespace BlueScreenSaver
{
    /// <summary>
    /// Interaktionslogik für ConfigDialog.xaml
    /// </summary>
    public partial class ConfigDialog : Window
    {
        public ConfigDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.AllowInteractive = cbAllowInteractive.IsChecked == true;
            //if (rbEasy.IsChecked == true)
            //    Properties.Settings.Default.Difficulty = 0;
            //else if (rbMedium.IsChecked == true)
            //    Properties.Settings.Default.Difficulty = 1;
            //else
            //    Properties.Settings.Default.Difficulty = 2;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
