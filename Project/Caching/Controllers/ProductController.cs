using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.Collections;
using System.Diagnostics;
using System.Text.Json;

namespace Caching.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;

        public static List<Product> products = new List<Product>()
        {
            new Product(1,"Product1","description1",1000),
            new Product(2,"Product2","description2",2054),
            new Product(3,"Product3","description3",343),
            new Product(4,"Product4","description4",1343),
            new Product(5,"Product5","description5",1545),
            new Product(6,"Product6","description6",1656),
            new Product(7,"Product7","description7",1212)
        }; 
        public ProductController(IMemoryCache memoryCache,IDistributedCache distributedCache)
        {
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
            
        }

        [ResponseCache(Location =ResponseCacheLocation.Any,Duration =50000)]
        public IActionResult GetProducts()
        {
            var cacheData = _memoryCache.Get<IEnumerable<Product>>("Products");
            if(cacheData != null)
            {
                Debug.WriteLine("Getting Data From the Cache");
                return Ok(cacheData);
            }

            Debug.WriteLine("Cache is empty setting the cache. Last Cached Date" + DateTime.Now);
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            cacheData = products;
            _memoryCache.Set("Products", cacheData, expirationTime);
            return Ok(cacheData);
        }


        public IActionResult fetchProducts()
        {
            var cache = _distributedCache.Get("Products");
            if(cache != null)
            {
                Debug.WriteLine("Getting Data From the Cache");
                var cacheData = JsonSerializer.Deserialize<IEnumerable<Product>>(cache);    
                return Ok(cacheData);
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            var serializeddata = JsonSerializer.Serialize<IEnumerable<Product>>(products);
            var options = new DistributedCacheEntryOptions { AbsoluteExpiration = expirationTime };
            _distributedCache.SetString("Products", serializeddata,options);

            return Ok(products);


        }


    }
}
