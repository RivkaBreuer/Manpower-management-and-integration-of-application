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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for specializationWindow.xaml
    /// </summary>
    public partial class specializationWindow : Window
    {
        public specializationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            new addSpecializationWindow().ShowDialog();
        }

        private void updateSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            new updateSpecializationWindow().ShowDialog();
        }

        private void removeSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            new deleteSpecializationWindow().ShowDialog();
        }

          }
}
