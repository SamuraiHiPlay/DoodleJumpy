using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallCheck : MonoBehaviour
{
    public Camera mainCam;
    public float fall = 1f;
    public string restart = "SampleScene";
    void Start()
    {
        if (mainCam == null)
        {
            mainCam = Camera.main;
        }
    }
    void Update()
    {
        if (mainCam == null)
        {
            return;
        

            float cameraBottom = mainCam.transform.position.y ;

            if (transform.position.y < cameraBottom - fall)
            {
                SceneManager.LoadScene(restart);
            }
        }
    }
}
