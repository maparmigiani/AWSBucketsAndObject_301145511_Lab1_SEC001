using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
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

//Student Name: Maiara Karla Parmigiani de Almeida
//Student id:301145511

namespace _301145511_ParmigianiDeAlmeida__Lab01
{
    /// <summary>
    /// Interaction logic for CreateBucket.xaml
    /// </summary>
    public partial class CreateBucket : Window
    {
        public CreateBucket()
        {
            InitializeComponent();
        }

        private void BtnCreateBucket_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String newBucket = TxtBoxNewBucket.Text.ToString();
    
                if (newBucket.Any(char.IsUpper) || newBucket.Contains(" "))
                {
                    LblMessage.Content = "Bucket Name must not contaion uppercase and white spaces";
                    MessageBox.Show("FAIL!", "Action", MessageBoxButton.OK);
                }
                else
                {
                    _=CreateBuckets(newBucket);
                    MessageBox.Show("Bucket Created!", "Action", MessageBoxButton.OK);
                }
            }
            catch (AmazonS3Exception)
            {
                LblMessage.Content = "AmazonS3Exception: Bucket Name must not contaion uppercase and white spaces";
            }
            catch (Exception)
            {
                LblMessage.Content = "Exception: Bucket Name must not contaion uppercase and white spaces";
            }
            _ = ListBucketUpdateAsync();
        }

        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private  async Task<ListBucketsResponse> ListBucketAsync(IAmazonS3 s3Client)
        {
            ListBucketsResponse response = await s3Client.ListBucketsAsync();
            return response;
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var response = await ListBucketAsync(Helper.GetS3Client());
            DtGridBuckets.ItemsSource = response.Buckets;
        }
        public async Task ListBucketUpdateAsync()
        {
            IAmazonS3 s3Client = Helper.GetS3Client();

            var response = await ListBucketAsync(Helper.GetS3Client());

            DtGridBuckets.ItemsSource = null;
            DtGridBuckets.ItemsSource = response.Buckets;

            MessageBox.Show("Datagrid Updated", "Action", MessageBoxButton.OK);
        }
        public async Task<CreateBucketResponse> CreateBuckets(string bucketName)
        {
            IAmazonS3 s3Client = Helper.GetS3Client();
            var putBucketRequest = new PutBucketRequest
            {
                BucketName = bucketName,
                UseClientRegion = true
            };

            var response = await s3Client.PutBucketAsync(putBucketRequest);

            return new CreateBucketResponse
            {
                BucketName = bucketName,
                RequestId = response.ResponseMetadata.RequestId
            };
        }
    }
}
