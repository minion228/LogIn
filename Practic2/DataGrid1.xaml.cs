using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Practic2.Logic;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Practic2.ModelDB;

namespace Practic2
{
    /// <summary>
    /// Логика взаимодействия для DataGrid1.xaml
    /// </summary>
    public partial class DataGrid1 : Window
    {
        public DataGrid1()
        {
            InitializeComponent();
            LoadData();
            
        }
        private readonly ShopDBEntities dbContext = new ShopDBEntities();

        private void LoadData()
        {

            try
            {
                var products = dbContext.Products.ToList();
                ProductsDataGrid.ItemsSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Profile();
            w.Show();
            this.Close();
        }
    }
}
