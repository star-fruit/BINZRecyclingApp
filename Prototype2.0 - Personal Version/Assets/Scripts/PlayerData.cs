using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class PlayerData 
{
    public bool isDebug;
    public int itemsRecycled;
    public int plasticRecycled;
    public int paperRecycled;
    public int organicRecycled;
    public int language;

    [Serializable]
    public class recyclingDay
    {
        public DateTime date;
        public int items;
    }

    public recyclingDay zeroD = new recyclingDay();
    public recyclingDay oneD = new recyclingDay();
    public recyclingDay twoD = new recyclingDay();
    public recyclingDay threeD = new recyclingDay();
    public recyclingDay fourD = new recyclingDay();
    public recyclingDay fiveD = new recyclingDay();
    public recyclingDay sixD = new recyclingDay();

    public PlayerData (Player player)
    {
        itemsRecycled = player.itemsRecycled;
        plasticRecycled = player.plasticRecycled;
        paperRecycled = player.paperRecycled;
        organicRecycled = player.organicRecycled;
        language = player.language;

        zeroD.date = player.zeroD.date;
        zeroD.items = player.zeroD.items;
        oneD.date = player.oneD.date;
        oneD.items = player.oneD.items;
        twoD.date = player.twoD.date;
        twoD.items = player.twoD.items;
        threeD.date = player.threeD.date;
        threeD.items = player.threeD.items;
        fourD.date = player.fourD.date;
        fourD.items = player.fourD.items;
        fiveD.date = player.fiveD.date;
        fiveD.items = player.fiveD.items;
        sixD.date = player.sixD.date;
        sixD.items = player.sixD.items;
    }
}
