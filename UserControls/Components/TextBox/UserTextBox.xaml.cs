using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WPF_BankApp.UserControls.Components.TextBox
{
    /// <summary>
    /// Interação lógica para UserTextBox.xam
    /// </summary>
    public partial class UserTextBox : UserControl, INotifyPropertyChanged
    {
        public UserTextBox()
        {
            InitializeComponent();
        }

        private string textPlaceholder;

        public string TextPlaceholder
        {
            get { return textPlaceholder; }
            set { textPlaceholder = value;
                TextTemplate.Text = textPlaceholder;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnTextChange([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void tb_UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_UserInput.Text))
            {
                TextTemplate.Visibility = Visibility.Visible;
                return;
            }

            TextTemplate.Visibility = Visibility.Hidden;
        }
    }
}
