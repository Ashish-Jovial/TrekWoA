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
        Window darkWindow = null;
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
           // MakeDarkWindow(true);
            popupProduct.IsOpen = true;

        }

        private void AddProduct_ClosePopup(object sender, EventArgs e)
        {
            //MakeDarkWindow(false);
            popupProduct.IsOpen = false;
            addProductControl.productName = "";
            addProductControl.productPrice = "";
        }
        public void MakeDarkWindow(bool status)
        {
            darkWindow = new Window()
            {
                Background = Brushes.Black,
                Opacity = 0.7,
                AllowsTransparency = true,
                WindowStyle = WindowStyle.None,
                Height = this.Height,
                Width = this.Width,
                Topmost = true
            };
            if (status == true)
            {
                darkWindow.Show();
            }
            else
            {
                darkWindow.Topmost = false;
                darkWindow.Close();
            }
        }

        private void addProductControl_NewProduct(object sender, EventArgs e)
        {
            // Step 1, call product POST API here.
            // Step 2, wait for response.
            // Step 3, response received update the observableCollection with new data.
        }
    }
}
