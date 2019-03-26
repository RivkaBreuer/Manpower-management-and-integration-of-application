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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MoreFunc.xaml
    /// </summary>
    public partial class MoreFuncWindow : Window
    {
        BL.IBL bl;

               
        public MoreFuncWindow()
        {
            InitializeComponent();
            WindowStartupLocation= WindowStartupLocation.CenterScreen;
            bl = BL.FactoryBL.GetBL();

        }

       

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AnotherlinqButton_Click(object sender, RoutedEventArgs e)
        {
            new Linq_Window.MoreFunc().ShowDialog();
        }

        private void retirementButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.retirement();
                throw new Exception("Removing employees who passed the retirement age was successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bonusButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.bonus();
                throw new Exception("Can a financial bonus to employees over 180 hours per month");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletingcontractsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.invalidContract();
                throw new Exception("Removing employees who passed the retirement age was successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
