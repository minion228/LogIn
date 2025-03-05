using Practic2.Interfaces;
using Practic2.Logic;
using Practic2.ModelDB;
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

namespace Practic2
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        private List<IProduct>_products= new List<IProduct>();
        public Profile()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxPrice.Text) || string.IsNullOrEmpty(tbxDescr.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK);
                return;
            }
            if(!decimal.TryParse(tbxPrice.Text,out decimal price))
            {
                MessageBox.Show("Введите цену", "Ошибка", MessageBoxButton.OK);
                tbxPrice.Text=string.Empty;
                return;
            }

            var product = new Product()
            {
                Description = tbxDescr.Text,
                Name = tbxName.Text,
                Price = price,
            };
            _products.Add(product);

            lstbx.ItemsSource = null;

            lstbx.ItemsSource = _products;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window wind=new DataGrid1();
            wind.Show();
            this.Close();
        }

    }
}
