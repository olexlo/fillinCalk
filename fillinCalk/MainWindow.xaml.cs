using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fillinCalk
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //int kass, rezz, num_b = 0;
        bool flf=false, flr=true;
        decimal num_a=0, num_b=0, num_r=0;
        char opfun = '0';
        
        private void k1_Click(object sender, RoutedEventArgs e)
        {
            
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "1";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void k2_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "2";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void k3_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "3";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void k4_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "4";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void kpodil_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                if (flf)
                {
                    switch (opfun)
                    {
                        case '+': num_a += num_b; break;
                        case '-': num_a -= num_b; break;
                        case '*': num_a *= num_b; break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;

                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                }
                else
                {
                    flf = true;
                    opfun = '/';
                    num_a = num_b;
                    labb.Content += " / ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

        private void k5_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "5";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += "6";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Content = bdisp.Text;
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "";
            }
        }

        private void k7_Click(object sender, RoutedEventArgs e)
        {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    bdisp.Text += "7";
                    Decimal.TryParse(bdisp.Text, out num_b);
                    labb.Content = bdisp.Text;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                }
        }

        private void k8_Click(object sender, RoutedEventArgs e)
        {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    bdisp.Text += "8";
                    Decimal.TryParse(bdisp.Text, out num_b);
                    labb.Content = bdisp.Text;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                }
        }

        private void k9_Click(object sender, RoutedEventArgs e)
        {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    bdisp.Text += "9";
                    Decimal.TryParse(bdisp.Text, out num_b);
                    labb.Content = bdisp.Text;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                }
        }

        private void k0_Click(object sender, RoutedEventArgs e)
        {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    bdisp.Text += "0";
                    Decimal.TryParse(bdisp.Text, out num_b);
                    labb.Content = bdisp.Text;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                }
        }

        private void k10_Click(object sender, RoutedEventArgs e)
        {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    bdisp.Text += ",";
                    labb.Content = bdisp.Text;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                }
        }

        private void kmnojen_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                if (flf)
                {
                    switch (opfun)
                    {
                        case '+': 
                            num_a += num_b;
                            labb.Content += " * ";
                            opfun = '*';
                            break;
                        case '-': 
                            num_a -= num_b;
                            labb.Content += " * ";
                            opfun = '*';
                            break;
                        case '*': 
                            num_a *= num_b;
                            labb.Content += " * ";
                            opfun = '*';
                            break;
                        case '/':
                            if (num_b != 0)
                            {
                                num_a /= num_b;
                                labb.Content += " * ";
                                opfun = '*';
                            }
                            else
                            {
                                laberror.Content = "Нельзя делить на ноль";
                            }
                            break;
                        default: break;
                    }
                }
                else
                {
                    flf = true;
                    opfun = '*';
                    num_a = num_b;
                    labb.Content += " * ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

        private void bdisp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            if (regex.IsMatch(e.Text) || (e.Text == "." && ((TextBox)sender).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void krezz_Click(object sender, RoutedEventArgs e)
        {
            if (flr)
            {
                bool success = Decimal.TryParse(bdisp.Text, out num_b);
                if (success)
                {
                    num_r = num_a;
                }
                else
                {
                    laberror.Content = "Значение в поле есть недопустимое число";
                    bdisp.Text = "";
                    return;
                }
            }
            else 
            {
                if (flf)
                {
                    switch (opfun)
                    {
                        case '+':
                            num_r += num_b;
                            labb.Content += " = ";
                            bdisp.Text=num_r.ToString();
                            break;
                        case '-':
                            num_r -= num_b;
                            labb.Content += " = ";
                            bdisp.Text = num_r.ToString();
                            break;
                        case '*':
                            num_r *= num_b;
                            labb.Content += " = ";
                            bdisp.Text = num_r.ToString();
                            break;
                        case '/':
                            if (num_b != 0)
                            {
                                num_r /= num_b;
                                labb.Content += " = ";
                                bdisp.Text = num_r.ToString();
                            }
                            else
                            {
                                laberror.Content = "Нельзя делить на ноль";
                            }
                            break;
                        default: break;
                    }
                }
                else
                {
                    labb.Content += " Введите знак операции";
                    return;
                }
            }
        }

        private void kplus_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                if (flf)
                {
                    switch (opfun) 
                    {
                        case '+': num_a += num_b; break;
                        case '-': num_a -= num_b; break;
                        case '*': num_a *= num_b; break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;

                                }
                                else 
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                }
                else 
                {
                    flf = true;
                    opfun = '+';
                    num_a = num_b;
                    labb.Content += " + ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

        private void kminus_Click(object sender, RoutedEventArgs e)
        {
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                if (flf)
                {
                    switch (opfun)
                    {
                        case '+': num_a += num_b; break;
                        case '-': num_a -= num_b; break;
                        case '*': num_a *= num_b; break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a += num_b;

                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                }
                else
                {
                    flf = true;
                    opfun = '-';
                    num_a = num_b;
                    labb.Content += " - ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

    }
    
}
