using Amazon;
using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301145511_ParmigianiDeAlmeida__Lab01
{
    public static class Helper
    {
        public readonly static IAmazonS3 s3Client;

        static Helper()
        {
           // s3Client = new AmazonS3Client();
           s3Client = GetS3Client();
        }

        //public static IAmazonS3 getClient()
        //{
        //    return s3Client;
        //}

        public static IAmazonS3 GetS3Client()
        {
            string awsAccessKey = ConfigurationManager.AppSettings["accessId"];
            string awsSecretKey = ConfigurationManager.AppSettings["secretKey"];
            return new AmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.CACentral1);
        }
    }
}
