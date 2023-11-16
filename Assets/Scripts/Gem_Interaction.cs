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
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Green"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                Gem_position = collision.gameObject.transform.position;
                Debug.Log(scaleValue + "ss");
                Gold_Calculate.instance.Green_Gold_Calculate(scaleValue.x);
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);
                Destroy(collision.gameObject);
            }
        }
        if (collision.CompareTag("Pink"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            if(scaleValue != Vector3.zero)
            {
                Gold_Calculate.instance.Pink_Gold_Calculate(scaleValue.x);
                Gem_position = collision.gameObject.transform.position;
                SpawnGem.instance.Spawn_Gem_Again(Gem_position);
                Destroy(collision.gameObject);
            }
        }
        if (collision.CompareTag("Yellow"))
        {
            scaleValue = collision.gameObject.transform.localScale;
            Gold_Calculate.instance.Yellow_Gold_Calculate(scaleValue.x);
            Gem_position = collision.gameObject.transform.position;
            SpawnGem.instance.Spawn_Gem_Again(Gem_position);
            Destroy(collision.gameObject);
        }
    }
}
