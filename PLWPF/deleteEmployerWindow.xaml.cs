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
    /// Interaction logic for deleteEmployerWindow.xaml
    /// </summary>
    public partial class deleteEmployerWindow : Window
    {
        BL.IBL bl;
        Employer employer;

        public deleteEmployerWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

            idComboBoxd.ItemsSource = bl.GetAllEmployer();
            idComboBoxd.DisplayMemberPath = "Id";
            idComboBoxd.SelectedValuePath = "Id";

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                employer = bl.GetEmployer((string)idComboBoxd.SelectedValue);
                bl.RemoveEmployer(employer.Id);

                idComboBoxd.ItemsSource = bl.GetAllEmployer();
                idComboBoxd.Items.Refresh();

                employer = new Employer();
                grid1.DataContext = employer;
                throw new Exception("The employer was removed successfully!");
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
            deleteButton.IsEnabled = true;

        }
    }
}
