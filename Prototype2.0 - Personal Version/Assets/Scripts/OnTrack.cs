using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrack : MonoBehaviour
{
    public GameObject displayText;
    public GameObject display;
    public Color defaultColor;
    public Color binColor;

    public Button button;
    public GameObject buttonOpenPage;
    public GameObject buttonText;
    public GameObject targetName;

    public GameObject popUp;
    public GameObject popUpText;

    public GameObject binDisplay;
    public GameObject binTextUI;
    public GameObject binTextDatabase;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeDisplay()
    {
        displayText.GetComponent<Text>().text = targetName.name;
        button.onClick.AddListener(openDatabase);
        buttonText.GetComponent<Text>().text = "More Information on\n" + targetName.name;

        display.GetComponent<Image>().color = binColor;
        binDisplay.GetComponent<Image>().color = binColor;
        button.GetComponent<Image>().color = binColor;


        binTextUI.GetComponent<Text>().text = "Place in:\n" + binTextDatabase.GetComponent<Text>().text;

        Invoke("showPopUp", 3);
        popUpText.GetComponent<Text>().text = "Did You Recycle\n" + targetName.name + "?";
    }

    public void revertDisplay()
    {
        displayText.GetComponent<Text>().text = "Center Object";
        button.onClick.RemoveListener(openDatabase);
        buttonText.GetComponent<Text>().text = "Not Viewing Anything";

        display.GetComponent<Image>().color = defaultColor;
        binDisplay.GetComponent<Image>().color = defaultColor;
        button.GetComponent<Image>().color = defaultColor;

        binTextUI.GetComponent<Text>().text = "Not Viewing Anything";

        hidePopUp();

    }

    public void openDatabase()
    {
        buttonOpenPage.SetActive(true);
    }

    public void showPopUp()
    {
        popUp.SetActive(true);
    }

    public void hidePopUp()
    {
        popUp.SetActive(false);
    }
}
