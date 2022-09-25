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

//Student Name: Maiara Karla Parmigiani de Almeida
//Student id:301145511

namespace _301145511_ParmigianiDeAlmeida__Lab01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnObjLvlOpe_Click(object sender, RoutedEventArgs e)
        {
            UploadObject uploadObject = new UploadObject();
            uploadObject.Show();
            Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnCreateBucket_Click(object sender, RoutedEventArgs e)
        {
            CreateBucket createBucket = new CreateBucket();
            createBucket.Show();
            Close();
        }
    }
}
