using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ContentfulClientSettings", menuName = "Contentful/Client Settings", order = 1)]
    public class ContentfulClientSettingsSO : ScriptableObject
    {
        public string deliveryToken;
        public string spaceId;
        public string environment;
    }
}
