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
using BL;
using BE;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for updateEmployeeWindow.xaml
    /// </summary>
    public partial class updateEmployeeWindow : Window
    {
        BL.IBL bl;
        Employee employee;
        BankAccount myBank;

        public updateEmployeeWindow()
        {
            InitializeComponent();

            bl = BL.FactoryBL.GetBL();
            myBank = new BankAccount();

            idComboBox.ItemsSource = bl.GetAllEmployee();
            idComboBox.DisplayMemberPath = "Id";
            idComboBox.SelectedValuePath = "Id";

            specialComboBox.ItemsSource = bl.GetAllSpecialization();
            specialComboBox.DisplayMemberPath = "SpecialNum";
            specialComboBox.SelectedValuePath = "SpecialNum";


            bankNoTextBox.ItemsSource = bl.GetAllAtmGroupByBank();
            bankNoTextBox.DisplayMemberPath = "BankNo";
            bankNoTextBox.SelectedValuePath = "BankNo";

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            degreeTypeComboBox.ItemsSource = Enum.GetValues(typeof(Degree));


        }

        private void Back3Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (phoneNumTextBox.BorderBrush == Brushes.Red || accountNoTextBox.BorderBrush == Brushes.Red || branchNoTextBox.BorderBrush == Brushes.Red || bankNoTextBox.BorderBrush == Brushes.Red)
                    throw new Exception("Invalid data");
                
                employee = bl.GetEmployee((string)idComboBox.Text);
                myBank.AccountNo = Convert.ToInt32(accountNoTextBox.Text);
                myBank.BankNo = Convert.ToInt32(bankNoTextBox.SelectedValue);
                myBank.BranchNo = Convert.ToInt32(branchNoTextBox.SelectedValue);
                myBank.BankName = bankNameTextBox.Text;
                myBank.BranchAdd = branchAddTextBox.Text;
                myBank.BranchCity = branchCityTextBox.Text;
                employee.MyAccount = myBank;
                employee.Address = addressTextBox.Text;
                employee.DateBirth = Convert.ToDateTime(dateBirthDatePicker.Text);
                employee.degreeType = ((Degree)Enum.Parse(typeof(Degree), degreeTypeComboBox.Text));
                employee.FirstName = firstNameTextBox.Text;
                employee.LastName = lastNameTextBox.Text;
                employee.GraduateArmy = Convert.ToBoolean(graduateArmyCheckBox.IsChecked);
                employee.ImageSource = Convert.ToString(this.employeeImage.Source);
                employee.PhoneNum = phoneNumTextBox.Text;
                employee.Special = Convert.ToInt32( specialComboBox.Text);



               bl.UpdateEmployee(employee);

                throw new Exception("The employee has been updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            sender = idComboBox.SelectedValue;
            this.grid1.DataContext = bl.GetEmployee((string)sender);
            this.grid2.DataContext = bl.GetEmployee((string)sender).MyAccount;

            bankNoTextBox.IsEnabled = true;
            branchNoTextBox.IsEnabled = true;
            accountNoTextBox.IsEnabled = true;
            UpdateButton.IsEnabled = true;
            addressTextBox.IsEnabled = true;
            firstNameTextBox.IsEnabled = true;
            lastNameTextBox.IsEnabled = true;
            dateBirthDatePicker.IsEnabled = true;
            degreeTypeComboBox.IsEnabled = true;
            graduateArmyCheckBox.IsEnabled = true;
            phoneNumTextBox.IsEnabled = true;
            specialComboBox.IsEnabled = true;
            accountNoTextBox.IsEnabled = true;
            changeImageButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeImageButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog f = new Microsoft.Win32.OpenFileDialog();
            f.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (f.ShowDialog() == true)
            {
                this.employeeImage.Source = new BitmapImage(new Uri(f.FileName));

            }
        }
      
        private void phoneNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (bl.IsLetters(phoneNumTextBox.Text) || phoneNumTextBox.Text.Length < 9 || phoneNumTextBox.Text.Length > 10 || int.Parse(phoneNumTextBox.Text) < 0)
                {
                    phoneNumTextBox.BorderBrush = Brushes.Red;
                    UpdateButton.IsEnabled = false;
                }
                if (phoneNumTextBox.Text.Length == 9 || phoneNumTextBox.Text.Length == 10 && !(bl.IsLetters(phoneNumTextBox.Text)))
                {
                    phoneNumTextBox.BorderBrush = Brushes.Gray;
                    UpdateButton.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void accountNoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (bl.IsLetters(accountNoTextBox.Text) || int.Parse(accountNoTextBox.Text) <= 0)
                {
                    accountNoTextBox.BorderBrush = Brushes.Red;
                    UpdateButton.IsEnabled = false;
                }
                if (!(bl.IsLetters(accountNoTextBox.Text)) && int.Parse(accountNoTextBox.Text) > 0)
                {
                    accountNoTextBox.BorderBrush = Brushes.Gray;
                    UpdateButton.IsEnabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bankNoTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bankNameTextBox.Text = bl.GetBankNames((int)bankNoTextBox.SelectedValue);
            branchNoTextBox.ItemsSource = bl.GetAllBrunchOfBank((int)bankNoTextBox.SelectedValue);
            branchNoTextBox.DisplayMemberPath = "BranchNo";
            branchNoTextBox.SelectedValuePath = "BranchNo";
            branchNoTextBox.SelectedValue = null;
            branchAddTextBox.Text = "";
            branchCityTextBox.Text = "";
        }

        private void branchNoTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (branchNoTextBox.SelectedValue != null)
            {
                branchAddTextBox.Text = bl.GetBranchName((int)branchNoTextBox.SelectedValue, (int)bankNoTextBox.SelectedValue);
                branchCityTextBox.Text = bl.GetBranchCity((int)branchNoTextBox.SelectedValue, (int)bankNoTextBox.SelectedValue);
            }
        }
    }
}
