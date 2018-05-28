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
        public static TrekWoAProductsPortal.Model.ProductModel GetAllProducts(string apiKey, string password, string storeUrl)
        {
            TrekWoAProductsPortal.Model.ProductModel products = null;
            try
            {
                dynamic shopify = new Shopify.Api(apiKey, password, storeUrl);
                var selectQuery = shopify.Products();
                ProductModel records = selectQuery as ProductModel;
                if (records != null)
                {
                    products = new ProductModel();
                    products = records;
                }
            }
            catch(Exception x)
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
            dynamic shopifyCount = new Shopify.Api(apiKey, password, storeUrl);
            var CountQuery = shopifyCount.Products();
            if (CountQuery != null)
            {
                count = CountQuery;
            }
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
            dynamic shopifyProductSelected = new Shopify.Api(apiKey, password, storeUrl);
            var IsProductSelected = shopifyProductSelected.Products();
            if (IsProductSelected != null)
            {
                product = new Product();
                product = IsProductSelected;
            }
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
        public static bool CreateProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.ProductModel product)
        {
            bool status = false;
            dynamic shopifyCreate = new Shopify.Api(apiKey,password,storeUrl);
            var IsCreated = shopifyCreate.Products.Save(product);
            {
                if(IsCreated!=null)
                {
                    status = true;
                }
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
        public static bool UpdateProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.ProductModel product)
        {
            bool status = false;
            dynamic shopifyUpdate = new Shopify.Api(apiKey, password, storeUrl);
            var IsUpdated = shopifyUpdate.Products.Save(product);
            {
                if (IsUpdated != null)
                {
                    status = true;
                }
            }
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
        public static bool DeleteProduct(string apiKey, string password, string storeUrl, TrekWoAProductsPortal.Model.ProductModel product)
        {
            bool status = false;
            dynamic shopifyDelete = new Shopify.Api(apiKey, password, storeUrl);
            var IsDeleted = shopifyDelete.Products.Save(product);
            {
                if (IsDeleted != null)
                {
                    status = true;
                }
            }
            return status;
        }
    }
}
