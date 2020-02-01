using System;
using System.Collections.Generic;
using System.Globalization;
using OrderApp.ViewModel;
using Xamarin.Forms;

namespace OrderApp.View
{
    public partial class CatalogView : ContentPage
    {
        CatalogViewModel catalogVM;
        public CatalogView()
        {
            
            catalogVM = new CatalogViewModel();
            BindingContext = catalogVM;
            InitializeComponent();
            var item = new ToolbarItem
            {
                IconImageSource = "filter.png",
                Order = ToolbarItemOrder.Primary,
                Priority = 0
            };
            item.Clicked += ShowCategorys;
            ToolbarItems.Add(item);
        }

        public async void ShowCategorys(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new CategoryView(), true);
        }
    }
}
