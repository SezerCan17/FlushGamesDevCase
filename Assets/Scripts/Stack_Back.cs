using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Stack_Back : MonoBehaviour
{
    public static Stack_Back instance;
    public List<GameObject> stackObjects = new List<GameObject>();
    public GameObject stack;
    public float yOffset = 1.0f;
    public GameObject player;
    public int gemCount;
    Vector3 targetPosition;
    

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        stackObjects.Add(stack);
    }

    private void FixedUpdate()
    {
        stack.transform.position = new Vector3(player.transform.position.x,player.transform.position.y, player.transform.position.z-2);  
        UpdateStackPosition();
    }

    public void stack_push(GameObject obje)
    {
        GameObject stackObject = Instantiate(obje, obje.transform.position, Quaternion.identity);
        Destroy(obje);
        stackObjects.Add(stackObject);
        Stack_Gems(stackObject);
    }
    public void stack_remove()
    {
        GameObject lastGem = stackObjects[stackObjects.Count-1];
        stackObjects.Remove(lastGem);
        Destroy(lastGem);
        gemCount = stackObjects.Count;
        /*stackObjects.Remove(stackObjects.Last());
        
        Debug.Log("GameCountremove" + gemCount);
        Destroy(stackObjects.Last());*/
    }

    public void Stack_Gems(GameObject obje)
    {
        Vector3 lastGemPos = stackObjects[stackObjects.Count-2].transform.position;
        //obje.transform.position = new Vector3(stack.transform.position.x, stack.transform.position.y+ yOffset , stack.transform.position.z);
        //yOffset += 1f;
        //obje.transform.SetParent(transform);
        obje.transform.position = new Vector3(lastGemPos.x,lastGemPos.y+1f, lastGemPos.z);
        gemCount = stackObjects.Count;
        Debug.Log("GameCount" + gemCount);
    }
    private void UpdateStackPosition()
    {
        
        for (int i = 0; i < gemCount; i++)
        {
            stackObjects[i].transform.position = new Vector3(stack.transform.position.x, stackObjects[i].transform.position.y,stack.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
        
    }

}
