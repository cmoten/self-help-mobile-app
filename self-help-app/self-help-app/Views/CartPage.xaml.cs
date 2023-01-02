using System;

using self_help_app.ViewModels;

using Windows.UI.Xaml.Controls;

namespace self_help_app.Views
{
    public sealed partial class CartPage : Page
    {
        public CartViewModel ViewModel { get; } = new CartViewModel();

        public CartPage()
        {
            InitializeComponent();
        }
    }
}
