using Azure.Identity;
using Azure.Storage.Blobs;

namespace KeyVault.Helpers
{
    public class StorageAccountHelper
    {
        public void ConnectBlob()
        {
            string blobcontainerurl = "https://xxxxx.Azure.Net/";
            var creds = new DefaultAzureCredential();

            var containerClient = new BlobContainerClient(new Uri(blobcontainerurl),creds);

            foreach(var blob in containerClient.GetBlobs())
            {
                //
            }
        }
    }
}
