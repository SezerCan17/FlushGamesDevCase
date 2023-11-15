using UnityEngine;

public class GridCreator : MonoBehaviour
{
    public int gridSizeX = 4; // Default deðerler
    public int gridSizeY = 4;
    public float cubeSize = 1.0f;
    public float gapSize = 0.1f; // Boþluk boyutu
    public Vector3 gridOffset = Vector3.zero; // Gridin konumu
    public Vector3 cubePosition;

    private Transform cubesParent; // Küplerin ebeveyni
    public static GridCreator instance;
    public GameObject Cube;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        cubesParent = new GameObject("CubesParent").transform; // Küplerin ebeveynini oluþtur

        GenerateGrid();
    }

    // Editor'de deðiþiklik yapýldýðýnda çaðrýlýr
    private void OnValidate()
    {
        // Grid boyutlarýný minimum 1 olarak sýnýrla
        gridSizeX = Mathf.Max(1, gridSizeX);
        gridSizeY = Mathf.Max(1, gridSizeY);

        UpdateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                CreateCube(x, y);
                
            }
        }
    }

    void UpdateGrid()
    {
        foreach (Transform child in cubesParent)
        {
            Destroy(child.gameObject);
        }

        GenerateGrid();
    }

    void CreateCube(int x, int y)
    {
        cubePosition = new Vector3(x * (cubeSize + gapSize), 0, y * (cubeSize + gapSize)) + gridOffset;
        GameObject cubeInstance = Instantiate(Cube,cubePosition, Quaternion.identity);
        //GameObject cube = Cube;//GameObject.CreatePrimitive(PrimitiveType.Cube);
        //Cube.transform.position = cubePosition;
        //Cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
        //cubeInstance.transform.SetParent(Cube.transform);
        //CubebePosition = new Vector3(x * (cubeSize + gapSize), 0, y * (cubeSize + gapSize)) + gridOffset;
        SpawnGem.instance.Spawn_Gem();

    }
}
