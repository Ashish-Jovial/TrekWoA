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
using System.Windows.Threading;
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
        public string Id = "";
        product EditProduct = new product();
        Window darkWindow = null;
        App thisApp = (App)Application.Current;
        public ObservableCollection<product> ProductsCollection
        { get { return thisApp.productsCollection; } }
        #region Consturctor
        public Dashboard()
        {
            InitializeComponent();
            btnAddOrUpdate.Content = "Add";
        }
        #endregion
        #region API Calls
        private async Task CountProducts()
        {
            product product = new product();
            int count = ShopifyRequests.GetProductCount(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), "https://trek-bikes.myshopify.com/admin/products/count.json");
            txtCount.Text = "Total Prducts : " + Convert.ToString(count);
        }
        private async Task LoadProducts()
        {
            List<product> newRecords = new List<product>();

            newRecords = ShopifyRequests.GetAllProducts(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""));
            if (newRecords != null)
            {
                thisApp.productsCollection.Clear();

                foreach (var x in newRecords)
                {
                    thisApp.productsCollection.Add(x);
                }
            }
        }
        private async Task UpdateProduct(Products product, int productIndex)
        {
            var updateRecrod = ShopifyRequests.UpdateProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), product);
            if (updateRecrod != null)
            {
                thisApp.productsCollection.RemoveAt(productIndex);
                thisApp.productsCollection.Add(product.product);
                //await InitialServerCall();
            }
        }
        private async Task CreateProduct()
        {
            Products products = new Products()
            {
                product = new product()
                {
                    title = txtProductName.Text,
                }
            };
            bool isCreated = ShopifyRequests.CreateProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), products);
            if (isCreated == true)
            {
                thisApp.productsCollection.Add(products.product);
            }
        }
        private async Task DeleteProduct(Products product, int indexOf)
        {
            //Take the object and it's ID.
            //Create a product object with ID 
            //call the api for deleting the record
            // Remove from the observableCollection.
            //Product btn = (sender as Button).Tag;

            bool isCreated = ShopifyRequests.DeleteProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), product);
            if (isCreated == true)
            {
                thisApp.productsCollection.RemoveAt(indexOf);
            }
        }
        private async Task GetProductById(string prodId)
        {
            product isCreated = new product();
            isCreated = ShopifyRequests.GetProduct(thisApp.api_key, thisApp.password, thisApp.GetFullUrl(""), "https://trek-bikes.myshopify.com/admin/products/" + prodId + ".json");
            if (isCreated != null)
            {
                product pros = new product()
                {
                    id = isCreated.id,
                    title = isCreated.title
                };
                thisApp.productsCollection.Clear();
                thisApp.productsCollection.Add(pros);
            }
        }
        #endregion
        #region Helper Methods
        private async Task InitialServerCall()
        {
            var task1 = LoadProducts();
            var task2 = CountProducts();
            Task.WaitAll(task1,task2);
        }
        private void UpdateButtonStatus()
        {
            if (chkStatus.IsChecked == true)
            {
                btnAddOrUpdate.Content = "Add";
            }
            else if (!String.IsNullOrEmpty(txtProductName.Text) && chkStatus.IsChecked == false)
            {
                btnAddOrUpdate.Content = "Update";
            }
        }
        //private void UpdateButtonStatus(bool status)
        //{
        //    if(!status)
        //    {
        //        this.Cursor = Cursors.Wait;
        //        txtProcessing.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        this.Cursor = Cursors.IBeam;
        //        txtProcessing.Visibility = Visibility.Collapsed;
        //    }
        //    txtProcessing.Text = "Processing. . .";
        //    btnAddOrUpdate.IsEnabled = status;
        //    btnRefresh.IsEnabled = status;
        //    btnGetById.IsEnabled = status;
        //}
        #endregion
        #region Events
        private async void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            //UpdateButtonStatus(false);
            await InitialServerCall();
            //UpdateButtonStatus(true);
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditProduct = (sender as Button).Tag as product;
            txtProductName.Text = EditProduct.title;
            Id = EditProduct.id;
            btnAddOrUpdate.Content = "Update";
        }
        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            product productObject = (sender as Button).Tag as product;
            MessageBoxResult dialog;
            dialog = MessageBox.Show("Do you want to delete record?", "Delete Record", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dialog == MessageBoxResult.Yes)
            {
                int indexOf = thisApp.productsCollection.IndexOf(productObject);
                Products produts = new Products()
                {
                    product = new product()
                    {
                        id = productObject.id
                    }
                };
                await DeleteProduct(produts, indexOf);
            }
        }
        private async void btnAddOrUpdate_Click(object sender, RoutedEventArgs e)
        {
            //UpdateButtonStatus(false);
            if (btnAddOrUpdate.Content == "Update")
            {
                int indexOf = thisApp.productsCollection.IndexOf(EditProduct);
                Products products = new Products()
                {
                    product = new product()
                    {
                        id = Id,
                        title = txtProductName.Text
                    }
                };
                UpdateProduct(products, indexOf);
            }
            else
            {
                await CreateProduct();
            }
            //UpdateButtonStatus(true);
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await InitialServerCall();
        }
        private void chkStatus_Click(object sender, RoutedEventArgs e)
        {
            UpdateButtonStatus();
        }
        private void txtProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateButtonStatus();
        }
        private async void btnGetById_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //UpdateButtonStatus(false);
                string prodId = txtProductById.Text;
                await GetProductById(prodId);
                //UpdateButtonStatus(true);
            }
            catch(Exception s)
            {

            }
        }
        #endregion
    }
}
