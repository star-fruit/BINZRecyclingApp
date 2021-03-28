using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    [SerializeField]
    private InputField mainInput;

    public GameObject plasticBottle;
    public GameObject pizzaBox;
    public GameObject yogurtContainer;
    public GameObject aluminumCan;
    public GameObject batteries;
    public GameObject apple;
    public GameObject tinCan;
    public GameObject eggCarton;

    // Update is called once per frame
    void Update()
    {
        if (mainInput.text == "plastic bottle")
        {
            plasticBottle.SetActive(true);
        }

        if (mainInput.text == "pizza box")
        {
            pizzaBox.SetActive(true);
        }

        if (mainInput.text == "yogurt container")
        {
            yogurtContainer.SetActive(true);
        }

        if (mainInput.text == "aluminum can")
        {
            aluminumCan.SetActive(true);
        }

        if (mainInput.text == "batteries")
        {
            batteries.SetActive(true);
        }

        if (mainInput.text == "apple")
        {
            apple.SetActive(true);
        }

        if (mainInput.text == "tin can")
        {
            tinCan.SetActive(true);
        }

        if(mainInput.text == "egg carton")
        {
            eggCarton.SetActive(true);
        }
    }

    public void clearInputField ()
    {
        mainInput.text = "";
    }
}
