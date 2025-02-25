using Practic2.Interfaces;
using Practic2.Logic;
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

namespace Practic2
{

    public partial class MainWindow : Window
    {
        private IAuth _auth;
        public MainWindow()
        {
            InitializeComponent();
            _auth = new Auth();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login=tbxLogin.Text.Trim();
            string password=tbxPassword.Text.Trim();
            if (_auth.Check(login, password))
            {
                Window window = new Profile();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButton.OK);
                tbxLogin.Text = string.Empty;
                tbxPassword.Text = string.Empty;
            }
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            Window signIn = new SignIn();
            signIn.Show();
            this.Close();
        }
    }
}
