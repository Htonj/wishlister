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
    /// Логика взаимодействия для Wish.xaml
    /// </summary>
    public partial class Wish : UserControl
    {
        private MainWindow _mainWindow;

        public Wish(string names, string prices, MainWindow mainWindow)
        {
            InitializeComponent();
            price.Content = prices;
            namexD.Content = names;
            _mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addMoney = new AddMoney(this, _mainWindow);
            addMoney.Show();
        }

        public void UpdateProgressBar(int newMoney)
        {
            if (_mainWindow == null) return;

            int targetPrice = Convert.ToInt32(price.Content);
            MoneyPB.Value = (newMoney * 100) / targetPrice;

            
            _mainWindow.UpdateWishStack();
        }

        private void Button_ClickClose(object sender, RoutedEventArgs e)
        {
            Wishes.wishlist.Remove(this);
            _mainWindow?.UpdateWishStack();
        }
    }
}
