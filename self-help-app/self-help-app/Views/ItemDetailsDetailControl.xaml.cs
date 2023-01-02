using System;

using self_help_app.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace self_help_app.Views
{
    public sealed partial class ItemDetailsDetailControl : UserControl
    {
        public SampleOrder ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SampleOrder; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SampleOrder), typeof(ItemDetailsDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public ItemDetailsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ItemDetailsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
