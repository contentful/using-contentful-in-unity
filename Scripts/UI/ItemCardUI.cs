using EntryData;
using UnityEngine;

public class ItemCardUI : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI title;
    [SerializeField]
    TMPro.TextMeshProUGUI strength;
    [SerializeField]
    TMPro.TextMeshProUGUI defense;
    [SerializeField]
    TMPro.TextMeshProUGUI speed;
    
    public void SetGameItem(GameItem gameItem)
    {
        title.text = gameItem.title;
        strength.text = $"Strength: {gameItem.strength}";
        defense.text = $"Defense: {gameItem.defense}";
        speed.text = $"Speed: {gameItem.speed}";
    }
}
