using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathPlayer : MonoBehaviour
{
    private Camera mainCam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mob"))
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
