using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem_Interaction : MonoBehaviour
{
    public static Gem_Interaction Instance;
    public Vector3 scaleValue;
    public Vector3 Gem_position;
   

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Sales_Area")
        {
            scaleValue = other.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                string collidedObjectName = other.gameObject.tag;
                Debug.Log(collidedObjectName + "collidedname");
                Stack_Back.instance.stack_push(other.gameObject);
                int idx = GemInformation.instance.FindIndexOfGem(collidedObjectName);
                Gem_position = other.gameObject.transform.position;
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);



                Debug.Log(idx + " idx");
            }
            
        }

        else
        {
                Debug.Log("Satýþ alanýnda");
                Sales_Area.instance.sales_Gem();
                //Stack_Back.instance.stack_remove2();

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Sales_Area")
        {
            Debug.Log("satýþ alanýndan çýkýldý");
        }
    }
    /*private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Green"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                Gem_position = collision.gameObject.transform.position;
                Stack_Back.instance.stack_push(collision.gameObject);
                Debug.Log(scaleValue + "ss");
                int idx = GemInformation.instance.FindIndexOfGem("Green");//Gold_Calculate.instance.Green_Gold_Calculate(scaleValue.x);
                Stack_Back.instance.stack_remove(idx);
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);
                
               
             
            }
        }
        if (collision.CompareTag("Pink"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                //Gold_Calculate.instance.Pink_Gold_Calculate(scaleValue.x);
                Stack_Back.instance.stack_push(collision.gameObject);
                Gem_position = collision.gameObject.transform.position;
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);
               
                
              
            }
        }
        if (collision.CompareTag("Yellow"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            Stack_Back.instance.stack_push(collision.gameObject);
            //Gold_Calculate.instance.Yellow_Gold_Calculate(scaleValue.x);
            Gem_position = collision.gameObject.transform.position;
            SpawnGem.instance.Spawn_Gem_Again(Gem_position);
            
        }

        
    }*/
}
