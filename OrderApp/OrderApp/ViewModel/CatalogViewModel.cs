using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using OrderApp.Model;
using OrderApp.Service;

namespace OrderApp.ViewModel
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        ProductService productService;
        public CatalogViewModel()
        {
            productService = new ProductService();
            PromotionService promotionService = new PromotionService();
            var promotions = promotionService.GetPromotions();
            Products = new ObservableCollection<Product>(productService.GetProducts());
        }

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged("Products");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nome)
        {
            try
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nome));
            }
            catch (Exception e)
            {

            }

        }
    }
}
