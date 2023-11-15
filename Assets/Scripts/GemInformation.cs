using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemInformation : MonoBehaviour 
{
    public static GemInformation instance;
    public string[] gemName;
    public float[] gem_First_Price;
    [SerializeField] private Sprite[] icon;
    [SerializeField] private GameObject[] gem_Model;

    private void Awake()
    {
        instance = this;
    }
}
