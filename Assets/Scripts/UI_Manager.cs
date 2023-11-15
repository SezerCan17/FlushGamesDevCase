using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;
    [SerializeField] TMP_Text text;
    private void Awake()
    {
        instance = this;
    }

    public void Gold_Text(float price)
    {
        text.text = "Gold:" + price;
    }
}
