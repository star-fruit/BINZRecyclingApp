using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int itemsRecycled;

    public PlayerData (Player player)
    {
        itemsRecycled = player.itemsRecycled;
    }
}
