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
        private ObservableCollection<Product> _shopifyProductViewModel = new ObservableCollection<Product>();
        public ObservableCollection<Product> ShopifyProductViewModel
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
            List<Product> models = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));
            if (models != null)
            {
                List<Product> recrods = models as List<Product>;
                ShopifyProductViewModel = new ObservableCollection<Product>();
                foreach (var record in recrods)
                {
                    ShopifyProductViewModel.Add(record);
                }
            }
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
