using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace KeyVault.Helpers
{
    public class KeyVaultHelper
    {
         public void GetConnectionString()
         {   
            string KeyVaultUrl = "https://your-keyvault-name.vault.azure.net/";
            string secretName = "SqlConnectionString";

            var client = new SecretClient(new Uri(KeyVaultUrl), new DefaultAzureCredential());

            var secret = client.GetSecret(secretName);

            var connectionstring = secret.Value;
            Console.WriteLine(connectionstring);
         }



    }
}
