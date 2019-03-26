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

namespace PLWPF.Linq_Window
{
    /// <summary>
    /// Interaction logic for MoreFunc.xaml
    /// </summary>
    public partial class MoreFunc : Window
    {
        BL.IBL bl;
        public MoreFunc()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            bl = BL.FactoryBL.GetBL();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Gruping3Button_Click(object sender, RoutedEventArgs e)
        {
            GroupingByAddressUserControl gr = new GroupingByAddressUserControl();
            gr.Source = bl.GroupingByAddress().ToList();

            page.Content = gr;
        
        }

        private void Gruping2Button_Click(object sender, RoutedEventArgs e)
        {
            GruopingEarnByYears g = new GruopingEarnByYears();
            g.Source = bl.gruopingEarnByYears().ToList();

            page.Content = g;

        }

        private void Gruping1Button_Click(object sender, RoutedEventArgs e)
        {
            isArmyUserControl E = new isArmyUserControl();
            E.Source = bl.IsArmy().ToList();
            page.Content = E;
        }
    }
}
