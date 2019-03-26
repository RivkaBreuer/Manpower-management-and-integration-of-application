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
    /// Interaction logic for employeeWindow.xaml
    /// </summary>
    public partial class employeeWindow : Window
    {
        BL.IBL bl;
        public employeeWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
        
            new addEmployeeWindow().ShowDialog();
        }

        private void updateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            new updateEmployeeWindow().ShowDialog();
        }

        private void removeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            new deleteEmployeeWindow().ShowDialog();
        }
    }
}
