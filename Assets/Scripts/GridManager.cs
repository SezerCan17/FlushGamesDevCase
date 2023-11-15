using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSizeX = 4; // Sat�r say�s�
    public int gridSizeY = 3; // S�tun say�s�
    public float gapSize = 0.2f; // K�pler aras�ndaki bo�luk
    public GameObject cubePrefab; // Kullan�lacak k�p prefab�

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        float totalGapX = (gridSizeX - 1) * gapSize;
        float totalGapY = (gridSizeY - 1) * gapSize;

        float totalWidth = gridSizeX + totalGapX;
        float totalHeight = gridSizeY + totalGapY;

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                float xPos = x - totalWidth / 2 + x * gapSize;
                float yPos = y - totalHeight / 2 + y * gapSize;

                Vector3 cubePosition = new Vector3(xPos, 0, yPos);
                GameObject cube = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
                cube.transform.SetParent(transform); // Olu�turulan k�p� bu scriptin ba�l� oldu�u objeye child olarak ata
            }
        }
    }
}






