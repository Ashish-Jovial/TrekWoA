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
using TrekWoAProductsPortal.ViewModel;

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
            //Implementation of viewModel, ProductViewModel can be use.
            //this.DataContext = new ProductViewModel();
        }

        private void LoadProducts()
        {
            ProductModel models = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));

            //models.product = new List<Product>()
            //{
            //    new Product()
            //    {
            //        title = "Trek Bike",
            //        image = new Model.Image() { src = "/Assets/trek_emonda.jpg" },
            //        variants = new List<Variant>() { new Variant() { price = "200.00" } }
            //    },
            //    new Product()
            //    {
            //        title = "Trek Bike Emonda",
            //        image = new Model.Image() { src = "/Assets/trek_emonda.jpg" },
            //        variants = new List<Variant>() { new Variant() { price = "300.00" } }
            //    }
            //};

            if (models != null)
            {
                thisApp.productsCollection.Add(models);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
