using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    public static SpawnGem instance;
    [SerializeField] private GameObject[] gems;
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
        //Vector3 cubePosition = new Vector3(x * (GridCreator.instance.cubeSize + GridCreator.instance.gapSize), 0, y * (GridCreator.instance.cubeSize + GridCreator.instance.gapSize)) + GridCreator.instance.gridOffset;
        GameObject gemInstance = Instantiate(gems[randomIndex],GridCreator.instance.cubePosition, Quaternion.identity);
        
    }

    
}
