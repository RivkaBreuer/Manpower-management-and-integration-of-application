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
    /// Interaction logic for addSpecializationWindow.xaml
    /// </summary>
    public partial class addSpecializationWindow : Window
    {
        Specialization specialization;
        BL.IBL bl;

        public addSpecializationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            FieldComboBox.ItemsSource = Enum.GetValues(typeof(FieldName));

            specialization = new Specialization();
            this.DataContext = specialization;
            bl = BL.FactoryBL.GetBL();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (expertiseNameTextBox.Text == "")
                    throw new Exception("you must enter a name");
                bl.AddSpecialization(specialization);
                specialization = new Specialization();
                this.DataContext = specialization;
                throw new Exception("Add Specializiation successfully!");
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

       
    }
}
