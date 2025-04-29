using System.Windows;
using System.Windows.Controls;

namespace WPF_MultiStepForm
{
    public partial class Page1_PersonalData : Page
    {
        private MainWindow _main;

        public Page1_PersonalData(MainWindow main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(LastName.Text))
            {
                MessageBox.Show("Введите имя и фамилию.");
                return;
            }

            _main.UserData.FirstName = FirstName.Text;
            _main.UserData.LastName = LastName.Text;
            _main.UserData.BirthDate = BirthDate.SelectedDate;

            NavigationService.Navigate(new Page2_ContactData(_main));
        }
    }
}
