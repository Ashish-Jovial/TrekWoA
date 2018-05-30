using Shopify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrekWoAProductsPortal.Model;

namespace TrekWoAProductsPortal.HelperClasses
{
    public class ShopifyRequests
    {
        App thisApp = (App)Application.Current;

        /// <summary>
        /// Call to shopify to get the list of products, available in shopify website.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal</param>
        /// <param name="password">password used login in Shopify main portal</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal</param>
        /// <returns>Return list of products</returns>
        public static List<TrekWoAProductsPortal.Model.Product> GetAllProducts(string apiKey, string password, string storeUrl)
        {
            List<TrekWoAProductsPortal.Model.Product> products = null;
            try
            {
                dynamic shopify = new Shopify.Api(apiKey, password, storeUrl);
                var selectQuery = shopify.Products();
                products = new List<Model.Product>();
                if (selectQuery != null)
                {
                    products = new List<Model.Product>();
                    foreach (var item in selectQuery.products)
                    {
                        TrekWoAProductsPortal.Model.Product product = new TrekWoAProductsPortal.Model.Product();
                        product.Id = Convert.ToString(item.id);
                        product.Title = item.title;
                        products.Add(product);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            return products;
        }

        /// <summary>
        /// Return count of products uploaded into the shopify webisite.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal</param>
        /// <param name="password">password used login in Shopify main portal</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal</param>
        /// <returns>Return number of products available on Shopify</returns>
        public static int GetProductCount(string apiKey, string password, string storeUrl)
        {
            int count = 0;
            try
            {
                dynamic shopifyCount = new Shopify.Api(apiKey, password, storeUrl);
                var CountQuery = shopifyCount.Products();
                if (CountQuery != null)
                {
                    count = CountQuery;
                }
            }
            catch (Exception x)
            { }
            return count;
        }

        /// <summary>
        /// Call to Shopify api for get one product details based on product id.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal</param>
        /// <param name="password">password used login in Shopify main portal</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal</param>
        /// <returns>Return a product based on product id, available on Shopify</returns>
        public static TrekWoAProductsPortal.Model.Product GetProduct(string apiKey, string password, string storeUrl)
        {
            TrekWoAProductsPortal.Model.Product product = null;
            try
            {
                dynamic shopifyProductSelected = new Shopify.Api(apiKey, password, storeUrl);
                var IsProductSelected = shopifyProductSelected.Products();
                if (IsProductSelected != null)
                {
                    product = new Model.Product();
                    product = IsProductSelected;
                }
            }
            catch (Exception ex)
            { }
            return product;
        }

        /// <summary>
        /// Call this method to create a product on Shopify portal.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal</param>
        /// <param name="password">password used login in Shopify main portal</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal</param>
        /// <param name="product">pass product object which to be create</param>
        /// <returns>If created successfully return true, else false.</returns>
        public static bool CreateProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.Products product)
        {
            bool status = false;
            try
            {
                dynamic shopifyCreate = new Shopify.Api(apiKey, password, storeUrl);
                var IsCreated = shopifyCreate.Products.Save(product);
                {
                    if (IsCreated != null)
                    {
                        status = true;
                    }
                }
            }
            catch (Exception j)
            {

            }
            return status;
        }

        /// <summary>
        /// Call this method to update a product on Shopify portal.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal.</param>
        /// <param name="password">password used login in Shopify main portal.</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal.</param>
        /// <param name="product">pass product object which to be update.</param>
        /// <returns>If updated successfully return true, else false.</returns>
        public static bool UpdateProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.Products product)
        {
            bool status = false;
            try
            {
                dynamic shopifyUpdate = new Shopify.Api(apiKey, password, storeUrl);
                var IsUpdated = shopifyUpdate.Products.Save(product);
                {
                    if (IsUpdated != null)
                    {
                        status = true;
                    }
                }
            }
            catch (Exception js)
            { }
            return status;
        }

        /// <summary>
        /// Call this method to delete a product on Shopify portal.
        /// </summary>
        /// <param name="apiKey">pass apiKey used login in Shopify main portal.</param>
        /// <param name="password">password used login in Shopify main portal.</param>
        /// <param name="storeUrl">pass storeUrl created for the store Shopify main portal.</param>
        /// <param name="product">pass product object which to be delete.</param>
        /// <returns>If deleted successfully return true, else false.</returns>
        public static bool DeleteProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.Products product)
        {
            bool status = false;
            try
            {
                dynamic shopifyDelete = new Shopify.Api(apiKey, password, storeUrl);
                var IsDeleted = shopifyDelete.Products.Delete(product);
                {
                    if (IsDeleted != null)
                    {
                        status = true;
                    }
                }
            }
            catch (Exception ud)
            { }

            return status;
        }
    }
}
