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

namespace AddDeleteUpdate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProdContainer db = new ProdContainer();
        public MainWindow()
        {
            InitializeComponent();
            //db = new ProdContainer();
            //dataGrid.ItemsSource = db.Products;
        }
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //   
        //    dataGrid.ItemsSource = db.Products;
        //}
        //add
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Product p1 = new Product { Name = textBox.Text, Price = Convert.ToInt32(textBox1.Text) };
            db.Products.Add(p1);
            db.SaveChanges();
            dataGrid.Items.Refresh();
         
            textBox.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
        //delete
        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        //update
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
