using System.Collections.Generic;
using Contentful.Core.Models;
namespace EntryData
{
    public class ShopContainer: IEntry
    {
        public string title;
        public List<ShopItem> highlight;
        public List<ShopItem> storeItems;
        public SystemProperties Sys
        {
            get; 
            set;
        }
    }
}
