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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += WpfApp_Loaded;
        }
        String[] str = { "CE", "C", "<", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", ".","0" };
        Button btn = new Button();
        private void WpfApp_Loaded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Button[] btns = new Button[18];
            for (int i = 0; i < btns.Length; i++)
            {
                var r = rnd.Next(0, str.Length);
                btn = new Button
                {
                    FontSize = 40,
                    Content = str[i],
                    //Content = str[r], Пример произвольного взятия названия из списка названий.
                    Margin = new Thickness(2, 2, 2, 2),
                    //Foreground = new SolidColorBrush(color[r]) Пример произвольного взятия цвета из списка цветов.
                    Name = "button" + i.ToString(),
                };
                gridKeboard.Children.Add(btn);
                switch (i)
                {
                    case 0:
                        btn.Click += button0_Click;
                        break;
                    case 4:
                        btn.Click += button4_Click;
                        break;
                    case 5:
                        btn.Click += button5_Click;
                        break;
                    case 6:
                        btn.Click += button6_Click;
                        break;
                    case 8:
                        btn.Click += button8_Click;
                        break;
                    case 9:
                        btn.Click += button9_Click;
                        break;
                    case 10:
                        btn.Click += button10_Click;
                        break;
                    case 12:
                        btn.Click += button12_Click;
                        break; 
                    case 13:
                        btn.Click += button13_Click;
                        break;
                    case 14:
                        btn.Click += button14_Click;
                        break;
                }
                   
                if (i<=3)
                {
                    Grid.SetColumn(btn, i);
                    Grid.SetRow(btn, 0);
                }
                else if(i>3 && i<=7)
                {
                    Grid.SetColumn(btn, i-4);
                    Grid.SetRow(btn, 1);
                }
                else if(i>7 && i<=11)
                {
                    Grid.SetColumn(btn, i - 8);
                    Grid.SetRow(btn, 2);
                }
                else if (i>11 && i<=15)
                {
                    Grid.SetColumn(btn, i - 12);
                    Grid.SetRow(btn, 3);
                }
                else if (i>15 && i<=18)
                {
                    Grid.SetColumn(btn, i - 16);
                    Grid.SetRow(btn, 4);
                }
            }
            var btnResult = new Button
            {
                FontSize = 40,
                Content = "=",
                Margin = new Thickness(2, 2, 2, 2),
                Name = "button18"
            };
            gridKeboard.Children.Add(btnResult);
            Grid.SetColumn(btnResult, 2);
            Grid.SetRow(btnResult, 4);
            Grid.SetColumnSpan(btnResult, 2);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlock.Text = textBox.Text;
        }
        private void button0_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text = "0";
                textBlock.Text = "";
            }
        }
        private void button4_Click(object send, RoutedEventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "7";
        } 
        private void button5_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "8";
        }
        private void button6_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "9";
        }
        private void button8_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "4";
        }
        private void button9_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "5";
        }
        private void button10_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "6";
        }
         private void button12_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "1";
        }
         private void button13_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "2";
        }
         private void button14_Click(object send, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += "3";
        }

    }
}
