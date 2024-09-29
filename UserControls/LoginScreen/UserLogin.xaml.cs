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
using WPF_BankApp.Resources.Scripts;

namespace WPF_BankApp.UserControls.LoginScreen
{
    /// <summary>
    /// Interação lógica para UserLogin.xam
    /// </summary>
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            // * Pegar informações Email.
            // * Pegar informações Senha.
            // * Verificar informações
            // - Existe no banco de dados ? Passa para proxima janela com informações do usuario : Informa ao usuario que algo está errado; 
        }
    }
}
