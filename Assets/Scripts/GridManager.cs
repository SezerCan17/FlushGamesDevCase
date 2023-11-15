using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSizeX = 4; // Satýr sayýsý
    public int gridSizeY = 3; // Sütun sayýsý
    public float gapSize = 0.2f; // Küpler arasýndaki boþluk
    public GameObject cubePrefab; // Kullanýlacak küp prefabý

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
                cube.transform.SetParent(transform); // Oluþturulan küpü bu scriptin baðlý olduðu objeye child olarak ata
            }
        }
    }
}






