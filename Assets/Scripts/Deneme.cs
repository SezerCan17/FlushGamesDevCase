using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private List<GameObject> cubes = new List<GameObject>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol týklama
        {
            AddCube();
        }
        else if (Input.GetMouseButtonDown(1) && cubes.Count > 0) // Sað týklama
        {
            RemoveLastCube();
        }
    }

    void AddCube()
    {
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubes.Add(newCube);

        // Yeni küpü bir öncekine yerleþtir
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
