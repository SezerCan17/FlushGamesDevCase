using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemInformation : MonoBehaviour 
{
    public static GemInformation instance;
    public string[] gemName;
    public float[] gem_First_Price;
    [SerializeField] private Sprite[] icon;
    public GameObject[] gem_Model;

    public GemInformation(string[] names, float[] prices, Sprite[] icons, GameObject[] models)
    {
        gemName = names;
        gem_First_Price = prices;
        icon = icons;
        gem_Model = models;
    }


    public int FindIndexOfGem(string gemNameToFind)
    {
        for (int i = 0; i < gemName.Length; i++)
        {
            if (gemName[i] == gemNameToFind)
            {
                return i; 
            }
        }
        return -1;
    }

    private void Awake()
    {
        instance = this;
    }
}
