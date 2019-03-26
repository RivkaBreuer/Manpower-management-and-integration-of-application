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
    /// Interaction logic for contractWindow.xaml
    /// </summary>
    public partial class contractWindow : Window
    {
        public contractWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            new addContractWindow().ShowDialog();
            

        }

        private void updateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            new updateContractWindow().ShowDialog();
            

        }

        private void removeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            new deleteContractWindow().ShowDialog();

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
