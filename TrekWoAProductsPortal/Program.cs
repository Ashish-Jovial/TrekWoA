using System;
using Shopify;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {

            //GET /admin/products.json
            dynamic shopify = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com");
            var selectQuery = shopify.Products();
            foreach (var prod in selectQuery.products)
            {
                Console.WriteLine(prod.title);
                Console.WriteLine(prod.id);

            }
            Console.ReadLine();



            //GET / admin / products/count.json
            //dynamic shopifyCount = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com", "https://trek-bikes.myshopify.com/admin/products/count.json");
            //var CountQuery = shopifyCount.Products();
            //Console.WriteLine(CountQuery.count);
            //Console.ReadLine();



            // GET / admin / products /#{product_id}.json
            //dynamic shopifyId = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com", "https://trek-bikes.myshopify.com/admin/products/1362489245814.json");
            //var selectIdQuery = shopifyId.Products();
            //Console.WriteLine(selectIdQuery.product.title);
            //Console.ReadLine();



            //POST / admin / products.json
            //var p = new Products()
            //{
            //    product = new product()
            //    {
            //        title = "watch",
            //        price="50"
            //    }
            //};


            //dynamic shopifySave = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com");
            //shopifySave.Products.Save(p);




            //PUT /admin/products/632910392.json
            //var pupdate = new Shopify.Products()
            //{
            //    product = new product()
            //    {
            //        title = "fitbit",
            //        id= "1370435747958",
            //        price = "100"

            //    }
            //};


            //dynamic shopifyUpdate = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com");
            //shopifyUpdate.Products.Save(pupdate);


            //DELETE /admin/products/#{product_id}.json
            //var pdelete = new Shopify.Products()
            //{
            //    product = new product()
            //    {

            //        id = "1370435747958",


            //    }
            //};


            //dynamic shopifyDelete = new Shopify.Api("67b9a85c8758934ab576f76e0daec9cf", "a5c2e67de6376e3cc76f54191155f93a", "trek-bikes.myshopify.com");
            //shopifyDelete.Products.Delete(pdelete);



        }
    }
}
