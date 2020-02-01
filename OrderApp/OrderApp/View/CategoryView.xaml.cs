using System;
using System.Collections.Generic;
using OrderApp.ViewModel;
using Xamarin.Forms;

namespace OrderApp.View
{
    public partial class CategoryView : ContentPage
    {
        CategoryViewModel categoryVM;
        public CategoryView()
        {
            categoryVM = new CategoryViewModel();
            BindingContext = categoryVM;
            InitializeComponent();
        }
    }
}
