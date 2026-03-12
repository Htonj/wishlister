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
        private Wish _wish;
        private MainWindow _mainWindow;

        public AddMoney(Wish wish, MainWindow mainWindow)
        {
            InitializeComponent();
            _wish = wish;
            _mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PriceBox.Text, out int money))
            {
                _wish.UpdateProgressBar(money);
            }
            this.Close();
        }
    }
}
