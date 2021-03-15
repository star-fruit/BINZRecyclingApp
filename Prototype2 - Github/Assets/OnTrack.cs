using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrack : MonoBehaviour
{
    public GameObject displayText;
    public GameObject buttonText;
    public GameObject targetName;

    public GameObject popUp;
    public GameObject popUpText;

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
        buttonText.GetComponent<Text>().text = "More Information on\n" + targetName.name;

        Invoke("showPopUp", 5);
        popUpText.GetComponent<Text>().text = "Did You Recycle\n" + targetName.name + "?";
    }

    public void revertDisplay()
    {
        displayText.GetComponent<Text>().text = "Center Object";
        buttonText.GetComponent<Text>().text = "Not Viewing Anything";

        hidePopUp();

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
