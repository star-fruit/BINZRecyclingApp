using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using System;

public class Player : MonoBehaviour
{
    public int itemsRecycled = 0;
    public int plasticRecycled = 0;
    public int paperRecycled = 0;
    public int organicRecycled = 0;
    public int language = 0;

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

    public GameObject showItems;
    public GameObject showPlastic;
    public GameObject showPaper;
    public GameObject showOrganic;

    public GameObject day0;
    public GameObject item0;
    public GameObject day1;
    public GameObject item1;
    public GameObject day2;
    public GameObject item2;
    public GameObject day3;
    public GameObject item3;
    public GameObject day4;
    public GameObject item4;
    public GameObject day5;
    public GameObject item5;
    public GameObject day6;
    public GameObject item6;

    public void compareDates()
    {
        TimeSpan dayLength = new TimeSpan(1, 0, 0, 0, 0);
        TimeSpan dayLength2 = new TimeSpan(2, 0, 0, 0, 0);
        TimeSpan dayLength3 = new TimeSpan(3, 0, 0, 0, 0);
        TimeSpan dayLength4 = new TimeSpan(4, 0, 0, 0, 0);
        TimeSpan dayLength5 = new TimeSpan(5, 0, 0, 0, 0);
        TimeSpan dayLength6 = new TimeSpan(6, 0, 0, 0, 0);

        DateTime nowDay = System.DateTime.Now;
        //DateTime nowDay = new DateTime(2021, 3, 24);

        DateTime today = nowDay.Date;

        TimeSpan difference = today.Subtract(zeroD.date);

        Debug.Log(today);
        Debug.Log(difference.Days);
        Debug.Log("\nHello\nHello\nHello");

        if (difference.Days == 0)
        {
            sixD.date = today.Subtract(dayLength6);

            fiveD.date = today.Subtract(dayLength5);

            fourD.date = today.Subtract(dayLength4);

            threeD.date = today.Subtract(dayLength3);

            twoD.date = today.Subtract(dayLength2);

            oneD.date = today.Subtract(dayLength);

            zeroD.date = today;

            SavePlayer();
        }
        else if (difference.Days == 1)
        {
            sixD.date = fiveD.date;
            sixD.items = fiveD.items;
            fiveD.date = fourD.date;
            fiveD.items = fourD.items;
            fourD.date = threeD.date;
            fourD.items = threeD.items;
            threeD.date = twoD.date;
            threeD.items = twoD.items;
            twoD.date = oneD.date;
            twoD.items = oneD.items;
            oneD.date = zeroD.date;
            oneD.items = zeroD.items;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else if (difference.Days == 2)
        {
            sixD.date = fourD.date;
            sixD.items = fourD.items;
            fiveD.date = threeD.date;
            fiveD.items = threeD.items;
            fourD.date = twoD.date;
            fourD.items = twoD.items;
            threeD.date = oneD.date;
            threeD.items = oneD.items;
            twoD.date = zeroD.date;
            twoD.items = zeroD.items;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else if (difference.Days == 3)
        {
            sixD.date = threeD.date;
            sixD.items = threeD.items;
            fiveD.date = twoD.date;
            fiveD.items = twoD.items;
            fourD.date = oneD.date;
            fourD.items = oneD.items;
            threeD.date = zeroD.date;
            threeD.items = zeroD.items;

            twoD.date = today.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else if (difference.Days == 4)
        {
            sixD.date = twoD.date;
            sixD.items = twoD.items;
            fiveD.date = oneD.date;
            fiveD.items = oneD.items;
            fourD.date = zeroD.date;
            fourD.items = zeroD.items;

            threeD.date = today.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = today.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else if (difference.Days == 5)
        {
            sixD.date = oneD.date;
            sixD.items = oneD.items;
            fiveD.date = zeroD.date;
            fiveD.items = zeroD.items;

            fourD.date = today.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = today.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = today.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else if (difference.Days == 6)
        {
            sixD.date = zeroD.date;
            sixD.items = zeroD.items;

            fiveD.date = today.Subtract(dayLength5);
            fiveD.items = 0;

            fourD.date = today.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = today.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = today.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
        else
        {
            sixD.date = today.Subtract(dayLength6);
            sixD.items = 0;

            fiveD.date = today.Subtract(dayLength5);
            fiveD.items = 0;

            fourD.date = today.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = today.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = today.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = today.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = today;
            zeroD.items = 0;

            SavePlayer();
        }
    }

    public void addItem ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        zeroD.items += 1;
        SavePlayer();

        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
    }

    public void addPlastic ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        plasticRecycled += 1;
        zeroD.items += 1;
        SavePlayer();

        showPlastic.GetComponent<Text>().text = plasticRecycled.ToString();
    }

    public void addPaper ()
    {
        LoadPlayer();
        itemsRecycled += 1;
        paperRecycled += 1;
        zeroD.items += 1;
        SavePlayer();

        showPaper.GetComponent<Text>().text = paperRecycled.ToString();
    }

    public void addOrganic()
    {
        LoadPlayer();
        itemsRecycled += 1;
        organicRecycled += 1;
        zeroD.items += 1;
        SavePlayer();

        showOrganic.GetComponent<Text>().text = organicRecycled.ToString();
    }

    public void SavePlayer ()
    {
        day0.GetComponent<Text>().text = zeroD.date.ToString();
        item0.GetComponent<Text>().text = zeroD.items.ToString();

        day1.GetComponent<Text>().text = oneD.date.ToString();
        item1.GetComponent<Text>().text = oneD.items.ToString();

        day2.GetComponent<Text>().text = twoD.date.ToString();
        item2.GetComponent<Text>().text = twoD.items.ToString();

        day3.GetComponent<Text>().text = threeD.date.ToString();
        item3.GetComponent<Text>().text = threeD.items.ToString();

        day4.GetComponent<Text>().text = fourD.date.ToString();
        item4.GetComponent<Text>().text = fourD.items.ToString();

        day5.GetComponent<Text>().text = fiveD.date.ToString();
        item5.GetComponent<Text>().text = fiveD.items.ToString();

        day6.GetComponent<Text>().text = sixD.date.ToString();
        item6.GetComponent<Text>().text = sixD.items.ToString();

        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        itemsRecycled = data.itemsRecycled;
        plasticRecycled = data.plasticRecycled;
        paperRecycled = data.paperRecycled;
        organicRecycled = data.organicRecycled;
        language = data.language;

        zeroD.date = data.zeroD.date;
        zeroD.items = data.zeroD.items;
        oneD.date = data.oneD.date;
        oneD.items = data.oneD.items;
        twoD.date = data.twoD.date;
        twoD.items = data.twoD.items;
        threeD.date = data.threeD.date;
        threeD.items = data.threeD.items;
        fourD.date = data.fourD.date;
        fourD.items = data.fourD.items;
        fiveD.date = data.fiveD.date;
        fiveD.items = data.fiveD.items;
        sixD.date = data.sixD.date;
        sixD.items = data.sixD.items;
    }

    public void toEnglish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(SystemLanguage.English);
    }

    public void toFrench()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(SystemLanguage.French);
    }

    public void changeLanguage()
    {
        LoadPlayer();

        if (language == 0)
        {
            language += 1;
            toFrench();
            Debug.Log("Language=1");
        }
        else
        {
            language -= 1;
            toEnglish();
            Debug.Log("Language=0");
        }

        SavePlayer();
    }

    void Awake()
    {
        //SavePlayer();

        if (File.Exists(Application.persistentDataPath + "/player.info"))
        {
            LoadPlayer();
        }
        else
        {
            zeroD.date = System.DateTime.Now;

            SavePlayer();
          
            LoadPlayer();
        }

        compareDates();

        showItems.GetComponent<Text>().text = itemsRecycled.ToString();
        showPlastic.GetComponent<Text>().text = plasticRecycled.ToString();
        showPaper.GetComponent<Text>().text = paperRecycled.ToString();
        showOrganic.GetComponent<Text>().text = organicRecycled.ToString();

        day0.GetComponent<Text>().text = zeroD.date.ToString();
        item0.GetComponent<Text>().text = zeroD.items.ToString();

        day1.GetComponent<Text>().text = oneD.date.ToString();
        item1.GetComponent<Text>().text = oneD.items.ToString();

        day2.GetComponent<Text>().text = twoD.date.ToString();
        item2.GetComponent<Text>().text = twoD.items.ToString();

        day3.GetComponent<Text>().text = threeD.date.ToString();
        item3.GetComponent<Text>().text = threeD.items.ToString();

        day4.GetComponent<Text>().text = fourD.date.ToString();
        item4.GetComponent<Text>().text = fourD.items.ToString();

        day5.GetComponent<Text>().text = fiveD.date.ToString();
        item5.GetComponent<Text>().text = fiveD.items.ToString();

        day6.GetComponent<Text>().text = sixD.date.ToString();
        item6.GetComponent<Text>().text = sixD.items.ToString();
    }
}
