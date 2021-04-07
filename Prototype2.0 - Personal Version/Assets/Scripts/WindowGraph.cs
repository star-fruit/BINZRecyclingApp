using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class WindowGraph : MonoBehaviour
{
    [SerializeField] private Sprite circleSprite;
    
    private RectTransform graphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    public GameObject playerObject;
    private Player playerScript;

    private void Awake()
    {
        graphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("labelTemplateY").GetComponent<RectTransform>();

        playerScript = playerObject.GetComponent<Player>();

        int value1 = playerScript.zeroD.items;
        int value2 = playerScript.oneD.items;
        int value3 = playerScript.twoD.items;
        int value4 = playerScript.threeD.items;
        int value5 = playerScript.fourD.items;
        int value6 = playerScript.fiveD.items;
        int value7 = playerScript.sixD.items;

        List<int> valueList = new List<int>() {value7, value6, value5, value4, value3, value2, value1};
        Debug.Log("Hello Hello Hello");
        Debug.Log(valueList[0]);

        ShowGraph(valueList);
    }

    private GameObject CreateCircle(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform1 = gameObject.GetComponent<RectTransform>();
        rectTransform1.anchoredPosition = anchoredPosition;
        rectTransform1.sizeDelta = new Vector2(15, 15);
        rectTransform1.anchorMin = new Vector2(0, 0);
        rectTransform1.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private void ShowGraph(List<int> valueList)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = 10f;
        float xSize = 115f;

        GameObject lastCircleGameObject = null;
        for(int i =0; i<7;i++)
        {
            float xPosition = i * xSize;
            float yPosition = (valueList[i] / yMaximum) * graphHeight;
            GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            if(lastCircleGameObject != null)
            {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameObject;

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(graphContainer);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition-100f, -205f);
            labelX.GetComponent<Text>().text = (i+1).ToString();
        }

        int seperatorCount = 10;
        for(int i=0; i<seperatorCount; i++)
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / seperatorCount;
            labelY.anchoredPosition = new Vector2(-210f, (normalizedValue*graphHeight - 85f));
            labelY.GetComponent<Text>().text = Mathf.RoundToInt(normalizedValue * yMaximum).ToString();
        }
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f);
        RectTransform rectTransform1 = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform1.anchorMin = new Vector2(0, 0);
        rectTransform1.anchorMax = new Vector2(0, 0);
        rectTransform1.sizeDelta = new Vector2(distance, 3f);
        rectTransform1.anchoredPosition = dotPositionA + dir*distance*0.5f;
        rectTransform1.localEulerAngles = new Vector3(0,0, UtilsClass.GetAngleFromVectorFloat(dir));
    }
}
