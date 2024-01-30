using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Contentful.Core;
using Contentful.Core.Configuration;
using Contentful.Core.Search;
using EntryData;
using ScriptableObjects;
using UnityEngine;
namespace Services
{
    public class ContentfulService : MonoBehaviour
    {
        public static ContentfulService Instance { get; private set; }
        
        [SerializeField]
        ContentfulClientSettingsSO contentfulClientSettings;
        
        ContentfulClient _contentfulClient;
        
        
        void Awake()
        {
            _contentfulClient = new ContentfulClient(new HttpClient(), new ContentfulOptions
            {
                DeliveryApiKey = contentfulClientSettings.deliveryToken,
                SpaceId = contentfulClientSettings.spaceId,
                Environment = contentfulClientSettings.environment
            });
            
            Instance = this;
        }
        
        public async Task<T> GetEntry<T>(string entryId) where T : class, IEntry
        {
            var builder = new QueryBuilder<T>().FieldEquals(f => f.Sys.Id, entryId).Include(3);
            var results = await _contentfulClient.GetEntries(builder);
            
            return results.FirstOrDefault();
        }
    }
}
