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
    /// Interaction logic for deleteContractWindow.xaml
    /// </summary>
    public partial class deleteContractWindow : Window
    {
        Contract contract;
        BL.IBL bl;

        public deleteContractWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            bl = BL.FactoryBL.GetBL();

            ContractNumComboBoxd.ItemsSource = bl.GetAllContract();
            ContractNumComboBoxd.DisplayMemberPath = "ContractNum";
            ContractNumComboBoxd.SelectedValuePath = "ContractNum";
        }

       private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                contract = bl.GetContract((int)ContractNumComboBoxd.SelectedValue);
                bl.RemoveContract(contract.ContractNum);
                ContractNumComboBoxd.ItemsSource = bl.GetAllContract();

                ContractNumComboBoxd.Items.Refresh();
                contract = new Contract();
                this.DataContext = contract;


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

        private void ContractNumComboBoxd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled = true;

        }
    }
}
