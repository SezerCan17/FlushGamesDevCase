using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem_Interaction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
        }
        /*if (collision.gameObject.tag == "Pink")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Yellow")
        {
            Destroy(gameObject);
        }*/
    }
}
