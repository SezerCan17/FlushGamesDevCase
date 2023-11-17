using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sales_Area : MonoBehaviour
{
    public static Sales_Area instance;
    private int greenC = 0;
    private int pinkC = 0;
    private int yellowC = 0;


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
        sales_Gem(idx, scaleValue);

    }

    public void Collected_Count(string name)
    {
        switch (name)
        {
            case "Green":
                greenC++;
                break;

            case "Pink":
                pinkC++;
                break;

            case "Yellow":
                yellowC++;
                break;

        }
        PlayerPrefs.SetInt("greenC", greenC);
        PlayerPrefs.SetInt("pinkC", pinkC);
        PlayerPrefs.SetInt("yellowC", yellowC);
    }


}
