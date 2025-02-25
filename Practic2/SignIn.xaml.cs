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
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newLogin = tbxNewLogin.Text;
            string newPassword = tbxNewPassword.Text;

            MessageBox.Show("Зарегистрирован", "Успешно", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            Window window = new Profile();
            window.Show();
            this.Close();
        }

    }
}

