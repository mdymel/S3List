using System;
using System.Configuration;
using Amazon;
using Amazon.S3;

namespace S3List
{
    class Program
    {
        static void Main(string[] args)
        {
            var bucket = ConfigurationManager.AppSettings["bucket"];

            var s3Client = new AmazonS3Client(RegionEndpoint.EUCentral1);
            var list = s3Client.ListObjects(bucket);
            foreach (var s3Object in list.S3Objects)
            {
                Console.WriteLine(s3Object.Key);
            }
        }
    }
}
