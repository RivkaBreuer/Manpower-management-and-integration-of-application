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

namespace PLWPF.Linq_Window
{
    /// <summary>
    /// Interaction logic for LinqWindow.xaml
    /// </summary>
    public partial class LinqWindow : Window
    {
        BL.IBL bl;
        public LinqWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            bl = BL.FactoryBL.GetBL();
        }

        private void Gruping1Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               

                GroupingBySpecialUserControl uc = new GroupingBySpecialUserControl();
                uc.Source = bl.GroupingBySpecial().ToList();

                page.Content = uc;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gruping2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                PresentForBirthdayUserControl pr = new PresentForBirthdayUserControl();
                pr.Source = bl.present().ToList();

                page.Content = pr;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gruping3Button_Click(object sender, RoutedEventArgs e)
        {
            GroupingSpecialOrderByDegreeUserControl or = new GroupingSpecialOrderByDegreeUserControl();
            or.Source = bl.groupingSpecailOrderByDegree().ToList();

            page.Content = or;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
    
    }

