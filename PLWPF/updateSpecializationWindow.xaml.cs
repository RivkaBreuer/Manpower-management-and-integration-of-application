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
    /// Interaction logic for updateSpecializationWindow.xaml
    /// </summary>
    public partial class updateSpecializationWindow : Window
    {
        BL.IBL bl;
        Specialization special;
        public updateSpecializationWindow()
        {
            InitializeComponent();

            //special = new Specialization();
            //this.grid1.DataContext = special;
           
            bl = BL.FactoryBL.GetBL();

            specialNumComboBox.ItemsSource = bl.GetAllSpecialization();
            specialNumComboBox.DisplayMemberPath = "SpecialNum";
            specialNumComboBox.SelectedValuePath = "SpecialNum";

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            skillComboBox.ItemsSource = Enum.GetValues(typeof(FieldName));

        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                special = bl.GetSpecialization((int)specialNumComboBox.SelectedValue);

                special.TariffMin = Convert.ToDouble(tariffMinTextBox.Text);
                special.TariffMax = Convert.ToDouble(tariffMaxTextBox.Text);
                special.Field = ((FieldName)Enum.Parse(typeof(FieldName), (skillComboBox.Text)));

                //tariffMaxTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                //tariffMinTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                //skillComboBox.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateSource();
                // specializationNameTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                bl.UpdateSpecialization(special);

                throw new Exception("The specialization has been updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void Back5Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

      

       
        private void specialNumComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            sender = specialNumComboBox.SelectedValue;
            this.grid1.DataContext = bl.GetSpecialization((int)sender);

            skillComboBox.IsEnabled = true;
            tariffMaxTextBox.IsEnabled = true;
            tariffMinTextBox.IsEnabled = true;
            updateButton.IsEnabled = true;
        }
    }
}
