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
    /// Interaction logic for updateContractWindow.xaml
    /// </summary>
    public partial class updateContractWindow : Window
    {
        Contract contract;
        BL.IBL bl;

        public updateContractWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            bl = BL.FactoryBL.GetBL();

            employeeIdComboBox.ItemsSource = bl.GetAllEmployee();
            employeeIdComboBox.DisplayMemberPath = "Id";
            employeeIdComboBox.SelectedValuePath = "Id";

            employerIdComboBox.ItemsSource = bl.GetAllEmployer();
            employerIdComboBox.DisplayMemberPath = "Id";
            employerIdComboBox.SelectedValuePath = "Id";

            contractNumComboBox.ItemsSource = bl.GetAllContract();
            contractNumComboBox.DisplayMemberPath = "ContractNum";
            contractNumComboBox.SelectedValuePath = "ContractNum";

        }

        private void Back2Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                contract = bl.GetContract((int)contractNumComboBox.SelectedValue);
                #region updeate detaild

                //dateBegingEmployinDatePicker.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
                //dateEndEmployingDatePicker.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
                //isInterviewCheckBox.GetBindingExpression(CheckBox.IsCheckedProperty).UpdateSource();
                //isSignCheckBox.GetBindingExpression(CheckBox.IsCheckedProperty).UpdateSource();
                //hoursNumTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                //salaryNumUpDown.GetBindingExpression(NumericUpDownControl.ValueProperty).UpdateSource();
                // contract.DateBegingEmployin = Convert.ToDateTime(dateBegingEmployinDatePicker.Text);
                contract.DateBegingEmployin = Convert.ToDateTime(dateBegingEmployinDatePicker.Text);
                contract.DateEndEmploying = Convert.ToDateTime(dateEndEmployingDatePicker.Text);
                contract.EmployeeId = employeeIdComboBox.Text;
                contract.EmployerId = employerIdComboBox.Text;
                contract.IsInterview = Convert.ToBoolean(isInterviewCheckBox.IsChecked);
                contract.IsSign = Convert.ToBoolean(isSignCheckBox.IsChecked);
                contract.HoursNum = Convert.ToInt32(hoursNumTextBox.Text);
                contract.HourSalaryN = Convert.ToDouble(hourSalaryNTextBox.Text);
                contract.HourSalaryG = (float)salaryNumUpDown.Value;
                #endregion
                bl.UpdateContract(contract);

                throw new Exception("The contract has been updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

       private void contractNumComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                sender = contractNumComboBox.SelectedValue;
                grid1.DataContext = bl.GetContract((int)sender);
                salaryNumUpDown.Value = (float)bl.GetContract((int)sender).HourSalaryG;

                
                dateBegingEmployinDatePicker.IsEnabled = true;
                dateEndEmployingDatePicker.IsEnabled = true;
                salaryNumUpDown.IsEnabled = true;             
                isInterviewCheckBox.IsEnabled = true;
                isSignCheckBox.IsEnabled = true;
                hoursNumTextBox.IsEnabled = true;
                updateButton.IsEnabled = true;
                  }
        }

     

        private void hoursNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (bl.IsLetters(hoursNumTextBox.Text) || int.Parse(hoursNumTextBox.Text) < 0)
                {
                    hoursNumTextBox.BorderBrush = Brushes.Red;
                    updateButton.IsEnabled = false;
                }
                if (!(bl.IsLetters(hoursNumTextBox.Text)) || int.Parse(hoursNumTextBox.Text) > 0)
                {
                    hoursNumTextBox.BorderBrush = Brushes.Gray;
                    updateButton.IsEnabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
