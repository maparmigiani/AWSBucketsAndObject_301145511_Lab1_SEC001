using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//Student Name: Maiara Karla Parmigiani de Almeida
//Student id:301145511

namespace _301145511_ParmigianiDeAlmeida__Lab01
{
    /// <summary>
    /// Interaction logic for UploadObject.xaml
    /// </summary>
    public partial class UploadObject : Window
    {
        private ObservableCollection<string> buckets;
        public UploadObject()
        {
            InitializeComponent();
            buckets = new ObservableCollection<string>();
            _ = ComboBoxBucketsNameAsync();
        }
        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            //Reference:https://stackoverflow.com/questions/37684652/cannot-import-microsoft-win32-openfiledialog
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            
            //Reference:https://stackoverflow.com/questions/18586047/initial-directory-for-openfiledialog
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);    
            dlg.Filter = "Any type of file|*.*"; // Filter files by extension

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                TxtBoxObject.Text = filename;
            }
        }
        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            //string filepath = TxtBoxObject.Text;
            //var bucketNameSelected = CbxBuckets.Items.GetItemAt(CbxBuckets.SelectedIndex).ToString();
            _ = UploadFileAsync();
        }
        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private async Task ComboBoxBucketsNameAsync()
        {
            IAmazonS3 s3Client = Helper.GetS3Client();
            ListBucketsResponse response = await s3Client.ListBucketsAsync();
            foreach (S3Bucket bucket in response.Buckets)
            {
                buckets.Add(bucket.BucketName+"");
            }
            CbxBuckets.ItemsSource = buckets;
            //MessageBox.Show("Combo Box Iniciatialized Suc", "Action", MessageBoxButton.OK);
        }
        public async Task ListBucketFilesAsync(string bucketName)
        {
            IAmazonS3 s3Client = Helper.GetS3Client();
            ObservableCollection<S3Object> bucketsFiles = new ObservableCollection<S3Object>();
            //Reference:https://stackoverflow.com/questions/9920804/how-to-list-all-objects-in-amazon-s3-bucket code from line 94-110
            //Reference:https://docs.aws.amazon.com/sdkfornet1/latest/apidocs/html/T_Amazon_S3_Model_S3Object.htm
            //Code used to make DataGrid of Buckets Files
            try
            {
                ListObjectsV2Request request = new ListObjectsV2Request
                {
                    BucketName = bucketName,
                    MaxKeys = 10
                };
                ListObjectsV2Response response;
                do
                {
                    response = await s3Client.ListObjectsV2Async(request);
                    // Process the response.
                    foreach (S3Object uploadObject in response.S3Objects)
                    {
                        bucketsFiles.Add(uploadObject);
                    }
                    request.ContinuationToken = response.NextContinuationToken;

                } while (response.IsTruncated);
                DtGridObjects.ItemsSource = null;
                DtGridObjects.ItemsSource = bucketsFiles;
            }
            catch (AmazonS3Exception)
            {
                MessageBox.Show("Problem with AmazonS3Exception", "Action", MessageBoxButton.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Problem with ListObjectsV2Response", "Action", MessageBoxButton.OK);
            }
        }
        public async Task UploadFileAsync()
        {
            string filePath = TxtBoxObject.Text;
            var bucketName = CbxBuckets.Items.GetItemAt(CbxBuckets.SelectedIndex).ToString();
            try
            {
                var fileTransferUtility = new TransferUtility(Helper.s3Client);

                // Option 1. Upload a file. The file name is used as the object key name.
                await fileTransferUtility.UploadAsync(filePath, bucketName);
                MessageBox.Show("Upload 1 completed");
            }
            catch (AmazonS3Exception e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            await ListBucketFilesAsync(bucketName);
        }
        private async void bucketNameSelection(object sender, SelectionChangedEventArgs e)
        {
            IAmazonS3 s3Client = Helper.GetS3Client();
            if (s3Client != null)
            {
                string bucketNameSelected = CbxBuckets.Items.GetItemAt(CbxBuckets.SelectedIndex).ToString();
                await ListBucketFilesAsync(bucketNameSelected);
            }
            else
            {
                MessageBox.Show("Problem with credencial!", "Action", MessageBoxButton.OK);
            }
        }
    }
}
