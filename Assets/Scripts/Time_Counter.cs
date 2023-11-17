using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Time_Counter : MonoBehaviour
{
    public static Time_Counter instance;
    private void Awake()
    {
        instance = this;
    }

    public IEnumerator SlowAfterAWhileCoroutine(GameObject gemsScale)
    {
        
        Debug.Log("Geldi");
        yield return new WaitForSeconds(1.25f);
        Debug.Log("Saydý");
        if(gemsScale != null)
        {
            gemsScale.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            yield return new WaitForSeconds(1.25f);
            gemsScale.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            yield return new WaitForSeconds(1.25f);
            gemsScale.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            yield return new WaitForSeconds(1.25f);
            gemsScale.transform.localScale = new Vector3(1f, 1f, 1f);
            Debug.Log("saydý2");
            
        }
    }
   public IEnumerator SalesCoroutine()
    {
        
        for(int i = Stack_Back.instance.gemCount; i >1; i--) 
        {
            yield return new WaitForSeconds(1.0f);
            
            Stack_Back.instance.stack_remove();
        }
    }
}
