using Online_Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;



namespace Online_Store
{

    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> Products
        {
            get { return (ObservableCollection<Product>)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Product.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(ObservableCollection<Product>), typeof(MainWindow));


        readonly Product p = new("Pop Kek", 4.59, "https://www.etiinternational.com/images/Products/eti-popkek-with-banana-small-cake_555_psb.png");
        readonly Product c = new("Pop Kek", 4.7, "https://www.etiinternational.com/images/Products/popkek-with-dark-chocolate_929_psb.png");
        readonly Product d = new("Pop Kek", 4.5, "https://www.etiinternational.com/images/Products/eti-popkek-with-lemon-small-cake_553_psb.png");
        readonly Product f = new("Pop Kek", 4.5, "https://www.expayglobal.com/images/products/eti-popkek-cocoa-coated-cake-with-coconut-sauce-60-gr.jpg");


        static public Product TempProduct { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();

            Products = new()
            {
                p, c, d,f,p, c, d,f,
                p, c, d,f,p, c, d,f
            };

            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var json = JsonSerializer.Serialize(Products);
            //File.WriteAllText("Products.txt", json);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //    string? json = File.ReadAllText("Products.json");
            //    Products = JsonSerializer.Deserialize<ObservableCollection<Product>>(json);
        }



        private void btn_basket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_addtobasket_Click(object sender, RoutedEventArgs e)
        {
            if (list_Products.SelectedItem is Product p)
            {
                BasketWindow.product = p;
                
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new();

            window.ShowDialog();

            if (TempProduct.Name is not null && TempProduct.Price is not null && TempProduct.Photo is not null)
                Products.Add(TempProduct);
        }


        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new();
            if (list_Products.SelectedItem is Product p)
            {
                window.txtbox_page_name.Text = p.Name;
                window.txtbox_page_price.Text = p.Price.ToString();
                window.txtbox_page_photo.Text = p.Photo;
                window.ShowDialog();
            }
        }
    }
}
