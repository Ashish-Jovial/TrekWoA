﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrekWoAProductsPortal.Model
{
    public class Variant
    {
        public long id { get; set; }
        public long product_id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string sku { get; set; }
        public int position { get; set; }
        public string inventory_policy { get; set; }
        public object compare_at_price { get; set; }
        public string fulfillment_service { get; set; }
        public object inventory_management { get; set; }
        public string option1 { get; set; }
        public object option2 { get; set; }
        public object option3 { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool taxable { get; set; }
        public string barcode { get; set; }
        public int grams { get; set; }
        public object image_id { get; set; }
        public int inventory_quantity { get; set; }
        public int weight { get; set; }
        public string weight_unit { get; set; }
        public long inventory_item_id { get; set; }
        public int old_inventory_quantity { get; set; }
        public bool requires_shipping { get; set; }
    }

    public class Option
    {
        public long id { get; set; }
        public long product_id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public List<string> values { get; set; }
    }

    public class Image
    {
        public long id { get; set; }
        public long product_id { get; set; }
        public int position { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object alt { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string src { get; set; }
        public List<object> variant_ids { get; set; }
    }

    public class Product
    {
        public long id { get; set; }
        public string title { get; set; }
        public string body_html { get; set; }
        public string vendor { get; set; }
        public string product_type { get; set; }
        public DateTime created_at { get; set; }
        public string handle { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime published_at { get; set; }
        public object template_suffix { get; set; }
        public string tags { get; set; }
        public string published_scope { get; set; }
        public List<Variant> variants { get; set; }
        public List<Option> options { get; set; }
        public Image image { get; set; }
    }

    public class ProductModel
    {
        public Product product { get; set; }
    }
}