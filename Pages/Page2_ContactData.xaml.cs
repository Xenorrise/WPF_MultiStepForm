using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WPF_MultiStepForm
{
    public partial class Page2_ContactData : Page
    {
        private MainWindow _main;

        public Page2_ContactData(MainWindow main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Неверный формат email.");
                return;
            }

            if (!Regex.IsMatch(Phone.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Неверный формат телефона.");
                return;
            }

            _main.UserData.Email = Email.Text;
            _main.UserData.Phone = Phone.Text;

            NavigationService.Navigate(new Page3_Address(_main));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
