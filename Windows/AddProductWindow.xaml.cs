using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _3ISP918VB_FEDIN_NESMELOV.DB;

namespace _3ISP918VB_FEDIN_NESMELOV
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private string pathPhoto = null;

        private bool isEdit = false;

        private Product editProduct;



        public AddProductWindow()
        {
            InitializeComponent();

            CMBTypeProduct.ItemsSource = Context.Product.ToList();
            CMBTypeProduct.SelectedIndex = 0;
            CMBTypeProduct.DisplayMemberPath = "TypeName";
        }

        public AddProductWindow(Product product)
        {
            InitializeComponent();

            CMBTypeProduct.ItemsSource = Context.Product.ToList();
            CMBTypeProduct.SelectedIndex = 0;
            CMBTypeProduct.DisplayMemberPath = "TypeName";


            TbNameProduct.Text = product.ProdName.ToString();
            TbDisc.Text = product.Description.ToString();
            CMBTypeProduct.SelectedItem = Context.Product.Where(i => i.IdProdType == product.IdProdType).FirstOrDefault();

            if (product.Image != null)
            {
                using (MemoryStream stream = new MemoryStream(product.Image))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    bitmapImage.StreamSource = stream;
                    bitmapImage.EndInit();
                    ImgProduct.Source = bitmapImage;

                }
            }


            isEdit = true;

            editProduct = product;

        }

       

        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            // валидация


            if (isEdit)
            {
                //изменение товара

                editProduct.ProdName = TbNameProduct.Text;
                editProduct.Description = TbDisc.Text;
                editProduct.IdProdType = (CMBTypeProduct.SelectedItem as Product).IdProdType;
                if (pathPhoto != null)
                {
                    editProduct.Image = File.ReadAllBytes(pathPhoto);
                }
                Context.SaveChanges();
                MessageBox.Show("OK");
            }
            else
            {
                //добавление товара
                Product product = new Product();
                product.ProdName = TbNameProduct.Text;
                product.Description = TbDisc.Text;
                product.IdProdType = (CMBTypeProduct.SelectedItem as Product).IdProdType;
                if (pathPhoto != null)
                {
                    product.Image = File.ReadAllBytes(pathPhoto);
                }

                Context.Product.Add(product);

                Context.SaveChanges();
                MessageBox.Show("OK");
            }

            this.Close();

        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
    }

        private void CMBTypeProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
