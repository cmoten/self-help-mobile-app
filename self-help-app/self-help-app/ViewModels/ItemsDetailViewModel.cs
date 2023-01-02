using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;

using self_help_app.Core.Models;
using self_help_app.Core.Services;

namespace self_help_app.ViewModels
{
    public class ItemsDetailViewModel : ObservableObject
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public ItemsDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
