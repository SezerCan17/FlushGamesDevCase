using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class Stack_Back : MonoBehaviour
{
    public static Stack_Back instance;
    public List<GameObject> stackObjects = new List<GameObject>();
    public GameObject stack;
    public float yOffset = 1.0f;
    public GameObject player;
    public int gemCount;
    public GameObject Sales_Area;
    
    

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
        Debug.Log(stackObject.name+"ismi bu iþte");
        stackObjects.Add(stackObject);
        Stack_Gems(stackObject);
        Destroy(obje);
    }
    public void stack_remove()
    {
        GameObject lastGem = stackObjects[stackObjects.Count-1];
        Vector3 targetPositionDown = new Vector3(lastGem.transform.position.x + 3f, lastGem.transform.position.y - 3f, lastGem.transform.position.z);
        lastGem.transform.DOMove(targetPositionDown, 1f)
            .SetEase(Ease.InQuad)  
            .OnComplete(() => Destroy(lastGem));
        stackObjects.Remove(lastGem);
        
      
    }
    

    public void Stack_Gems(GameObject obje)
    {
        Vector3 lastGemPos = stackObjects[stackObjects.Count - 2].transform.position;

        obje.transform.position = new Vector3(lastGemPos.x, lastGemPos.y + 1.0f, lastGemPos.z);
        gemCount = stackObjects.Count;
        Debug.Log("GameCount" + gemCount);
    }
    private void UpdateStackPosition()
    {
        
        for (int i = 0; i < gemCount; i++)
        {
            stackObjects[i].transform.position = new Vector3(stack.transform.position.x, stackObjects[i].transform.position.y,stack.transform.position.z);
            
        }
    }

}
