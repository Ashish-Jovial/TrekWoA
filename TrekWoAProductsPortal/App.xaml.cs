using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrekWoAProductsPortal.Model;

namespace TrekWoAProductsPortal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public readonly string stroe_url = "trek-bikes.myshopify.com";
        public readonly string api_key = "67b9a85c8758934ab576f76e0daec9cf";
        public readonly string password = "a5c2e67de6376e3cc76f54191155f93a";
        public Product currentProduct;
        public System.Collections.ObjectModel.ObservableCollection<Product> productsCollection = new System.Collections.ObjectModel.ObservableCollection<Product>();
        public string GetFullUrl(string apiPath)
        {
            string fullUrl = "";
            if(string.IsNullOrEmpty(apiPath))
            {
                fullUrl = "trek-bikes.myshopify.com";
            }
            else
            {
                fullUrl = "trek-bikes.myshopify.com" + apiPath;
            }
            return fullUrl;
        }

        private void EventTrigger_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}
