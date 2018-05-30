using System;
using System.Collections.Generic;
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

namespace TrekWoAProductsPortal.UserControl
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : System.Windows.Controls.UserControl
    {
        public string productName;
        public string productPrice;
        public string buttonStatus;
        public string id;
        public event EventHandler ClosePopup;
        public event EventHandler NewProduct;
        public AddProduct()
        {
            InitializeComponent();
            buttonStatus = "Add";
            btnAddOrUpdate.Content = buttonStatus;
        }

        private void btnAddOrUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (NewProduct != null)
            {
                productName = txtProductName.Text;
                productPrice = txtProductPrice.Text;
                NewProduct(this, e);
            }

        }
        public void Destructor()
        {
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (ClosePopup != null)
                ClosePopup(this, e);
        }
    }
}
