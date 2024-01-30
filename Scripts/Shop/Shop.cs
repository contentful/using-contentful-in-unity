using EntryData;
using Services;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    string shopId;

    [SerializeField]
    GameObject highlightField;
    
    [SerializeField]
    GameObject storeItemsField;
    
    [SerializeField]
    GameObject shopCardPrefab;
    
    ShopContainer _shopContainer;
    
    void Start()
    {
        if (_shopContainer == null)
        {
            GetShop();
        }
    }
    
    async void GetShop()
    {
        _shopContainer = await ContentfulService.Instance.GetEntry<ShopContainer>(shopId);
        PopulateShop();
    }
    
    void PopulateShop()
    {
        foreach (var shopItem in _shopContainer.storeItems)
        {
            var shopCard = Instantiate(shopCardPrefab, storeItemsField.transform);
            shopCard.GetComponent<ShopCardUI>().SetShopItem(shopItem);
        }

        foreach (var shopItem in _shopContainer.highlight)
        {
            var shopCard = Instantiate(shopCardPrefab, highlightField.transform);
            shopCard.GetComponent<ShopCardUI>().SetShopItem(shopItem);
        }
    }
}
