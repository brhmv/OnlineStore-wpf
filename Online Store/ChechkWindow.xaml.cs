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
using System.Windows.Shapes;

namespace Online_Store
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_page_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.TempProduct = new();

                MainWindow.TempProduct.Name = txtbox_page_name.Text;

                MainWindow.TempProduct.Price = Convert.ToDouble(txtbox_page_price.Text);

                MainWindow.TempProduct.Photo = txtbox_page_photo.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
