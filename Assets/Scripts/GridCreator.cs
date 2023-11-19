using UnityEngine;

public class GridCreator : MonoBehaviour
{
    public static GridCreator instance;

    [SerializeField] private int gridSizeX = 4; 
    [SerializeField] private int gridSizeY = 4;
    [SerializeField] private float cubeSize = 1.0f;
    [SerializeField] private float gapSize = 0.1f; 
     private int area;
    [SerializeField] private Vector3 gridOffset = Vector3.zero; 
    [SerializeField] private GameObject Cube;
    [SerializeField] private GameObject grids;

    public Vector3 cubePosition;
    private Transform cubesParent;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        cubesParent = new GameObject("CubesParent").transform;
        area = gridSizeX * gridSizeY;
        GenerateGrid();
    }

    private void OnValidate()
    {
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
        
        SpawnGem.instance.Spawn_Gem();
        cubeInstance.transform.SetParent(grids.transform);
    }
}
