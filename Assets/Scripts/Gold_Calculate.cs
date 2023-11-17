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

    public void Green_Gold_Calculate(float x)
    {

        Debug.Log("Green Toplandý");
        price += (GemInformation.instance.gem_First_Price[0]+x*100);
        Debug.Log(Gem_Interaction.Instance.scaleValue +"bu");
        Debug.Log(price);
        UI_Manager.instance.Gold_Text(price);

    }
    public void Pink_Gold_Calculate(float x)
    {
        Debug.Log("Pink Toplandý");
        price += (GemInformation.instance.gem_First_Price[1] + x * 100);
        Debug.Log(price);
        UI_Manager.instance.Gold_Text(price);
    }
    public void Yellow_Gold_Calculate(float x)
    {
        Debug.Log("Yellow Toplandý");
        price += (GemInformation.instance.gem_First_Price[2] + x * 100);
        Debug.Log(price);
        UI_Manager.instance.Gold_Text(price);
    }
}
