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
    /// Interaction logic for addContractWindow.xaml
    /// </summary>
    public partial class addContractWindow : Window
    {

        Contract contract;
        BL.IBL bl;

        public addContractWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            contract = new Contract();
            grid1.DataContext = contract;
            bl = BL.FactoryBL.GetBL(); 

            employeeIdComboBox.ItemsSource = bl.GetAllEmployee();
            employeeIdComboBox.DisplayMemberPath = "Id";
            employeeIdComboBox.SelectedValuePath = "Id";

            employerIdComboBox.ItemsSource = bl.GetAllEmployer();
            employerIdComboBox.DisplayMemberPath = "Id";
            employerIdComboBox.SelectedValuePath = "Id";
        }

        private void Back2Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                contract.HourSalaryG = (float)salaryNumUpDown.Value;
                bl.AddContract(contract);
                contract = new Contract();
                grid1.DataContext = contract;

                throw new Exception("Add contract successfully!");

            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

      

        private void hoursNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                try
                {
                    if ( bl.IsLetters(hoursNumTextBox.Text) || int.Parse(hoursNumTextBox.Text) <= 0 )
                    {
                        hoursNumTextBox.BorderBrush = Brushes.Red;
                        AddButton.IsEnabled = false;
                    }
                    if (!(bl.IsLetters(hoursNumTextBox.Text)) && int.Parse(hoursNumTextBox.Text) > 0)
                    {
                        hoursNumTextBox.BorderBrush = Brushes.Gray;
                        AddButton.IsEnabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void employeeIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            sender = employeeIdComboBox.SelectedValue;
            Employee em = bl.GetEmployee((string)sender);
            Specialization s = bl.GetSpecialization(em.Special);
            salaryNumUpDown.MinValue = (int)s.TariffMin;
            salaryNumUpDown.MaxValue = (int)s.TariffMax;
            salaryNumUpDown.Value = salaryNumUpDown.MinValue;
        }

        

    }
}


