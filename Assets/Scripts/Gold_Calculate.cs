using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_Calculate : MonoBehaviour
{
    public static Gold_Calculate instance;
    private float price;
    //private Vector3 scaleX;
    private void Awake()
    {
       instance = this;
    }
    private void Start()
    {
        price = PlayerPrefs.GetFloat("price");
    }

    public void GoldCalculate(int idx, Vector3 scaleValue)
    {
        float x = scaleValue.x;
        price += (GemInformation.instance.gem_First_Price[idx] + x * 100);
        PlayerPrefs.SetFloat("price", price);
        UI_Manager.instance.Gold_Text(price);
    }

}
