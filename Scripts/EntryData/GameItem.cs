using Contentful.Core.Models;
namespace EntryData
{
    public class GameItem: IEntry
    {
        public string title;
        public int strength;
        public int defense;
        public int speed;
        public SystemProperties Sys
        {
            get;
            set;
        }
    }
}
