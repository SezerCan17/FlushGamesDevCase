using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    public static SpawnGem instance;
    [SerializeField] private GameObject[] gems;
    public int[] ID;
    private float x;
    private float y;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        
    }
    public void Spawn_Gem()
    {
        int randomIndex = Random.Range(0, gems.Length);
        Vector3 posG = new Vector3(GridCreator.instance.cubePosition.x, GridCreator.instance.cubePosition.y+1, GridCreator.instance.cubePosition.z);
        //Vector3 cubePosition = new Vector3(x * (GridCreator.instance.cubeSize + GridCreator.instance.gapSize), 0, y * (GridCreator.instance.cubeSize + GridCreator.instance.gapSize)) + GridCreator.instance.gridOffset;
        GameObject gemInstance = Instantiate(gems[randomIndex], posG, Quaternion.identity);
        gemInstance.transform.localScale=new Vector3(0f,0f, 0f);
       
        StartCoroutine(Time_Counter.instance.SlowAfterAWhileCoroutine(gemInstance));
    }
    public void Spawn_Gem_Again(Vector3 pos)
    {
        int randomIndex = Random.Range(0, gems.Length);
        GameObject gemInstance = Instantiate(gems[randomIndex], pos, Quaternion.identity);
        gemInstance.transform.localScale = new Vector3(0f, 0f, 0f);
        StartCoroutine(Time_Counter.instance.SlowAfterAWhileCoroutine(gemInstance));
    }

    
}
