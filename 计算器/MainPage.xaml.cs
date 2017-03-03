using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace 计算器
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            if(error.Visibility == Visibility)
            {
                return;
            }
            if(textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(1);
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(2);
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(3);
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(4);
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(5);
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(6);
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(7);
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(8);
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(9);
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Length == 1 & textBlock1.Text[0] == '0')
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += Convert.ToString(0);
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            int i = 0;
            int j = 0;
            if(textBlock1.Text[textBlock1.Text.Length-1] == '.' || 
                textBlock1.Text[textBlock1.Text.Length-1] == '+' ||
                textBlock1.Text[textBlock1.Text.Length-1] == '-' ||
                textBlock1.Text[textBlock1.Text.Length-1] == '*' ||
                textBlock1.Text[textBlock1.Text.Length-1] == '%' )
            {
                return;
            }
            for(i=0;i<textBlock1.Text.Length; i++)
            {
                if(textBlock1.Text[i] == '.')
                {
                    j = i;
                }
            }
            for(i=j;i<textBlock1.Text.Length;i++)
            {
                if(textBlock1.Text[i] == '.')
                {
                    return;
                }
            }
            textBlock1.Text += ".";
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            if(textBlock1.Text.Length == 1)
            {
                textBlock1.Text = "0";
            }
            else
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            if (error.Visibility == Visibility)
            {
                textBlock1.Text = "0";
                error.Visibility = Visibility.Collapsed;
            }
        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "0";
            error.Visibility = Visibility.Collapsed;
        }

        private void op1_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "+" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "-" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "*" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "%" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == ".")
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
                textBlock1.Text += "+";
        }

        private void op2_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "+" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "-" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "*" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "%" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == ".")
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += "-";
        }

        private void op3_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "+" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "-" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "*" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "%" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == ".")
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += "*";
        }

        private void op4_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            if (textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "+" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "-" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "*" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "%" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == ".")
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += "%";
        }

        private void op5_Click(object sender, RoutedEventArgs e)
        {
            if (error.Visibility == Visibility)
            {
                return;
            }
            double sum = 0;
            int i = 0;
            if (textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "+" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "-" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "*" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == "%" ||
                textBlock1.Text.Substring(textBlock1.Text.Length - 1, 1) == ".")
            {
                textBlock1.Text = textBlock1.Text.Substring(0, textBlock1.Text.Length - 1);
            }
            textBlock1.Text += "=";
            if(history.Text == "无历史记录")
            {
                history.Text = textBlock1.Text;
            }
            else
            {
                history.Text += "\r\n" + textBlock1.Text;
            }
            sum = result(textBlock1.Text); 
            for (i=0;i<textBlock1.Text.Length;i++)
            {
                if(textBlock1.Text[i] == '%')
                {
                    if(textBlock1.Text[i+1] == '0')
                    {
                        if (textBlock1.Text[i + 2] != '.')
                        {
                            error.Visibility = Visibility;
                            return;
                        }
                    }
                }
            }
            textBlock1.Text = sum.ToString();
            history.Text += textBlock1.Text;
        }

        public double result(string str)
        {
            float sum = 0;
            int i, j = 0, k = 0;
            int op1 = 0, op2 = 0, op3 = 0;
            int a = 1;
            int flag = 0;
            float num0 = 0, num1 = 0, num2 = 0;
            do
            {
                j = 0;
                for (i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '%')
                    {
                        j++;
                    }
                }
                if (str[0] == '-')
                {
                    j--;
                }
                if (j == 0)
                {
                    if (str[0] == '-')
                    {
                        sum = float.Parse(str.Substring(1, str.Length - 2));
                        sum = -sum;
                    }
                    else
                    {
                        sum = float.Parse(str.Substring(0, str.Length - 1));
                    }
                    return sum;
                }
                if (j == 1)
                {
                    if (str[0] == '-')
                    {
                        str = str.Substring(1, str.Length - 1);
                        flag = 1;
                    }
                    for (i = 0; i < str.Length - 1; i++)
                    {
                        if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '%')
                        {
                            op1 = i;
                            num0 = float.Parse(str.Substring(0, op1));
                            num1 = float.Parse(str.Substring(op1 + 1, str.Length - 2 - op1));
                            if (flag == 1)
                            {
                                num0 = -num0;
                            }
                            if (str[op1] == '+') sum = num0 + num1;
                            else if (str[op1] == '-') sum = num0 - num1;
                            else if (str[op1] == '*') sum = num0 * num1;
                            else if (str[op1] == '%') sum = num0 / num1;
                            str = sum.ToString();
                            return sum;
                        }
                    }
                }
                else
                {
                    j = 0;
                    if (str[0] == '-')
                    {
                        str = str.Substring(1, str.Length - 1);
                        flag = 1;
                    }
                    for (i = 0; i < str.Length - 1; i++)
                    {
                        if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '%')
                        {
                            j++;
                            if (j == 1 )
                            {
                                num0 = float.Parse(str.Substring(0, i));
                                op1 = i;
                                if (flag == 1)
                                {
                                    num0 = -num0;
                                }
                            }
                            if (j == 2)
                            {
                                op2 = i;
                                num1 = float.Parse(str.Substring(op1+1, op2 - op1 - 1));
                                if ((str[op1] == '+' || str[op1] == '-') && (str[op2] == '*' || str[op2] == '%'))
                                {
                                    for (k = op2 + 1; k < str.Length - 1; k++)
                                    {
                                        if (str[k] == '+' || str[k] == '-' || str[k] == '*' || str[k] == '%')
                                        {
                                            break;
                                        }
                                    }
                                    op3 = k;
                                    num2 = float.Parse(str.Substring(op2 + 1, op3 - op2 - 1));
                                    if (str[op2] == '+') sum = num1 + num2;
                                    else if (str[op2] == '-') sum = num1 - num2;
                                    else if (str[op2] == '*') sum = num1 * num2;
                                    else if (str[op2] == '%') sum = num1 / num2;
                                    str = str = str.Substring(0, op1 + 1) + sum.ToString() + str.Substring(op3, str.Length - op3);
                                }
                                else
                                {
                                    if (str[op1] == '+') sum = num0 + num1;
                                    else if (str[op1] == '-') sum = num0 - num1;
                                    else if (str[op1] == '*') sum = num0 * num1;
                                    else if (str[op1] == '%') sum = num0 / num1;
                                    str = sum.ToString() + str.Substring(op2, str.Length - op2);
                                }
                            }
                        }
                    }
                }
            } while (a == 1);
            return sum;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if(history.Visibility == Visibility.Collapsed)
            {
                history.Visibility = Visibility.Visible;
                hisGround.Visibility = Visibility.Visible;
                hisviewer.Visibility = Visibility.Visible;
            }
            else if (history.Visibility == Visibility.Visible)
            {
                history.Visibility = Visibility.Collapsed;
                hisGround.Visibility = Visibility.Collapsed;
                hisviewer.Visibility = Visibility.Collapsed;
            }
        }
    }
}
