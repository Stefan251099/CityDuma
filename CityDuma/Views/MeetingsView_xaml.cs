using CityDuma.Services;
using CityDuma.ViewModels;
using System.Windows.Controls;

namespace CityDuma.Views
{
    /// <summary>
    /// Логика взаимодействия для MeetingsView.xaml
    /// </summary>
    public partial class MeetingsView : Page
    {
        public MeetingsView()
        {
            InitializeComponent();

            var errorDialogService = new ErrorDialogService();

            DataContext = new MeetingsViewModel(errorDialogService);
        }
    }
}
