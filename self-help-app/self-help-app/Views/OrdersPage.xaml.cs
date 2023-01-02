using System;

using self_help_app.ViewModels;

using Windows.UI.Xaml.Controls;

namespace self_help_app.Views
{
    public sealed partial class OrdersPage : Page
    {
        public OrdersViewModel ViewModel { get; } = new OrdersViewModel();

        public OrdersPage()
        {
            InitializeComponent();
        }
    }
}
