using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Stack_Back : MonoBehaviour
{
    public static Stack_Back instance;
    public Stack<GameObject> stackGems = new Stack<GameObject>();
    public List<GameObject> stackObjects = new List<GameObject>();
    public GameObject stack;
    public float yOffset = 1.0f;
    public GameObject player;
    Vector3 targetPosition;
    

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        stackObjects.Add(stack);
        Debug.Log(stackGems.Peek().transform.position);
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

    public void Stack_Gems(GameObject obje)
    {
        obje.transform.position = new Vector3(stack.transform.position.x, stack.transform.position.y+ yOffset , stack.transform.position.z);
        yOffset += 1f;
        obje.transform.SetParent(transform);
    }
    private void UpdateStackPosition()
    {
        for(int i = 0; i < stackObjects.Count; i++)
        {
            stackObjects[i].transform.position = new Vector3(stack.transform.position.x, stackObjects[i].transform.position.y,stack.transform.position.z);
            //targetPosition.z = stack.transform.position.z;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
        

    }
}
