using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;
    [SerializeField] TMP_Text text;
    public GameObject Pop_up;
    public GameObject Cancel_Button;
    private void Awake()
    {
        instance = this;
    }

    public void Gold_Text(float price)
    {
        text.text = "Gold:" + price;
    }

    public void Pop_upButton()
    {
        Pop_up.SetActive(true);
        Cancel_Button.SetActive(true);
    }
    public void CancelButton()
    {
        Pop_up.SetActive(false);
        Cancel_Button.SetActive(false);
    }

    
}
