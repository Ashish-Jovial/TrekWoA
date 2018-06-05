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
        public readonly string stroe_url = "ashishstoretrex.myshopify.com";
        public readonly string api_key = "8859c541a708d5b191d215d6f98a0cf9";
        public readonly string password = "6a1134f0d94c9f930a98444c322292bb";
        public product currentProduct;
        public System.Collections.ObjectModel.ObservableCollection<product> productsCollection = new System.Collections.ObjectModel.ObservableCollection<product>();
        public string GetFullUrl(string apiPath)
        {
            string fullUrl = "";
            if(string.IsNullOrEmpty(apiPath))
            {
                fullUrl = stroe_url;
            }
            else
            {
                fullUrl = stroe_url + apiPath;
            }
            return fullUrl;
        }

        private void EventTrigger_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}
