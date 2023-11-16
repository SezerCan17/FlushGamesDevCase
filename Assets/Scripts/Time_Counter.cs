using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("Sayd�");
        gemsScale.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
        yield return new WaitForSeconds(1.25f);
        gemsScale.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        yield return new WaitForSeconds(1.25f);
        gemsScale.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        yield return new WaitForSeconds(1.25f);
        gemsScale.transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log("sayd�2");
    }
}