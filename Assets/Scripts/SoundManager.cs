using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource CollectGem;
    [SerializeField] private AudioSource SalesGem;

    public static SoundManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void Collect_Gem()
    {
        Debug.Log("Collect_Gem");
        CollectGem.Play();
    }

    public void Sales_Gem()
    {
        SalesGem.Play();
    }
}
