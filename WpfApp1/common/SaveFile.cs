using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Api
{
    public class SaveFile
    {
        public async Task SendFile()
        {
            try
            {
                WebClient client = new WebClient();
                Stream file = client.OpenRead("D:/Work/Petrotrade-WPF_WithAZURE/WpfApp1/common/test.txt");
                CloudBlobContainer cloudBlobContainer = await ExtractContainer();
                var img = await UploadFile(file, cloudBlobContainer);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public async Task<CloudBlobContainer> ExtractContainer()
        {
            string storageConnection = Constants.StorageConnection;
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(storageConnection);
            //create a block blob 
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            //create a container 
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("doccontainer");
            //create a container if it is not already exists
            if (await cloudBlobContainer.CreateIfNotExistsAsync())
            {
                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
            }

            return cloudBlobContainer;
        }
        public async Task<string> UploadFile(Stream file, CloudBlobContainer cloudBlobContainer)
        {
            var generator = new Random();
            string imageName = "test.txt";

            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(imageName);
            cloudBlockBlob.Properties.ContentType = "text/plain";
            await cloudBlockBlob.UploadFromStreamAsync(file);

            return imageName;
        }

    }
}
