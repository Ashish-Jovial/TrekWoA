using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TrekWoAProductsPortal.HelperClasses;

namespace TrekWoAProductsPortal.Model
{
    //public class Variant : INotifyPropertyChanged
    //{
    //    private long _id { get; set; }
    //    private long _product_id { get; set; }
    //    private string _title { get; set; }
    //    private string _price { get; set; }
    //    private string _sku { get; set; }
    //    private int _position { get; set; }
    //    private string _inventory_policy { get; set; }
    //    private object _compare_at_price { get; set; }
    //    private string _fulfillment_service { get; set; }
    //    private object _inventory_management { get; set; }
    //    private string _option1 { get; set; }
    //    private object _option2 { get; set; }
    //    private object _option3 { get; set; }
    //    private DateTime _created_at { get; set; }
    //    private DateTime _updated_at { get; set; }
    //    private bool _taxable { get; set; }
    //    private string _barcode { get; set; }
    //    private int _grams { get; set; }
    //    private object _image_id { get; set; }
    //    private int _inventory_quantity { get; set; }
    //    private int _weight { get; set; }
    //    private string _weight_unit { get; set; }
    //    private long _inventory_item_id { get; set; }
    //    private int _old_inventory_quantity { get; set; }
    //    private bool _requires_shipping { get; set; }

    //    [DisplayName("Id")]
    //    public long id
    //    {
    //        get { return _id; }
    //        set { _id = value; RaisePropertyChange("id"); }
    //    }
    //    [DisplayName("Product_id")]
    //    public long product_id
    //    {
    //        get { return _product_id; }
    //        set { _product_id = value; RaisePropertyChange("product_id"); }
    //    }
    //    [DisplayName("Title")]
    //    public string title
    //    {
    //        get { return _title; }
    //        set { _title = value; RaisePropertyChange("title"); }
    //    }
    //    [DisplayName("Price")]
    //    public string price
    //    {
    //        get { return _price; }
    //        set { _price = value; RaisePropertyChange("price"); }
    //    }
    //    [DisplayName("Sku")]
    //    public string sku
    //    {
    //        get { return _sku; }
    //        set { _sku = value; RaisePropertyChange("sku"); }
    //    }
    //    [DisplayName("Position")]
    //    public int position
    //    {
    //        get { return _position; }
    //        set { _position = value; RaisePropertyChange("position"); }
    //    }
    //    [DisplayName("Inventory_policy")]
    //    public string inventory_policy
    //    {
    //        get { return _inventory_policy; }
    //        set { _inventory_policy = value; RaisePropertyChange("inventory_policy"); }
    //    }
    //    [DisplayName("Compare_at_price")]
    //    public object compare_at_price
    //    {
    //        get { return _compare_at_price; }
    //        set { _compare_at_price = value; RaisePropertyChange("compare_at_price"); }
    //    }
    //    [DisplayName("Fulfillment_service")]
    //    public string fulfillment_service
    //    {
    //        get { return _fulfillment_service; }
    //        set { _fulfillment_service = value; RaisePropertyChange("fulfillment_service"); }
    //    }
    //    [DisplayName("Inventory_management")]
    //    public object inventory_management
    //    {
    //        get { return _inventory_management; }
    //        set { _inventory_management = value; RaisePropertyChange("inventory_management"); }
    //    }
    //    [DisplayName("Option1")]
    //    public string option1
    //    {
    //        get { return _option1; }
    //        set { _option1 = value; RaisePropertyChange("option1"); }
    //    }
    //    [DisplayName("Option2")]
    //    public object option2
    //    {
    //        get { return _option2; }
    //        set { _option2 = value; RaisePropertyChange("option2"); }
    //    }
    //    [DisplayName("Option3")]
    //    public object option3
    //    {
    //        get { return _option3; }
    //        set { _option3 = value; RaisePropertyChange("option3"); }
    //    }
    //    [DisplayName("Created_at")]
    //    public DateTime created_at
    //    {
    //        get { return _created_at; }
    //        set { _created_at = value; RaisePropertyChange("created_at"); }
    //    }
    //    [DisplayName("Updated_at")]
    //    public DateTime updated_at
    //    {
    //        get { return _updated_at; }
    //        set { _updated_at = value; RaisePropertyChange("updated_at"); }
    //    }
    //    [DisplayName("Taxable")]
    //    public bool taxable
    //    {
    //        get { return _taxable; }
    //        set { _taxable = value; RaisePropertyChange("taxable"); }
    //    }
    //    [DisplayName("Barcode")]
    //    public string barcode
    //    {
    //        get { return _barcode; }
    //        set { _barcode = value; RaisePropertyChange("barcode"); }
    //    }
    //    [DisplayName("Grams")]
    //    public int grams
    //    {
    //        get { return _grams; }
    //        set { _grams = value; RaisePropertyChange("grams"); }
    //    }
    //    [DisplayName("Image_id")]
    //    public object image_id
    //    {
    //        get { return _image_id; }
    //        set { _image_id = value; RaisePropertyChange("image_id"); }
    //    }
    //    [DisplayName("Inventory_quantity")]
    //    public int inventory_quantity
    //    {
    //        get { return _inventory_quantity; }
    //        set { _inventory_quantity = value; RaisePropertyChange("inventory_quantity"); }
    //    }
    //    [DisplayName("Weight")]
    //    public int weight
    //    {
    //        get { return _weight; }
    //        set { _weight = value; RaisePropertyChange("weight"); }
    //    }
    //    [DisplayName("Weight_unit")]
    //    public string weight_unit
    //    {
    //        get { return _weight_unit; }
    //        set { _weight_unit = value; RaisePropertyChange("weight_unit"); }
    //    }
    //    [DisplayName("Inventory_item_id")]
    //    public long inventory_item_id
    //    {
    //        get { return _inventory_item_id; }
    //        set { _inventory_item_id = value; RaisePropertyChange("inventory_item_id"); }
    //    }
    //    [DisplayName("Old_inventory_quantity")]
    //    public int old_inventory_quantity
    //    {
    //        get { return _old_inventory_quantity; }
    //        set { _old_inventory_quantity = value; RaisePropertyChange("old_inventory_quantity"); }
    //    }
    //    [DisplayName("Requires_shipping")]
    //    public bool requires_shipping
    //    {
    //        get { return _requires_shipping; }
    //        set { _requires_shipping = value; RaisePropertyChange("requires_shipping"); }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void RaisePropertyChange(string propertyname)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
    //        }
    //    }
    //}

    //public class Option : INotifyPropertyChanged
    //{
    //    private long _id { get; set; }
    //    private long _product_id { get; set; }
    //    private string _name { get; set; }
    //    private int _position { get; set; }
    //    private List<string> _values { get; set; }

    //    [DisplayName("Id")]
    //    public long id
    //    {
    //        get { return _id; }
    //        set { _id = value; RaisePropertyChange("id"); }
    //    }
    //    [DisplayName("Product_id")]
    //    public long product_id
    //    {
    //        get { return _product_id; }
    //        set { _product_id = value; RaisePropertyChange("product_id"); }
    //    }
    //    [DisplayName("Name")]
    //    public string name
    //    {
    //        get { return _name; }
    //        set { _name = value; RaisePropertyChange("name"); }
    //    }
    //    [DisplayName("Position")]
    //    public int position
    //    {
    //        get { return _position; }
    //        set { _position = value; RaisePropertyChange("position"); }
    //    }
    //    [DisplayName("Values")]
    //    public List<string> values
    //    {
    //        get { return _values; }
    //        set { _values = value; RaisePropertyChange("values"); }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void RaisePropertyChange(string propertyname)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
    //        }
    //    }
    //}

    //public class Image : INotifyPropertyChanged
    //{
    //    private long _id { get; set; }
    //    private long _product_id { get; set; }
    //    private int _position { get; set; }
    //    private DateTime _created_at { get; set; }
    //    private DateTime _updated_at { get; set; }
    //    private object _alt { get; set; }
    //    private int _width { get; set; }
    //    private int _height { get; set; }
    //    private string _src { get; set; }
    //    private List<object> _variant_ids { get; set; }

    //    [DisplayName("Id")]
    //    public long id
    //    {
    //        get { return _id; }
    //        set
    //        {
    //            _id = value;
    //            RaisePropertyChange("id");
    //        }
    //    }
    //    [DisplayName("Product_id")]
    //    public long product_id
    //    {
    //        get { return _product_id; }
    //        set
    //        {
    //            _product_id = value;
    //            RaisePropertyChange("product_id");
    //        }
    //    }
    //    [DisplayName("Position")]
    //    public int position
    //    {
    //        get { return _position; }
    //        set
    //        {
    //            _position = value;
    //            RaisePropertyChange("position");
    //        }
    //    }
    //    [DisplayName("Created_at")]
    //    public DateTime created_at
    //    {
    //        get { return _created_at; }
    //        set
    //        {
    //            _created_at = value;
    //            RaisePropertyChange("created_at");
    //        }
    //    }
    //    [DisplayName("Updated_at")]
    //    public DateTime updated_at
    //    {
    //        get { return _updated_at; }
    //        set { _updated_at = value; RaisePropertyChange("updated_at"); }
    //    }
    //    [DisplayName("Alt")]
    //    public object alt
    //    {
    //        get { return _alt; }
    //        set
    //        {
    //            _alt = value;
    //            RaisePropertyChange("alt");
    //        }
    //    }
    //    [DisplayName("Width")]
    //    public int width
    //    {
    //        get { return _width; }
    //        set { _width = value; RaisePropertyChange("width"); }
    //    }
    //    [DisplayName("Height")]
    //    public int height
    //    {
    //        get { return _height; }
    //        set { _height = value; RaisePropertyChange("height"); }
    //    }
    //    [DisplayName("Src")]
    //    public string src
    //    {
    //        get { return _src; }
    //        set { _src = value; RaisePropertyChange("src"); }
    //    }
    //    [DisplayName("Variant_ids")]
    //    public List<object> variant_ids
    //    {
    //        get { return _variant_ids; }
    //        set { _variant_ids = value; RaisePropertyChange("variant_ids"); }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void RaisePropertyChange(string propertyname)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
    //        }
    //    }
    //}

    //public class Product : INotifyPropertyChanged
    //{
    //    private long _id { get; set; }
    //    private string _title { get; set; }
    //    private string _body_html { get; set; }
    //    private string _vendor { get; set; }
    //    private string _product_type { get; set; }
    //    private DateTime _created_at { get; set; }
    //    private string _handle { get; set; }
    //    private DateTime _updated_at { get; set; }
    //    private string _published_At { get; set; }
    //    private object _templated_suffix { get; set; }
    //    private string _tags { get; set; }
    //    private string _published_scope { get; set; }
    //    private List<Variant> _varients { get; set; }
    //    private List<Option> _options { get; set; }
    //    private Image _image { get; set; }
    //    [DisplayName("Id")]
    //    public long id
    //    {
    //        get
    //        {
    //            return _id;
    //        }
    //        set
    //        {
    //            _id = value;
    //            RaisePropertyChange("Id");
    //        }
    //    }
    //    [DisplayName("Title")]
    //    public string title
    //    {
    //        get
    //        {
    //            return _title;
    //        }
    //        set
    //        {
    //            _title = value;
    //            RaisePropertyChange("Title");
    //        }
    //    }
    //    [DisplayName("Body_html")]
    //    public string body_html
    //    {
    //        get
    //        {
    //            return _body_html;
    //        }
    //        set
    //        {
    //            _body_html = value;
    //            RaisePropertyChange("Body_html");
    //        }
    //    }
    //    [DisplayName("Vendor")]
    //    public string vendor
    //    {
    //        get { return _vendor; }
    //        set
    //        {
    //            _vendor = value;
    //            RaisePropertyChange("Vendor");
    //        }
    //    }
    //    [DisplayName("Produt_type")]
    //    public string product_type
    //    {
    //        get { return _product_type; }
    //        set
    //        {
    //            _product_type = value;
    //            RaisePropertyChange("Product_type");
    //        }
    //    }
    //    [DisplayName("Created_at")]
    //    public DateTime created_at
    //    {
    //        get { return _created_at; }
    //        set
    //        {
    //            _created_at = value;
    //            RaisePropertyChange("Created_at");
    //        }
    //    }
    //    [DisplayName("Handle")]
    //    public string handle
    //    {
    //        get { return _handle; }
    //        set
    //        {
    //            _handle = value;
    //            RaisePropertyChange("Handle");
    //        }
    //    }
    //    [DisplayName("Updated_at")]
    //    public DateTime updated_at
    //    {
    //        get { return _updated_at; }
    //        set
    //        {
    //            _updated_at = value;
    //            RaisePropertyChange("Updated_at");
    //        }
    //    }
    //    [DisplayName("Publicshed_at")]
    //    public DateTime published_at
    //    {
    //        get { return _updated_at; }
    //        set
    //        {
    //            _updated_at = value;
    //            RaisePropertyChange("Published_at");
    //        }
    //    }
    //    [DisplayName("template_suffix")]
    //    public object template_suffix
    //    {
    //        get { return _templated_suffix; }
    //        set
    //        {
    //            _templated_suffix = value;
    //            RaisePropertyChange("Template_suffix");
    //        }
    //    }
    //    [DisplayName("Tags")]
    //    public string tags
    //    {
    //        get { return _tags; }
    //        set
    //        {
    //            _tags = value;
    //            RaisePropertyChange("Tags");
    //        }
    //    }
    //    [DisplayName("Published_scope")]
    //    public string published_scope
    //    {
    //        get { return _published_scope; }
    //        set
    //        {
    //            _published_scope = value;
    //            RaisePropertyChange("Published_scope");
    //        }
    //    }
    //    [DisplayName("Variants")]
    //    public List<Variant> variants
    //    {
    //        get { return _varients; }
    //        set
    //        {
    //            _varients = value;
    //            RaisePropertyChange("Variants");
    //        }
    //    }
    //    [DisplayName("Options")]
    //    public List<Option> options
    //    {
    //        get { return _options; }
    //        set
    //        {
    //            _options = value;
    //            RaisePropertyChange("Options");
    //        }
    //    }
    //    [DisplayName("Image")]
    //    public Image image
    //    {
    //        get { return _image; }
    //        set
    //        {
    //            _image = value;
    //            RaisePropertyChange("Image");
    //        }
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void RaisePropertyChange(string propertyname)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
    //        }
    //    }
    //}

    //public class ProductModel
    //{
    //    public List<Product> product { get; set; }
    //}
    [DataContract(Name = "products")]
    public class Products : INotifyPropertyChanged
    {
        [DataMember(Name = "product")]
        public Product product { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
    [DataContract(Name = "product")]
    public class Product : INotifyPropertyChanged
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
