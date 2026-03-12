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
    /// Логика взаимодействия для AddMoney.xaml
    /// </summary>
    public partial class AddMoney : Window
    {
        public static MainWindow mw = new MainWindow();
        public static Wish wi = new Wish("qwe", "123", mw);
        public AddMoney(Wish wish)
        {
            InitializeComponent();
            wi = wish;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wi.UpdateProgressBar(Convert.ToInt32(PriceBox.Text));
            this.Close();
        }
    }
}
