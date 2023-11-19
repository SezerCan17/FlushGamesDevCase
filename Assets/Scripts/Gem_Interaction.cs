using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem_Interaction : MonoBehaviour
{
    public static Gem_Interaction Instance;

    public Vector3 scaleValue { get; private set; }
    public Vector3 Gem_position { get; private set; }


    public static Gem_Interaction instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Gem_Interaction>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("GemInteractionSingleton");
                    instance = singletonObject.AddComponent<Gem_Interaction>();
                }
            }

            return instance;
        }
        private set { } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Sales_Area")
        {
            scaleValue = other.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                Stack_Back.instance.stack_push(other.gameObject);
                Gem_position = other.gameObject.transform.position;
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);
                SoundManager.Instance.Collect_Gem();
            }
            
        }

        else
        {
                Debug.Log("Satýþ alanýnda");
                StartCoroutine(Time_Counter.instance.SalesCoroutine());
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Sales_Area")
        {
            Debug.Log("satýþ alanýndan çýkýldý");
        }
    }
    
}
