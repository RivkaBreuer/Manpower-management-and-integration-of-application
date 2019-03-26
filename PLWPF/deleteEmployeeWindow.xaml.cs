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
using BE;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for deleteEmployeeWindow.xaml
    /// </summary>
    public partial class deleteEmployeeWindow : Window
    {
        BL.IBL bl;
        Employee employee;

        public deleteEmployeeWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

            idComboBoxd.ItemsSource = bl.GetAllEmployee();
            idComboBoxd.DisplayMemberPath = "Id";
            idComboBoxd.SelectedValuePath = "Id";

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

      
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                employee = bl.GetEmployee((string)idComboBoxd.SelectedValue);
                bl.RemoveEmployee(employee.Id);

                idComboBoxd.ItemsSource = bl.GetAllEmployee();

                idComboBoxd.Items.Refresh();
                employee = new Employee();
                grid1.DataContext = employee;

                throw new Exception("The employee was removed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back4Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

     

        private void idComboBoxd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled= true;
        }
    }
}
