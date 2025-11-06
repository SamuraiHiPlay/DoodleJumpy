using UnityEngine;

public class PlatformRemoover : MonoBehaviour
{
    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        float bottomy =  mainCam.transform.position.y - 5f;
        if (transform.position.y < bottomy)
        {
            Destroy(gameObject);
        }
    }
}
