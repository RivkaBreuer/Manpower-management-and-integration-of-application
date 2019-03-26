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
    /// Interaction logic for deleteSpecializationWindow.xaml
    /// </summary>
    public partial class deleteSpecializationWindow : Window
    {
        Specialization special;
        BL.IBL bl;
        Employee employee;

        public deleteSpecializationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            bl = BL.FactoryBL.GetBL();

            SpecialNumComboBoxd.ItemsSource = bl.GetAllSpecialization();
            SpecialNumComboBoxd.DisplayMemberPath = "SpecialNum";
            SpecialNumComboBoxd.SelectedValuePath = "SpecialNum";
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                special = bl.GetSpecialization((int)SpecialNumComboBoxd.SelectedValue);
                bl.RemoveSpecialization(special.SpecialNum);
                SpecialNumComboBoxd.ItemsSource = bl.GetAllSpecialization();
                SpecialNumComboBoxd.Items.Refresh();
                throw new Exception("The contract was removed successfully!");
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

     

        private void SpecialNumComboBoxd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled = true;

        }
    }
}
