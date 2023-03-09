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

namespace _3ISP918VB_FEDIN_NESMELOV.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public object Context { get; private set; }

        public AuthWindow()
        {
            InitializeComponent();
        }


        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = Context.User_Account.ToList()
                .Where(i => i.Login == TbLogin.Text &&
                i.Password == PbPassword.Password)
                .FirstOrDefault();

            if (userAuth != null)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistrationUserWindow registrationUserWindow = new RegistrationUserWindow();
            registrationUserWindow.Show();
            this.Close();
        }

        private new void Close()
        {
            throw new NotImplementedException();
        }
    }
}
