using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoTweenManager : MonoBehaviour
{
    public static DoTweenManager instance;


    public static DoTweenManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DoTweenManager>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("DoTweenManagerSingleton");
                    instance = singletonObject.AddComponent<DoTweenManager>();
                }
            }

            return instance;
        }
    }


    public void GemSales_DoMove(GameObject lastGem)
    {
        Vector3 targetPositionDown = new Vector3(lastGem.transform.position.x + 3f, lastGem.transform.position.y - 3f, lastGem.transform.position.z);
        lastGem.transform.DOMove(targetPositionDown, 0.1f)
            .SetEase(Ease.InQuad)
            .OnComplete(() => Destroy(lastGem));
    }


}
