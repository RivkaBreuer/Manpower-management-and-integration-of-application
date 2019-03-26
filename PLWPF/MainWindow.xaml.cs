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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.IBL bl;
        public MainWindow()
        {
            bl = BL.FactoryBL.GetBL();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void employerButton_Click(object sender, RoutedEventArgs e)
        {
            new employerWindow().ShowDialog();
        }

        private void employeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bl.checkfinish() == false)
                    throw new Exception("The download is not finished already");
                new employeeWindow().ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contractButton_Click(object sender, RoutedEventArgs e)
        {
            new contractWindow().ShowDialog();
            
        }

        private void specializationButton_Click(object sender, RoutedEventArgs e)
        {
            new specializationWindow().ShowDialog();
        }

        private void linqButton_Click(object sender, RoutedEventArgs e)
        {
            new Linq_Window.LinqWindow().ShowDialog();
        }

        private void MoreFunc_Click(object sender, RoutedEventArgs e)
        {
            new MoreFuncWindow().ShowDialog();            
        }
    }
}
