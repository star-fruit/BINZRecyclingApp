using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

/*
    this script was transferred to player due to the need for the language variable to be saved
*/

public class Language : MonoBehaviour
{
    int language = 0;

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
        if(language==0)
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
    }
}
