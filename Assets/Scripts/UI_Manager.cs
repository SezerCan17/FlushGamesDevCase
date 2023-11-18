using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;
    [SerializeField] TMP_Text text;
    public GameObject Pop_up;
    public GameObject Cancel_Button;
    public TMP_Text textG;
    public TMP_Text textP;
    public TMP_Text textY;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        int greenC = PlayerPrefs.GetInt("greenC");
        int pinkC = PlayerPrefs.GetInt("pinkC");
        int yellowC = PlayerPrefs.GetInt("yellowC");

        Pop_up_CollectedGreen(greenC);
        Pop_up_CollectedPink(pinkC);
        Pop_up_CollectedYellow(yellowC);
        
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

    public void Pop_up_CollectedGreen(int counter)
    {
        textG.text = "Collected Counter:"+ counter;
        PlayerPrefs.SetInt("greenC", counter);
    }

    public void Pop_up_CollectedPink(int counter)
    {
        textP.text= "Collected Counter:" + counter;
        PlayerPrefs.SetInt("pinkC", counter);
    }

    public void Pop_up_CollectedYellow(int counter)
    {
        textY.text = "Collected Counter:" + counter;
        PlayerPrefs.SetInt("yellowC", counter);
    }
}
