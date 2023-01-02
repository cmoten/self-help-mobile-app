using System;

using self_help_app.ViewModels;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace self_help_app.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
