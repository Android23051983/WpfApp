using System;
using System.Collections;
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

namespace WpfApp
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
        String[] str = { "Navy", "Blue", "Aqua", "Teal", "Olive", "Green", "Lime", "Yellow", "Orange", "Red", "Maroon", "Fuchsia", "Purple", "Black", "Silver", "Gray", "White" };

        public Color[] color = new Color[]
        {
            Colors.Navy,
            Colors.Blue,
            Colors.Aqua,
            Colors.Teal,
            Colors.Olive,
            Colors.Green,
            Colors.Lime,
            Colors.Yellow,
            Colors.Orange,
            Colors.Red,
            Colors.Maroon,
            Colors.Fuchsia,
            Colors.Purple,
            Colors.Black, 
            Colors.Silver,
            Colors.Gray,
            Colors.White
        };
        private void WpfApp_Loaded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Button[] btns = new Button[17];
            for (int i = 0; i < btns.Length; i++)
            {
                var r = rnd.Next(0, str.Length);
                var btn = new Button
                {
                    FontSize = 20,
                    Content = str[i],
                    //Content = str[r], Пример произвольного взятия названия из списка названий.
                    Margin = new Thickness(2, 2, 2, 2),            
                    Foreground = new SolidColorBrush(color[i]),
                    //Foreground = new SolidColorBrush(color[r]) Пример произвольного взятия цвета из списка цветов.
                };
                wrapPanel.Children.Add(btn);
            }
        }


    }
}
