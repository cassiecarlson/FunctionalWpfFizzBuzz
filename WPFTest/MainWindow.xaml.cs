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
using FizzbuzzCalculator;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int x;
            if(Int32.TryParse(InputTextBox.Text, out x))
            {
                OutputLabel.Content = FizzbuzzCalculator.FizzbuzzCalculator.fizzbuzzCalc(x);
            }
            else
            {
                OutputLabel.Content = "Enter an Integer";
            }
        }

        private void InputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = null;
        }
    }
}
