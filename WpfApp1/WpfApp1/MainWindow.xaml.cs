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

namespace rectangleColor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] order = new string[4];
        //public Binding OrderSummaryBinding = new Binding("Description");

        
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void AddSugarCream_Click(object sender, RoutedEventArgs e)
        {
            if (AddSugar.IsChecked == true && AddCream.IsChecked == true)
            {
                order[2] = "with cream and sugar.";
                
            }
            else if (AddSugar.IsChecked == true && AddCream.IsChecked == false)
            {
                order[2] = "with sugar.";
               
            }
            else if (AddSugar.IsChecked == false && AddCream.IsChecked == true)
            {
                order[2] = "with cream.";
               
            }
            else
            {
                order[2] = ".";
                
            }

        }

        private void OrderCoffee_Click(object sender, RoutedEventArgs e)
        {
           
            OrderSummary.Text = "";
            for (int i = 0; i < order.Length; i++)
            {
                OrderSummary.Text += order[i];
            }

        }
        private void Latte_Selected(object sender, RoutedEventArgs e)
        {
            order[1] = $"{Latte.Content} ";
           
        }
        private void Espresso_Selected(object sender, RoutedEventArgs e)
        {
            order[1] = $"{Espresso.Content} ";
            
        }

        private void Macchiato_Selected(object sender, RoutedEventArgs e)
        {
            order[1] = $"{Macchiato.Content} ";
            
        }

        private void Americano_Selected(object sender, RoutedEventArgs e)
        {
            order[1] = $"{Americano.Content} ";
            
        }

        private void Cappucino_Selected(object sender, RoutedEventArgs e)
        {
            order[1] = $"{Cappuccino.Content} ";
            
        }

        private void CoffeeSmall_Click(object sender, RoutedEventArgs e)
        {
            order[0] = $"{CoffeeSmall.Content} ";
            
        }

        private void CoffeeMedium_Click(object sender, RoutedEventArgs e)
        {
            order[0] = $"{CoffeeMedium.Content} ";
            
        }

        private void CoffeeLarge_Click(object sender, RoutedEventArgs e)
        {
            order[0] = $"{CoffeeLarge.Content} ";
           
        }
    } 
}  // public class Coffee
{

}