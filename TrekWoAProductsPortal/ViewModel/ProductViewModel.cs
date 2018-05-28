using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrekWoAProductsPortal.HelperClasses;
using TrekWoAProductsPortal.Model;
using System.Windows;

namespace TrekWoAProductsPortal.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        App thisApp = (App)Application.Current;
        private ObservableCollection<ProductModel> _shopifyProductViewModel = new ObservableCollection<ProductModel>();
        public ObservableCollection<ProductModel> ShopifyProductViewModel
        {
            get { return _shopifyProductViewModel; }
            set
            {
                _shopifyProductViewModel = value;
                RaisePropertyChanged("ShopifyProductViewModel");
            }
        }
        public ProductViewModel()
        {
            ProductModel models = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));
            if (models != null)
            {
            }
            ShopifyProductViewModel = new ObservableCollection<ProductModel>();
            ProductModel recrods = models as ProductModel;
            ShopifyProductViewModel.Add(recrods);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
