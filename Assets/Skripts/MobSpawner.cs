using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public GameObject mobPrefab;
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float minVerticalGap = 13f;
    public float maxVerticalGap = 19f;
    public float spawnYOffset = 5f;
    public Camera mainCam;
 
    private float nextSpawnY;
 
    void Awake()
    {
        if (mainCam == null) mainCam = Camera.main;
    }
 
    void Start()
    {
        if (mainCam == null) return;
        nextSpawnY = mainCam.transform.position.y + spawnYOffset;
    }
 
    void Update()
    {
        if (mainCam == null) return;
 
        float cameraTopY;
        if (mainCam.orthographic)
            cameraTopY = mainCam.transform.position.y + mainCam.orthographicSize;
        else
        {
            float zDist = Mathf.Abs(mainCam.transform.position.z);
            cameraTopY = mainCam.ViewportToWorldPoint(new Vector3(0.5f, 1f, zDist)).y;
        }
 
        while (nextSpawnY < cameraTopY + spawnYOffset)
        {
            float x = Random.Range(minX, maxX);
            Vector3 spawnPos = new Vector3(x, nextSpawnY, 0f);
            Instantiate(mobPrefab, spawnPos, Quaternion.identity);
 
            float gap = Random.Range(minVerticalGap, maxVerticalGap);
            nextSpawnY += gap;
        }
    }
}
