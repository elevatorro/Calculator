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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string first = "";
        string second = "";
        string final = "";
        string tempstring = "";
        double firstnumber;
        double secondnumber;
        int temp = 0;
        int operation = -1;
        private void but_click1(object sender, RoutedEventArgs e) {
            if ((temp == 0) & (result.Text.Length<11)) {
                
                
                    tempstring = one.Content.ToString();
                    first = String.Concat(first, tempstring);
                    result.Text = first;
                
            }
            if ((temp == 1) & (result.Text.Length < 11)) {
                tempstring = one.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click2(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = two.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = two.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click3(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = three.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = three.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click4(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = four.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = four.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click5(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = five.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = five.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click6(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = six.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = six.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click7(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = seven.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = seven.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click8(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = eight.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = eight.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click9(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = nine.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = nine.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }
        private void but_click0(object sender, RoutedEventArgs e)
        {
            if ((temp == 0) & (result.Text.Length < 11))
            {


                tempstring = zero.Content.ToString();
                first = String.Concat(first, tempstring);
                result.Text = first;

            }
            if ((temp == 1) & (result.Text.Length < 11))
            {
                tempstring = zero.Content.ToString();
                second = String.Concat(second, tempstring);
                result.Text = second;
            }
        }

        private void but_plus(object sender, RoutedEventArgs e) {
            
                temp = 1;
                tempstring = "";
                result.Text = "";
                operation = 1;
                if (first == "") {
                    first = "0";
                }
            
            
        }
        private void but_minus(object sender, RoutedEventArgs e)
        {
            temp = 1;
            tempstring = "";
            result.Text = "";
            operation = 2;
            if (first == "")
            {
                first = "0";
            }
        }
        private void but_proizv(object sender, RoutedEventArgs e)
        {
            temp = 1;
            tempstring = "";
            result.Text = "";
            operation = 3;
            if (first == "")
            {
                first = "0";
            }
        }
        private void but_division(object sender, RoutedEventArgs e)
        {
            temp = 1;
            tempstring = "";
            result.Text = "";
            operation = 4;
            if (first == "")
            {
                first = "0";
            }
        }
        private void but_equal(object sender, RoutedEventArgs e)
        {
            switch (operation) {
                case 1:
                    //firstnumber = int.Parse(first);
                    firstnumber = Convert.ToDouble(first);
                    if (second == "")
                    {
                        second = "0";
                        secondnumber = Convert.ToDouble(second);
                    }
                    else {
                        secondnumber = Convert.ToDouble(second);
                    }
                    result.Text = (firstnumber+secondnumber).ToString();
                    first = result.Text;
                    second = "";

                    break;
                case 2:
                    firstnumber = Convert.ToDouble(first);
                    //secondnumber = int.Parse(second);
                    if (second == "")
                    {
                        second = "0";
                        secondnumber = Convert.ToDouble(second);
                    }
                    else
                    {
                        secondnumber = Convert.ToDouble(second);
                    }
                    result.Text = (firstnumber - secondnumber).ToString();
                    first = result.Text;
                    second = "";
                    break;
                case 3:
                    firstnumber = Convert.ToDouble(first);
                    //secondnumber = int.Parse(second);
                    if (second == "")
                    {
                        second = "0";
                        secondnumber = Convert.ToDouble(second);
                    }
                    else
                    {
                        secondnumber = Convert.ToDouble(second);
                    }
                    result.Text = (firstnumber * secondnumber).ToString();
                    first = result.Text;
                    second = "";
                    break;
                case 4:
                    firstnumber = Convert.ToDouble(first);
                    // secondnumber = int.Parse(second);
                    if (second == "")
                    {
                        second = "0";
                        secondnumber = Convert.ToDouble(second);
                    }
                    else
                    {
                        secondnumber = Convert.ToDouble(second);
                    }
                    result.Text = (firstnumber / secondnumber).ToString();
                    first = result.Text;
                    second = "";
                    break;
                case -1:
                    break;
            }

        }

        private void but_clear(object sender, RoutedEventArgs e) {
            first = "";
            second = "";
            result.Text = "";
            temp = 0;

            
        }


    }
}
