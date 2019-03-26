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
    /// Interaction logic for addEmployerWindow.xaml
    /// </summary>
    public partial class addEmployerWindow : Window
    {
        Employer employer;
        BL.IBL bl;

        public addEmployerWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            skillComboBox.ItemsSource = Enum.GetValues(typeof(FieldName));
           

            employer = new Employer();
            this.DataContext = employer;
            bl = BL.FactoryBL.GetBL();

            

        }

        private void Back5Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idTextBox.Text == "")
                    idTextBox.BorderBrush = Brushes.Red;


                if (idTextBox.BorderBrush == Brushes.Red || phoneNumTextBox.BorderBrush == Brushes.Red )
                    throw new Exception("Invalid data");
                AddButton.IsEnabled = true;

                bl.AddEmployer(employer);
                employer = new Employer();
                this.DataContext = employer;
                throw new Exception("Add employer successfully!");
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

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            { 
            if (bl.IsLetters(idTextBox.Text) || idTextBox.Text.Length != 9 || int.Parse(idTextBox.Text) < 0)
            {
                idTextBox.BorderBrush = Brushes.Red;
                AddButton.IsEnabled = false;
            }
            if (!(bl.IsLetters(idTextBox.Text)) && idTextBox.Text.Length == 9)
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
                if (!(bl.IsLetters(phoneNumTextBox.Text))&& phoneNumTextBox.Text.Length == 9 || phoneNumTextBox.Text.Length == 10)
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


    

       
    }
}
