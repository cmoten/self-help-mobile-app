using System;

using self_help_app.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace self_help_app.Views
{
    public sealed partial class ItemsPage : Page
    {
        public ItemsViewModel ViewModel { get; } = new ItemsViewModel();

        public ItemsPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
