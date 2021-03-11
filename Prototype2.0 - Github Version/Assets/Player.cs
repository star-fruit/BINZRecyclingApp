using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int itemsRecycled = 0;
    public GameObject showItems;

    public void addItem ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        SavePlayer();

        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        itemsRecycled = data.itemsRecycled;
    }

    void Update()
    {
        LoadPlayer();
        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
    }

}
