using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF_BankApp.UserControls.Components.TextBox
{
    /// <summary>
    /// Interação lógica para UserPasswordBox.xam
    /// </summary>
    public partial class UserPasswordBox : UserControl
    {
        public UserPasswordBox()
        {
            DataContext = this;
            InitializeComponent();
            UserPasswordView.Visibility = Visibility.Hidden;
        }

        private string textPassword;

        private string textPlaceholder;

        public string TextPlaceholder
        {
            get { return textPlaceholder; }
            set
            {
                textPlaceholder = value;
                TextTemplate.Text = textPlaceholder;
            }
        }

        private string password;

        public string PasswordValue
        {
            get { return password; }
            set { 
                password = value;
                OnTextChange();
                UserPasswordView.Text = PasswordText(PasswordValue);
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnTextChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void tb_UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(tb_UserInput.Text))
            {
                TextTemplate.Visibility = Visibility.Visible;
                UserPasswordView.Visibility = Visibility.Hidden;
                return;
            }

            TextTemplate.Visibility = Visibility.Hidden;
            UserPasswordView.Visibility = Visibility.Visible;
        }

        private string PasswordText(string password)
        {
            textPassword = "";

            for (int i = 0; i < password.Length; i++)
            {
                textPassword += "*";
            }

            return textPassword;
        }
    }
}
