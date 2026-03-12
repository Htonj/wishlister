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

namespace wishlister
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateWishStack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adder adder = new Adder(this);
            adder.Show();
        }
        public void UpdateWishStack()
        {
            WishStack.Children.Clear();
            foreach (Wish w in Wishes.wishlist)
                WishStack.Children.Add(w);
        }
    }
}
