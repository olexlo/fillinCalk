using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace fillinCalk
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool flf=false, flr=false, fr=false;
        // flf - флаг наявності функціі flr - флаг наявности рішення
        // fr - флаг якщо була виконана дія і потрібно очистити поле ввода-вивода
        decimal num_a =0, num_b=0, num_r=0; // перше число, други число, число результат дії
        char opfun = '0'; // символьне позначення дії

        private void k1_Click(object sender, RoutedEventArgs e)
        {
            if (fr) 
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "1";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "1";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "1";
            }
        }

        private void k2_Click(object sender, RoutedEventArgs e)
        {
            //var number = Convert.ToDecimal(bdisp.Text); //Інший вигляд
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "2";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "2";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "2";
            }
        }

        private void k3_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "3";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "3";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "3";
            }
        }

        private void k4_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "4";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "4";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "4";
            }
        }

        private void kpodil_Click(object sender, RoutedEventArgs e)
        {
            // зміна дії після використання кнопки результату
            if (flr)
            {
                flr = false;
                opfun = '/';
                labb.Text += opfun;
                return;
            }
            // перевіряю що в тексте число, та переутворюю його в число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                // якщо раніше було ініциалізованна дія, то цю дію потрибно виконати та ініциалізувати наступну дію
                if (flf)
                {
                    // перевірка яка дія ініціалізованна
                    switch (opfun)
                    {
                        case '+':
                            num_a += num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '-':
                            num_a -= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '*':
                            num_a *= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;
                                    labb.Text += " = " + num_a.ToString() + opfun;
                                    bdisp.Text = num_a.ToString();
                                    num_r = num_b;
                                    num_b = 0;
                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                    opfun = '/';
                    fr = true;
                }
                else
                {
                    flf = true; // флаг наявності дії
                    opfun = '+'; // ініціалізація дії
                    fr = true; // флаг що треба ночинати нове число
                    num_a = num_b;
                    num_r = num_b;
                    num_b = 0;
                    labb.Text += " / ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

        private void k5_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "5";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "5";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "5";
            }
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "6";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "6";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "6";
            }
        }

        private void k7_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "7";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "7";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "7";
            }
        }

        private void k8_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "8";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "8";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "8";
            }
        }

        private void k9_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success || bdisp.Text == "")
            {
                bdisp.Text += "9";
                Decimal.TryParse(bdisp.Text, out num_b);
                labb.Text += "9";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "9";
            }
        }

        private void k0_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                // число не може починатися з нуля, якщо далі не йде точка
                if (bdisp.Text == "" || bdisp.Text == "0")
                {
                    bdisp.Text = "0,";
                    labb.Text += "0";
                }
                else 
                {
                    bdisp.Text += "0";
                    Decimal.TryParse(bdisp.Text, out num_b);
                    labb.Text += "0";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "0";
            }
        }

        private void kplus_Click(object sender, RoutedEventArgs e)
        {
            // зміна дії після використання кнопки результату
            if (flr)
            {
                flr = false;
                opfun = '+';
                labb.Text += opfun;
                return;
            }
            // перевіряю що в тексте число, та переутворюю його в число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                // якщо раніше було ініциалізованна дія, то цю дію потрибно виконати та ініциалізувати наступну дію
                if (flf)
                {
                    // перевірка яка дія ініціалізованна
                    switch (opfun)
                    {
                        case '+':
                            num_a += num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '-':
                            num_a -= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '*':
                            num_a *= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;
                                    labb.Text += " = " + num_a.ToString() + opfun;
                                    bdisp.Text = num_a.ToString();
                                    num_r = num_b;
                                    num_b = 0;
                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                    opfun = '+';
                    fr = true;
                }
                else
                {
                    flf = true; // флаг наявності дії
                    opfun = '+'; // ініціалізація дії
                    fr = true; // флаг що треба ночинати нове число
                    num_a = num_b;
                    num_r = num_b;
                    num_b = 0;
                    labb.Text += " + ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

        private void k10_Click(object sender, RoutedEventArgs e)
        {
            if (fr)
            {
                bdisp.Text = "0";
                fr = false;
            }
            // переведення тексту TextBox в число, якщо в тексте число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                bdisp.Text += ",";
                labb.Text += ",";
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
                bdisp.Text = "0,";
            }
        }

        private void bPercent_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = labb.Text.Remove(labb.Text.Length - bdisp.Text.Length);
            bdisp.Text = bdisp.Text.Remove(bdisp.Text.Length - bdisp.Text.Length);
            num_b *= num_a / 100;
            labb.Text += Convert.ToString(num_b);
            bdisp.Text = Convert.ToString(num_b);
        }

        private void ksin_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = labb.Text.Remove(labb.Text.Length - bdisp.Text.Length);
            bdisp.Text = bdisp.Text.Remove(bdisp.Text.Length - bdisp.Text.Length);
            num_b = (decimal)Math.Sin((double)num_b * Math.PI / 180);
            num_b = Decimal.Round(num_b, 4);
            labb.Text += Convert.ToString(num_b);
            bdisp.Text = Convert.ToString(num_b);
        }

        private void kcos_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = labb.Text.Remove(labb.Text.Length - bdisp.Text.Length);
            bdisp.Text = bdisp.Text.Remove(bdisp.Text.Length - bdisp.Text.Length);
            num_b = (decimal)Math.Cos((double)num_b * Math.PI / 180);
            num_b = Decimal.Round(num_b, 4);
            labb.Text += Convert.ToString(num_b);
            bdisp.Text = Convert.ToString(num_b);
        }

        private void ktg_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = labb.Text.Remove(labb.Text.Length - bdisp.Text.Length);
            bdisp.Text = bdisp.Text.Remove(bdisp.Text.Length - bdisp.Text.Length);
            num_b = (decimal)Math.Tan((double)num_b * Math.PI / 180);
            num_b = Decimal.Round(num_b, 4);
            labb.Text += Convert.ToString(num_b);
            bdisp.Text = Convert.ToString(num_b);
        }

        private void kctg_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = labb.Text.Remove(labb.Text.Length - bdisp.Text.Length);
            bdisp.Text = bdisp.Text.Remove(bdisp.Text.Length - bdisp.Text.Length);
            num_b = (decimal)(1/Math.Tan((double)num_b * Math.PI / 180));
            num_b = Decimal.Round(num_b, 4);
            labb.Text += Convert.ToString(num_b);
            bdisp.Text = Convert.ToString(num_b);
        }

        private void koct_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = Convert.ToString((int)num_b, 10);
            labb.Text += " OCT [ " + Convert.ToString((int)num_b, 8) + " ] \n";
        }

        private void khex_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = Convert.ToString((int)num_b, 10);
            labb.Text += " HEX [ " + Convert.ToString((int)num_b, 16) + " ] \n";
        }

        private void kbin_Click(object sender, RoutedEventArgs e)
        {
            labb.Text = Convert.ToString((int)num_b, 10);
            labb.Text += " BIN [ " + Convert.ToString((int)num_b, 2) + " ] \n";
        }

        private void kdec_Click(object sender, RoutedEventArgs e)
        {
            bool isBinary = Regex.IsMatch(bdisp.Text, "^[01] +$");
            if (isBinary)
            {
                labb.Text = Convert.ToString(Convert.ToInt32(bdisp.Text, 2));
            }
            else 
            {
                laberror.Content = "Це не бінарний код";
            }
        }

        private void kcan_Click(object sender, RoutedEventArgs e)
        {
            flr = false;
            flf = false;
            fr = false;
            labb.Text = "";
            laberror.Content = "";
            bdisp.Text = "";
            opfun = ' ';
        }

        private void kmnojen_Click(object sender, RoutedEventArgs e)
        {
            // зміна дії після використання кнопки результату
            if (flr)
            {
                flr = false;
                opfun = '*';
                return;
            }
            // перевіряю що в тексте число, та переутворюю його в число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                // якщо раніше було ініциалізованна дія, то цю дію потрибно виконати та ініциалізувати наступну дію
                if (flf)
                {
                    // перевірка яка дія ініціалізованна
                    switch (opfun)
                    {
                        case '+':
                            num_a += num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '-':
                            num_a -= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '*':
                            num_a *= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;
                                    labb.Text += " = " + num_a.ToString() + opfun;
                                    bdisp.Text = num_a.ToString();
                                    num_r = num_b;
                                    num_b = 0;
                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                    opfun = '*';
                    fr = true;
                }
                else
                {
                    flf = true; // флаг наявності дії
                    opfun = '+'; // ініціалізація дії
                    fr = true; // флаг що треба ночинати нове число
                    num_a = num_b;
                    num_r = num_b;
                    num_b = 0;
                    labb.Text += " * ";
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
            if (flf)
            {
                fr = true;
                flr = true;
                switch (opfun)
                {
                    case '+':
                        num_a += num_b;
                        labb.Text += " = " + num_a.ToString();
                        bdisp.Text = num_a.ToString();
                        break;
                    case '-':
                        num_a -= num_b;
                        labb.Text += " = " + num_a.ToString();
                        bdisp.Text = num_a.ToString();
                        break;
                    case '*':
                        num_a *= num_b;
                        labb.Text += " = " + num_a.ToString();
                        bdisp.Text = num_a.ToString();
                        break;
                    case '/':
                        if (num_b != 0)
                        {
                            num_a /= num_b;
                            labb.Text += " = " + num_a.ToString();
     ;
                            bdisp.Text = num_a.ToString();
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
                labb.Text = " Введите знак операции";
                return;
            }
        }

        private void kminus_Click(object sender, RoutedEventArgs e)
        {
            // зміна дії після використання кнопки результату
            if (flr)
            {
                flr = false;
                opfun = '-';
                labb.Text += opfun;
                return;
            }
            // перевіряю що в тексте число, та переутворюю його в число
            bool success = Decimal.TryParse(bdisp.Text, out num_b);
            if (success)
            {
                // якщо раніше було ініциалізованна дія, то цю дію потрибно виконати та ініциалізувати наступну дію
                if (flf)
                {
                    // перевірка яка дія ініціалізованна
                    switch (opfun)
                    {
                        case '+':
                            num_a += num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '-':
                            num_a -= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '*':
                            num_a *= num_b;
                            labb.Text += " = " + num_a.ToString() + opfun;
                            bdisp.Text = num_a.ToString();
                            num_r = num_b;
                            num_b = 0;
                            break;
                        case '/':
                            {
                                if (num_b != 0)
                                {
                                    num_a /= num_b;
                                    labb.Text += " = " + num_a.ToString() + opfun;
                                    bdisp.Text = num_a.ToString();
                                    num_r = num_b;
                                    num_b = 0;
                                }
                                else
                                {
                                    laberror.Content = "Нельзя делить на ноль";
                                }
                                break;
                            }
                        default: break;
                    }
                    opfun = '-';
                    fr = true;
                }
                else
                {
                    flf = true; // флаг наявності дії
                    opfun = '+'; // ініціалізація дії
                    fr = true; // флаг що треба ночинати нове число
                    num_a = num_b;
                    num_r = num_b;
                    num_b = 0;
                    labb.Text += " - ";
                }
            }
            else
            {
                laberror.Content = "Значение в поле есть недопустимое число";
            }
        }

    }
    
}
