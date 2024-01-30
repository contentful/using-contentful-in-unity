using EntryData;
using UnityEngine;

public class ShopCardUI : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI title;
    [SerializeField]
    TMPro.TextMeshProUGUI description;
    [SerializeField]
    TMPro.TextMeshProUGUI price;
    [SerializeField]
    TMPro.TextMeshProUGUI onSale;
    
    [SerializeField]
    ItemCardUI itemCard;
    
    
    public void SetShopItem(ShopItem shopItem)
    {
        title.text = shopItem.title;
        description.text = shopItem.description;
        price.text = $"${shopItem.price}";
        onSale.enabled = shopItem.onSale;
        
        itemCard.SetGameItem(shopItem.gameItem);
    }
}
