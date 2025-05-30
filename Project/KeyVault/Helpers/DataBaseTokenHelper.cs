using Azure.Core;
using Azure.Identity;

namespace KeyVault.Helpers
{
    public class DataBaseTokenHelper
    {
        public void GetDataBaseToken() {

            var creds = new DefaultAzureCredential();
            var token = creds.GetToken(new TokenRequestContext(new[] { "https://database.windows.net/" })).Token;
            Console.WriteLine(token);
        }
    }
}
