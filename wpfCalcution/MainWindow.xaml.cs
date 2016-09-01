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

namespace wpfCalcution
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string  input_num1 = input_num.Text;
            int input_num2 = int.Parse(input_num1).;
            int input_num3 = 1;
            Calculator 
            
            for (int i1 = 0; i1 < input_num2; i1++)
            {

                Console.WriteLine(input_num3 + "                   " + cal1.square_cal(input_num3) + "                " + cal1.cube_cal(input_num2));


                input_num2++;

            }

        }
    }
}
