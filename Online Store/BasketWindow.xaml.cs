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
using System.Windows.Shapes;

namespace Online_Store
{
    public partial class BasketWindow : Window
    {
        static public Product product { get; set; }

        public ObservableCollection<Product> BasketProducts
        {
            get { return (ObservableCollection<Product>)GetValue(BasketProductsProperty); }
            set { SetValue(BasketProductsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BasketProducts.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BasketProductsProperty =
            DependencyProperty.Register("BasketProducts", typeof(ObservableCollection<Product>), typeof(BasketWindow));


        public BasketWindow()
        {
            InitializeComponent();
            DataContext = this;

            ///basketproducts add product
        }
    }
}
