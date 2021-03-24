using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public bool isDebug;
    public int itemsRecycled;
    public int plasticRecycled;
    public int paperRecycled;
    public int organicRecycled;

    public PlayerData (Player player)
    {
        itemsRecycled = player.itemsRecycled;
        plasticRecycled = player.plasticRecycled;
        paperRecycled = player.paperRecycled;
        organicRecycled = player.organicRecycled;
    }
}
