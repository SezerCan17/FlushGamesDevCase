using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sales_Area : MonoBehaviour
{
    public static Sales_Area instance;

    private void Awake()
    {
        instance = this;
    }
    public void sales_Gem()
    {
        StartCoroutine(Time_Counter.instance.SalesCoroutine());
        /*int lastGem = Stack_Back.instance.gemCount;
        for(int i = lastGem-1; i > 0; i--)
        {
            
            //Stack_Back.instance.stack_remove();

        }*/
        
        
    }
}
