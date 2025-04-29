using System.Windows;
using System.Windows.Controls;

namespace WPF_MultiStepForm
{
    public partial class Page3_Address : Page
    {
        private MainWindow _main;

        public Page3_Address(MainWindow main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(City.Text) || string.IsNullOrWhiteSpace(Street.Text) || string.IsNullOrWhiteSpace(House.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля адреса.");
                return;
            }

            _main.UserData.City = City.Text;
            _main.UserData.Street = Street.Text;
            _main.UserData.HouseNumber = House.Text;
            _main.UserData.ApartmentNumber = Apartment.Text;

            var data = _main.UserData;
            MessageBox.Show(
                $"Имя: {data.FirstName} {data.LastName}\n" +
                $"Дата рождения: {data.BirthDate:d}\n" +
                $"Email: {data.Email}\n" +
                $"Телефон: {data.Phone}\n" +
                $"Адрес: {data.City}, {data.Street}, {data.HouseNumber}, кв. {data.ApartmentNumber}");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
