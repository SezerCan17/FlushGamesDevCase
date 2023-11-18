using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sales_Area : MonoBehaviour
{
    public static Sales_Area instance;
    private int greenC;
    private int pinkC;
    private int yellowC;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        greenC = PlayerPrefs.GetInt("greenC");
        pinkC = PlayerPrefs.GetInt("pinkC");
        yellowC = PlayerPrefs.GetInt("yellowC");
    }
    public void sales_Gem(int idx, Vector3 scaleValue)
    {
        Gold_Calculate.instance.GoldCalculate(idx,scaleValue);
        
    }
    public void CollectData(string name,Vector3 scaleValue)
    {

        int idx = GemInformation.instance.FindIndexOfGem(name);
        Collected_Count(name);
        sales_Gem(idx, scaleValue);

    }

    public void Collected_Count(string name)
    {
        switch (name)
        {
            case "Green":
                greenC++;
                Debug.Log(greenC);
                UI_Manager.instance.Pop_up_CollectedGreen(greenC);
                break;

            case "Pink":
                pinkC++;
                Debug.Log(pinkC);
                UI_Manager.instance.Pop_up_CollectedPink(pinkC);
                break;

            case "Yellow":
                yellowC++;
                Debug.Log(yellowC);
                UI_Manager.instance.Pop_up_CollectedYellow(yellowC);
                break;

        }
        
    }


}
