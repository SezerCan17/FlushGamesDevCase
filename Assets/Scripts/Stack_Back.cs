using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Stack_Back : MonoBehaviour
{
    public static Stack_Back instance;
    private Stack<GameObject> stackGems;
    public float yOffset = 1.0f;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        stackGems = new Stack<GameObject>();
    }

    public void stack_push(GameObject obje)
    {
        stackGems.Push(obje);

    }

    public void Stack_Gems()
    {
       
    }
}
