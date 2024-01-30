using Contentful.Core.Models;
namespace EntryData
{
    public class ShopItem: IEntry
    {
        public string title;
        public string description;
        public int price;
        public bool onSale;
        public GameItem gameItem;
        public SystemProperties Sys
        {
            get;
            set;
        }
    }
}
