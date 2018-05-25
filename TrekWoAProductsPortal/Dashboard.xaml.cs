using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrekWoAProductsPortal.HelperClasses;
using TrekWoAProductsPortal.Model;

namespace TrekWoAProductsPortal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        App thisApp = (App)Application.Current;
        public ObservableCollection<ProductModel> ProductsCollection
        { get { return thisApp.productsCollection; } }
        public Dashboard()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductModel models = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));
            if (models != null)
            {
                thisApp.productsCollection.Add(models);
            }
        }
    }
}
