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
using BE;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for NumericUpDownControl.xaml
    /// </summary>
    public partial class NumericUpDownControl : UserControl
    {
        private float? num = null;
        public float? Value
        {
            get { return num; }
            set
            {
                if (value > MaxValue)
                    num = MaxValue;
                else if (value < MinValue)
                    num = MinValue;
                else
                    num = value;

                textNumber.Text = num == null ? "" : num.ToString();
            }
        }

        public int MinValue { get; set; }
       // public int MaxValue { get; set; }



        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }


        // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(int), typeof(NumericUpDownControl), new PropertyMetadata(100));
        // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(NumericUpDownControl), new PropertyMetadata());


        public NumericUpDownControl()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 350;


        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            Value -= 10;
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            Value += 10;
        }
        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textNumber == null || textNumber.Text == "-")
                return;

            float val;
            if (!float.TryParse(textNumber.Text, out val))
                textNumber.Text = Value.ToString();
            else
                Value = val;
        }
    }
}
