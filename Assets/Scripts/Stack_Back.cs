using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class Stack_Back : MonoBehaviour
{
    public static Stack_Back instance;
    [SerializeField] protected List<GameObject> stackObjects = new List<GameObject>();
    [SerializeField] private float yOffset = 1.0f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Gems;

    public int gemCount;
    public GameObject stack;

    public static Stack_Back Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Stack_Back>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("GemStackSingleton");
                    instance = singletonObject.AddComponent<Stack_Back>();
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        
    }
    private void Start()
    {
        stackObjects.Add(stack);
        DoTweenManager doTweenManager = DoTweenManager.Instance;
    }

    private void FixedUpdate()
    {
        stack.transform.position = new Vector3(player.transform.position.x,player.transform.position.y, player.transform.position.z-2);

        UpdateStackPosition();
    }

    

    public void stack_push(GameObject obje)
    {
        GameObject stackObject = Instantiate(obje, obje.transform.position, Quaternion.identity);
        stackObjects.Add(stackObject);
        stackObject.transform.SetParent(Gems.transform);
        Stack_Gems(stackObject);
        Destroy(obje);
    }
    public void stack_remove()
    {
        GameObject lastGem = stackObjects[stackObjects.Count-1];

        Vector3 scaleValue = lastGem.transform.localScale;
        string name = lastGem.tag;

        Sales_Area.instance.CollectData(name,scaleValue);
        DoTweenManager.instance.GemSales_DoMove(lastGem);
        
        

        stackObjects.Remove(lastGem);
        gemCount = stackObjects.Count;
    }
    
    public void Stack_Gems(GameObject obje)
    {
        Vector3 lastGemPos = stackObjects[stackObjects.Count - 2].transform.position;
        obje.transform.position = new Vector3(lastGemPos.x, lastGemPos.y + yOffset, lastGemPos.z);
        gemCount = stackObjects.Count;
       
    }
    private void UpdateStackPosition()
    {
        for (int i = 0; i < gemCount; i++)
        {
            stackObjects[i].transform.position = new Vector3(stack.transform.position.x, stackObjects[i].transform.position.y,stack.transform.position.z);
            
        }
    }

}
