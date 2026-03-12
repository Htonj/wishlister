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
        public static MainWindow mw = new MainWindow();
        public Wish(string names, string prices, MainWindow mainWindow)
        {
            InitializeComponent();
            price.Content = prices;
            namexD.Content = names;
            mw = mainWindow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parent = (StackPanel)this.Parent;
            if (parent != null)
            {
                mw.WishStack.Children.Remove(this);
            }
            AddMoney addMoney = new AddMoney(this);
            addMoney.Show();
        }
        public void UpdateProgressBar(int newMoney)
        {
            var parent = (StackPanel)this.Parent;
            if (parent != null)
            {
                parent.Children.Remove(this);
            }
            Wishes.wishlist.Add(this);
            mw.UpdateWishStack();
            MoneyPB.Value = newMoney / Convert.ToInt32(price.Content) * 100;
        }
        private void Button_ClickClose(object sender, RoutedEventArgs e)
        {

            Wishes.wishlist.RemoveAt(Wishes.wishlist.Count-1);
            mw.UpdateWishStack();
        }
    }
}
