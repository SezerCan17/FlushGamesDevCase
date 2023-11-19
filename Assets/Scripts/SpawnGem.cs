using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    public static SpawnGem instance;
    [SerializeField] GameObject Gems;
    

    private void Awake()
    {
        instance = this;
       
    }
    
    public void Spawn_Gem()
    {
        int randomIndex = Random.Range(0, GemInformation.instance.gemName.Length);
        Vector3 posG = new Vector3(GridCreator.instance.cubePosition.x, GridCreator.instance.cubePosition.y+1, GridCreator.instance.cubePosition.z);
        GameObject gemInstance = Instantiate(GemInformation.instance.gem_Model[randomIndex], posG, Quaternion.identity);
        gemInstance.transform.localScale=new Vector3(0f,0.0f, 0f);
        gemInstance.transform.SetParent(Gems.transform);

        StartCoroutine(Time_Counter.instance.SlowAfterAWhileCoroutine(gemInstance));
    }
    public void Spawn_Gem_Again(Vector3 pos)
    {
        int randomIndex = Random.Range(0, GemInformation.instance.gem_Model.Length);
        GameObject gemInstance = Instantiate(GemInformation.instance.gem_Model[randomIndex], pos, Quaternion.identity);
        gemInstance.transform.localScale = new Vector3(0f, 0f, 0f);
        gemInstance.transform.SetParent(Gems.transform);
        StartCoroutine(Time_Counter.instance.SlowAfterAWhileCoroutine(gemInstance));
    }

    
}
