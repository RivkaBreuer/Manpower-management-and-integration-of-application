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
using System.Collections;

namespace PLWPF.Linq_Window
{
    /// <summary>
    /// Interaction logic for PresentForBirthdayUserControl.xaml
    /// </summary>
    public partial class PresentForBirthdayUserControl : UserControl
    {

        private IEnumerable source;

        public IEnumerable Source
        {
            get { return source; }
            set
            {
                source = value;
                this.listView.ItemsSource = source;
            }
        }
        public PresentForBirthdayUserControl()
        {
            InitializeComponent();
        }
    }
}
