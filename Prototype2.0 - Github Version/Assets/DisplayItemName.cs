using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItemName : MonoBehaviour
{
    public string itemName;
    public GameObject databasePage;
    public GameObject alteredText;

    public void storeItemName()
    {
        itemName = databasePage.name;
        alteredText.GetComponent<Text>().text = "Did You Recycle\n" + itemName + "?";
    }
}
