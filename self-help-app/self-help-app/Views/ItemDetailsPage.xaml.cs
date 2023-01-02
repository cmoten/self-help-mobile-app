using System;

using self_help_app.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace self_help_app.Views
{
    public sealed partial class ItemDetailsPage : Page
    {
        public ItemDetailsViewModel ViewModel { get; } = new ItemDetailsViewModel();

        public ItemDetailsPage()
        {
            InitializeComponent();
            Loaded += ItemDetailsPage_Loaded;
        }

        private async void ItemDetailsPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
        }
    }
}
