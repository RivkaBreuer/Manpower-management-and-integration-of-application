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
using System.Collections;


namespace PLWPF
{
    /// <summary>
    /// Interaction logic for addEmployeeWindow.xaml
    /// </summary>
    public partial class addEmployeeWindow : Window
    {
        BL.IBL bl;
        Employee employee;
        BankAccount myBank;

        public addEmployeeWindow()
        {
            InitializeComponent();

            employee = new Employee();
            myBank = new BankAccount();
            this.grid1.DataContext = employee;
            this.grid2.DataContext = myBank;
            bl = BL.FactoryBL.GetBL();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            degreeTypeComboBox.ItemsSource = Enum.GetValues(typeof(Degree));

            specialComboBox.ItemsSource = bl.GetAllSpecialization();
            specialComboBox.DisplayMemberPath = "SpecialNum";
            specialComboBox.SelectedValuePath = "SpecialNum";

            bankNoTextBox.ItemsSource = bl.GetAllAtmGroupByBank();
            bankNoTextBox.DisplayMemberPath = "BankNo";
            bankNoTextBox.SelectedValuePath = "BankNo";




        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (specialComboBox.SelectedValue == null)
                   throw new Exception("you must select specialization");
                

                if (idTextBox.BorderBrush == Brushes.Red || accountNoTextBox.BorderBrush == Brushes.Red ||  specialComboBox.SelectedItem == null)
                    throw new Exception("Invalid data");
                
                myBank.AccountNo = Convert.ToInt32(accountNoTextBox.Text);
                myBank.BankNo = Convert.ToInt32(bankNoTextBox.SelectedValue);
                myBank.BranchNo = Convert.ToInt32(branchNoTextBox.SelectedValue);
                myBank.BankName = bankNameTextBox.Text;
                myBank.BranchAdd = branchAddTextBox.Text;
                myBank.BranchCity = branchCityTextBox.Text;
                employee.MyAccount = myBank;
                bl.AddEmployee(employee);

                specialComboBox.ItemsSource = bl.GetAllSpecialization();
                employee = new Employee();
                myBank = new BankAccount();
                specialComboBox.Items.Refresh();
                this.grid1.DataContext = employee;
                bankNoTextBox.SelectedValue = null;
                branchNoTextBox.SelectedValue = null;
                bankNameTextBox.Text = "";
                accountNoTextBox.Text = "0";


                throw new Exception("Add employee successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Back2Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (bl.IsLetters(idTextBox.Text) || idTextBox.Text.Length != 9 || int.Parse(idTextBox.Text) < 0)
                {
                    idTextBox.BorderBrush = Brushes.Red;
                    AddButton.IsEnabled = false;
                }
                if (idTextBox.Text.Length == 9 && !(bl.IsLetters(idTextBox.Text)))
                {
                    idTextBox.BorderBrush = Brushes.Gray;
                    AddButton.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void phoneNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (bl.IsLetters(phoneNumTextBox.Text) || phoneNumTextBox.Text.Length < 9 || phoneNumTextBox.Text.Length > 10 || int.Parse(phoneNumTextBox.Text) < 0)
                {
                    phoneNumTextBox.BorderBrush = Brushes.Red;
                    AddButton.IsEnabled = false;
                }
                if (phoneNumTextBox.Text.Length == 9 || phoneNumTextBox.Text.Length == 10 && !(bl.IsLetters(phoneNumTextBox.Text)))
                {
                    phoneNumTextBox.BorderBrush = Brushes.Gray;
                    AddButton.IsEnabled = true;
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
                    AddButton.IsEnabled = false;
                }
                if (!(bl.IsLetters(accountNoTextBox.Text)) && int.Parse(accountNoTextBox.Text) > 0)
                {
                    accountNoTextBox.BorderBrush = Brushes.Gray;
                    AddButton.IsEnabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        

       private void specialComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (specialComboBox.SelectedValue != null)
            {
                accountNoTextBox.BorderBrush = Brushes.Gray;
                AddButton.IsEnabled = true;
            }
        }

        private void bankNoTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bankNameTextBox.Text = bl.GetBankNames((int)bankNoTextBox.SelectedValue);
            branchNoTextBox.IsEnabled = true;
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
                accountNoTextBox.IsEnabled = true;
            }
        }
    }
}
