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
        static public List<Wish> wishes = new List<Wish>();
        public MainWindow()
        {
            InitializeComponent();
            //debug
            wishes.Add(new Wish("jhadfkjhs", "5478$"));
            wishes.Add(new Wish("jauka nsdkja", "1$"));
            wishes.Add(new Wish("'alisdan dkdls'", "467$"));
            foreach (Wish wish in wishes) {
                WishStack.Children.Add(wish);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adder adder = new Adder();
            adder.Show();
        }
    }
}
