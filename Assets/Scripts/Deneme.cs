using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private List<GameObject> cubes = new List<GameObject>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol t�klama
        {
            AddCube();
        }
        else if (Input.GetMouseButtonDown(1) && cubes.Count > 0) // Sa� t�klama
        {
            RemoveLastCube();
        }
    }

    void AddCube()
    {
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubes.Add(newCube);

        // Yeni k�p� bir �ncekine yerle�tir
        if (cubes.Count > 1)
        {
            Vector3 lastCubePosition = cubes[cubes.Count - 2].transform.position;
            newCube.transform.position = new Vector3(lastCubePosition.x, lastCubePosition.y + 1f, lastCubePosition.z);
        }
    }

    void RemoveLastCube()
    {
        GameObject lastCube = cubes[cubes.Count - 1];
        cubes.Remove(lastCube);
        Destroy(lastCube);
    }
}
