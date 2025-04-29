using System.Windows;

namespace WPF_MultiStepForm
{
    public partial class MainWindow : Window
    {
        public UserData UserData { get; set; } = new UserData();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1_PersonalData(this));
        }
    }
}
