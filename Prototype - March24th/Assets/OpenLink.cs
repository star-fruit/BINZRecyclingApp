using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenMainPage()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl");
    }

    public void OpenPlasticBottle()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Plastic+Bottles&lang=en");
    }

    public void OpenPizzaBox()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Pizza+Box+%28clean%29&lang=en");
    }

    public void OpenYogurtContainer()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Single+Serve+Yogurt+Containers+%28plastic%29&lang=en");
    }

    public void OpenAluminumCan()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Aluminium+Cans&lang=en");
    }

    public void OpenBatteries()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Batteries+%28AA%2C+AAA%2C+C%2C+D%2C+button+cell%29&lang=en");
    }

    public void OpenApple()
    {
        Application.OpenURL("https://app06.ottawa.ca/cgi-bin/search/recycle/q.pl?q=Apples&lang=en");
    }
}
