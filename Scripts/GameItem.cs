using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Database", menuName = "Windfall/Databases/Shop Database")]
public class GameItemScriptableObject : ScriptableObject
{
    public string title;
    public int strength;
    public int defense;
    public int speed;
}
