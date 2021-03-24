using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Player : MonoBehaviour
{
    public int itemsRecycled = 0;
    public int plasticRecycled = 0;
    public int paperRecycled = 0;
    public int organicRecycled = 0;

    public GameObject showItems;
    public GameObject showPlastic;
    public GameObject showPaper;
    public GameObject showOrganic;

    public void addItem ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        SavePlayer();

        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
    }

    public void addPlastic ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        plasticRecycled += 1;
        SavePlayer();

        showPlastic.GetComponent<Text>().text = plasticRecycled.ToString();
    }

    public void addPaper ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        paperRecycled += 1;
        SavePlayer();

        showPaper.GetComponent<Text>().text = paperRecycled.ToString();
    }

    public void addOrganic()
    {
        LoadPlayer();
        itemsRecycled += 1;
        organicRecycled += 1;
        SavePlayer();

        showOrganic.GetComponent<Text>().text = organicRecycled.ToString();
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        itemsRecycled = data.itemsRecycled;
        plasticRecycled = data.plasticRecycled;
        paperRecycled = data.paperRecycled;
        organicRecycled = data.organicRecycled;
    }

    void Awake()
    {   
        if(File.Exists(Application.persistentDataPath + "/player.info"))
        {
            LoadPlayer();
        }
        else
        {
            SavePlayer();
          
            LoadPlayer();
        }
       
        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
        showPlastic.GetComponent<Text>().text = plasticRecycled.ToString();
        showPaper.GetComponent<Text>().text = paperRecycled.ToString();
        showOrganic.GetComponent<Text>().text = organicRecycled.ToString();
    }

}
