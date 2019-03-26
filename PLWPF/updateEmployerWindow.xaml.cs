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
    /// Interaction logic for updateEmployerWindoe.xaml
    /// </summary>
    public partial class updateEmployerWindow : Window
    {
        BL.IBL bl;
        Employer employer;

        public updateEmployerWindow()
        {
            InitializeComponent();

            bl = BL.FactoryBL.GetBL();

            idComboBox.ItemsSource = bl.GetAllEmployer();
            idComboBox.DisplayMemberPath = "Id";
            idComboBox.SelectedValuePath = "Id";

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            skillComboBox.ItemsSource = Enum.GetValues(typeof(FieldName));
            
        }

        private void Back5Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idComboBox.BorderBrush == Brushes.Red || phoneNumTextBox.BorderBrush == Brushes.Red )
                    throw new Exception("Invalid data");
                updateButton.IsEnabled = true;

                employer = bl.GetEmployer((string)idComboBox.Text);
                #region update       
                employer.Address = addressTextBox.Text;
                employer.IsCompany = Convert.ToBoolean(isCompanyCheckBox.IsChecked);
                employer.DateEstablishment = Convert.ToDateTime(dateEstablishmentDatePicker.Text);
                employer.FirstName = firstNameTextBox.Text;
                employer.LastName = lastNameTextBox.Text;
                employer.Field = ((FieldName)Enum.Parse(typeof(FieldName), skillComboBox.Text));
                if (employer.IsCompany == false)
                    employer.CompanyName = "";
                else employer.CompanyName = companyNameTextBox.Text;
                employer.PhoneNum = phoneNumTextBox.Text;
                

               
                #endregion
                bl.UpdateEmployer(employer);

                throw new Exception("The employer has been updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void isCompanyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            companyNameTextBox.IsEnabled = true;
        }

       private void isCompanyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            companyNameTextBox.IsEnabled = false;
        }

        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sender = idComboBox.SelectedValue;
            this.DataContext = bl.GetEmployer((string)sender);

            firstNameTextBox.IsEnabled = true;
            lastNameTextBox.IsEnabled = true;
            addressTextBox.IsEnabled = true;
            phoneNumTextBox.IsEnabled = true;
            isCompanyCheckBox.IsEnabled = true;
            skillComboBox.IsEnabled = true;
            dateEstablishmentDatePicker.IsEnabled = true;
            updateButton.IsEnabled = true;
        }

        private void phoneNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            { 
            if (phoneNumTextBox.Text.Length < 9 || phoneNumTextBox.Text.Length > 10 || int.Parse(phoneNumTextBox.Text) < 0)
            {
                phoneNumTextBox.BorderBrush = Brushes.Red;
                updateButton.IsEnabled = false;
            }
            if (!(bl.IsLetters(phoneNumTextBox.Text)) && phoneNumTextBox.Text.Length == 9 || phoneNumTextBox.Text.Length == 10)
            {
                phoneNumTextBox.BorderBrush = Brushes.Gray;
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
