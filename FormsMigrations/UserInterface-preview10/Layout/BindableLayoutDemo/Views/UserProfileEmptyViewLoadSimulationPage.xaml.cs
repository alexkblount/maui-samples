using System.Threading.Tasks;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using BindableLayoutDemo.ViewModels;
using System.Collections.ObjectModel;

namespace BindableLayoutDemo.Views
{
    public partial class UserProfileEmptyViewLoadSimulationPage : ContentPage
    {
        public UserProfileEmptyViewLoadSimulationPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);

            UserProfileViewModel viewModel = BindingContext as UserProfileViewModel;
            viewModel.UserWithoutAchievements.ObservableAchievements = new ObservableCollection<string>()
            {
                "\uf2d2", "\uf2ba", "\uf30c"
            };
        }
    }
}

