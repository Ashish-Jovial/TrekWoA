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
        Product EditProduct = new Product();
        Window darkWindow = null;
        public int totalProducts = 0;
        App thisApp = (App)Application.Current;
        public ObservableCollection<Product> ProductsCollection
        { get { return thisApp.productsCollection; } }
        public Dashboard()
        {
            InitializeComponent();
            LoadProducts();
            CountProducts();
            //Implementation of viewModel, ProductViewModel can be use.
            //this.DataContext = new ProductViewModel();
        }

        private void CountProducts()
        {
            Product product = new Product();
            int count = ShopifyRequests.GetProductCount(thisApp.api_key, thisApp.password, thisApp.GetFullUrl("/admin/products/count.json"));
        }

        private void LoadProducts()
        {
            List<Product> newRecords = new List<Product>();
            newRecords = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));
            if (newRecords != null)
            {
                totalProducts = thisApp.productsCollection.Count();
                foreach (var x in newRecords)
                {
                    thisApp.productsCollection.Add(x);
                }
            }
        }
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadProducts();
            CountProducts();
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
            Products products = new Products()
            {
                product = new Product()
                {
                    Title = addProductControl.productName,
                }
            };
            bool isCreated = ShopifyRequests.CreateProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), products);
            if (isCreated == true)
            {
                //thisApp.productsCollection.Add(newProduct);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            popupProduct.IsOpen = true;
            if (popupProduct.IsOpen == true)
            {
                EditProduct = (sender as Button).Tag as Product;
                addProductControl.productName = EditProduct.Title;
                addProductControl.id = EditProduct.Id;
                addProductControl.buttonStatus = "Update";
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Take the object and it's ID.
            //Create a product object with ID 
            //call the api for deleting the record
            // Remove from the observableCollection.
            //Product btn = (sender as Button).Tag;
            Product productObject = (sender as Button).Tag as Product;
            int indexOf = thisApp.productsCollection.IndexOf(productObject);
            Products produts = new Products()
            {
                product = new Product()
                {
                    Id = productObject.Id
                }
            };
            bool isCreated = ShopifyRequests.DeleteProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), produts);
            if (isCreated == true)
            {
                thisApp.productsCollection.RemoveAt(indexOf);
            }
        }
    }
}
