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
using System.Windows.Shapes;

namespace wishlister
{
    /// <summary>
    /// Логика взаимодействия для Adder.xaml
    /// </summary>
    public partial class Adder : Window
    {
        public static MainWindow mw = new MainWindow();
        public Adder(MainWindow mainWindow)
        {
            InitializeComponent();
            mw = mainWindow;
        }

        private void OnClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Wishes.wishlist.Add(new Wish(NameBox.Text, PriceBox.Text, mw));
            mw.UpdateWishStack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
